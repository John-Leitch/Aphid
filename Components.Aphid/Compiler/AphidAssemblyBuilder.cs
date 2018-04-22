using Components.Aphid.Interpreter;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using Components.Aphid.TypeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Compiler
{
    public class AphidAssemblyBuilder : AphidRuntimeComponent
    {
        private enum ClassAttributeScanState
        {
            Starting,
            InClass,
            InOfAttribute,
            InProperty,
        }

        private Lazy<ModuleBuilder> _moduleBuilder;

        private List<string> _types = new List<string>();

        public string AssemblyName { get; private set; }

        public string AssemblyFilename { get; private set; }

        public AssemblyBuilder Assembly { get; private set; }

        public AphidAssemblyBuilder(AphidInterpreter interpreter)
            : this(interpreter, string.Format("AphidModule_{0}", Guid.NewGuid()))
        {
        }

        public AphidAssemblyBuilder(AphidInterpreter interpreter, string assemblyName)
            : this(interpreter, assemblyName, string.Format("{0}.dll", assemblyName))
        {
        }

        public AphidAssemblyBuilder(AphidInterpreter interpreter, string assemblyName, string assemblyFilename)
            : base(interpreter)
        {
            AssemblyName = assemblyName;
            AssemblyFilename = assemblyFilename;
            SetModuleBuilder(AssemblyBuilderAccess.Run);
        }

        public void SetAssemblyFile(
            string assemblyName,
            string assemblyFilename)
        {
            SetAssemblyFile(assemblyName, assemblyFilename, null);
        }

        public void SetAssemblyFile(
            string assemblyName,
            string assemblyFilename,
            string dir)
        {
            AssemblyName = assemblyName;
            AssemblyFilename = assemblyFilename;

            if (dir != null)
            {
                SetModuleBuilder(AssemblyBuilderAccess.RunAndSave, dir);
            }
            else
            {
                SetModuleBuilder(AssemblyBuilderAccess.RunAndSave);
            }
        }

        private void SetModuleBuilder(AssemblyBuilderAccess access)
        {
            _moduleBuilder = new Lazy<ModuleBuilder>(
                () => (Assembly = AppDomain.CurrentDomain
                    .DefineDynamicAssembly(
                        new AssemblyName(AssemblyName),
                        access))
                    .DefineDynamicModule(AssemblyName));
        }

        private void SetModuleBuilder(AssemblyBuilderAccess access, string dir)
        {
            _moduleBuilder = new Lazy<ModuleBuilder>(
                () => (Assembly = AppDomain.CurrentDomain
                    .DefineDynamicAssembly(
                        new AssemblyName(AssemblyName),
                        access,
                        dir))
                    .DefineDynamicModule(AssemblyName));
        }

        public Type CreateType(ObjectExpression type, IEnumerable<string> imports)
        {
            if (type.Identifier == null || !type.Identifier.Attributes.Any())
            {
                throw new InvalidOperationException("ObjectExpression has no type class attributes.");
            }

            var state = ClassAttributeScanState.Starting;
            var scanner = new AphidAttributeScanner(type.Identifier);
            scanner.Next();
            string defaultType = "System.Object";
            var defaultTypeSet = false;
            var interfaces = new List<Type>();
            Type baseType = null;

            do
            {
                switch (state)
                {
                    case ClassAttributeScanState.Starting:
                        scanner.Require(AphidName.Class);
                        state = ClassAttributeScanState.InClass;
                        break;

                    case ClassAttributeScanState.InClass:
                        if (scanner.Match(AphidName.Of))
                        {
                            if (defaultTypeSet || scanner.CurrentAttribute == null)
                            {
                                throw Interpreter.CreateRuntimeException("Invalid 'of' attribute.");
                            }

                            defaultType = scanner.CurrentAttribute;
                            defaultTypeSet = true;
                            scanner.Next();
                            break;
                        }
                        else if (!scanner.EndOfStream())
                        {
                            var superType = ResolveBaseType(scanner.CurrentAttribute);
                            scanner.Next();

                            if (superType == null)
                            {
                                throw Interpreter.CreateRuntimeException(
                                    "Could not resolve base type {0} in class declaration '{1}'.",
                                    scanner.CurrentAttribute,
                                    type.ToString());
                            }
                            else if (superType.IsInterface)
                            {
                                interfaces.Add(superType);
                            }
                            else if (baseType == null)
                            {
                                baseType = superType;
                            }
                            else
                            {
                                throw Interpreter.CreateRuntimeException(
                                    "Type is already subclass of {0}, cannot inherit from {1}.",
                                    baseType,
                                    superType);
                            }
                        }
                        else
                        {
                            throw Interpreter.CreateRuntimeException(
                                "Invalid class attribute '{0}'.",
                                scanner.CurrentAttribute);
                        }
                        break;

                    default:
                        throw Interpreter.CreateRuntimeException(
                            "Invalid class attribute '{0}'.",
                            scanner.CurrentAttribute);
                }
            } while (!scanner.EndOfStream());

            if (state != ClassAttributeScanState.InClass)
            {
                throw new AphidParserException("Invalid class attributes.");
            }

            var name = type.Identifier.Identifier;

            TypeBuilder typeBuilder;

            if (baseType == null && interfaces.Count == 0)
            {
                typeBuilder = _moduleBuilder.Value.DefineType(
                    name,
                    TypeAttributes.Public);
            }
            else if (interfaces.Count == 0)
            {
                typeBuilder = _moduleBuilder.Value.DefineType(
                       name,
                       TypeAttributes.Public,
                       baseType);
            }
            else
            {
                typeBuilder = _moduleBuilder.Value.DefineType(
                       name,
                       TypeAttributes.Public,
                       baseType,
                       interfaces.ToArray());
            }

            foreach (var kvp in type.Pairs)
            {
                if (kvp.LeftOperand.Type != AphidExpressionType.IdentifierExpression)
                {
                    throw Interpreter.CreateRuntimeException("Invalid class property lhs.");
                }

                if (kvp.RightOperand.Type == AphidExpressionType.IdentifierExpression &&
                    kvp.LeftOperand.ToIdentifier().Identifier == kvp.RightOperand.ToIdentifier().Identifier)
                {
                    AddProperty(typeBuilder, defaultType, kvp.LeftOperand.ToIdentifier(), imports);
                }
                else
                {
                    throw new NotImplementedException();
                }
            }

            var t = typeBuilder.CreateType();
            _types.Add(t.FullName);

            return t;
        }

        private Type ResolveBaseType(string name)
        {
            var resolver = Interpreter.InteropTypeResolver;

            var type = resolver.TryResolveType(
                Interpreter.GetImports().ToArray(),
                new[] { name },
                isType: true);

            return type;
        }

        private void AddProperty(
            TypeBuilder typeBuilder,
            string defaultType,
            IdentifierExpression propertyDecl,
            IEnumerable<string> imports)
        {
            var t = GetPropertyType(defaultType, propertyDecl, imports.ToArray());

            if (t == null)
            {
                throw Interpreter.CreateRuntimeException(
                    "Could not resolve property type for '{0}.{1}'.",
                    typeBuilder.Name,
                    propertyDecl.Identifier);
            }

            string name = propertyDecl.Identifier,
                fieldName = string.Format("_{0}", name),
                getName = string.Format("get_{0}", name),
                setName = string.Format("set_{0}", name);

            var field = typeBuilder.DefineField(fieldName, t, FieldAttributes.Private);
            var property = typeBuilder.DefineProperty(name, PropertyAttributes.HasDefault, t, null);

            var accessorAttr =
                MethodAttributes.Public |
                MethodAttributes.SpecialName |
                MethodAttributes.HideBySig;

            var getter = typeBuilder.DefineMethod(
                getName,
                accessorAttr,
                t,
                Type.EmptyTypes);

            var getIL = getter.GetILGenerator();
            getIL.Emit(OpCodes.Ldarg_0);
            getIL.Emit(OpCodes.Ldfld, field);
            getIL.Emit(OpCodes.Ret);

            property.SetGetMethod(getter);

            var setter = typeBuilder.DefineMethod(
                getName,
                accessorAttr,
                null,
                new[] { t });

            var setIL = setter.GetILGenerator();
            setIL.Emit(OpCodes.Ldarg_0);
            setIL.Emit(OpCodes.Ldarg_1);
            setIL.Emit(OpCodes.Stfld, field);
            setIL.Emit(OpCodes.Ret);

            property.SetSetMethod(setter);
        }

        private Type GetPropertyType(
            string defaultType,
            IdentifierExpression property,
            string[] imports)
        {
            if (property.Attributes == null || !property.Attributes.Any())
            {
                return Interpreter.InteropTypeResolver.ResolveType(
                    imports,
                    new[] { InteropTypeResolver.Unalias(defaultType) },
                    isType: true);
            }

            var scanner = new AphidAttributeScanner(property);
            scanner.Next();

            var t = Interpreter.InteropTypeResolver.ResolveType(
                imports,
                new[] { InteropTypeResolver.Unalias(scanner.CurrentAttribute) },
                isType: true);

            if (!scanner.Next())
            {
                return t;
            }

            if (scanner.Match("list"))
            {
                t = typeof(List<>).MakeGenericType(t);
            }
            else if (scanner.Match("set"))
            {
                t = t.MakeArrayType();
            }
            else
            {
                throw new AphidParserException(
                    "Invalid property attribute '{0}'.",
                    scanner.CurrentAttribute);
            }

            if (!scanner.EndOfStream())
            {
                throw new AphidParserException(
                        "Unexpected property attribute '{0}'.",
                        scanner.CurrentAttribute);
            }

            return t;
        }

        public string[] GetTypeNames()
        {
            return _types.ToArray();
        }

        public bool IsTypeDefined(string typeName)
        {
            return _types.Contains(typeName);
        }
    }
}
