using Components.Aphid.Interpreter;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using Components.Aphid.TypeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

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

        private readonly HashSet<string> _types = new HashSet<string>();

        private readonly ReaderWriterLockSlim _importsLock;

        public string AssemblyName { get; private set; }

        public string AssemblyFilename { get; private set; }

        public AssemblyBuilder Assembly { get; private set; }

        public AphidAssemblyBuilder(AphidInterpreter interpreter, ReaderWriterLockSlim importsLock)
            : this(interpreter, $"AphidModule_{Guid.NewGuid().ToString()}", importsLock)
        {
        }

        public AphidAssemblyBuilder(
            AphidInterpreter interpreter,
            string assemblyName,
            ReaderWriterLockSlim importsLock)
            : this(interpreter, assemblyName, $"{assemblyName}.dll", importsLock)
        {
        }

        public AphidAssemblyBuilder(
            AphidInterpreter interpreter,
            string assemblyName,
            string assemblyFilename,
            ReaderWriterLockSlim importsLock)
            : base(interpreter)
        {
            AssemblyName = assemblyName;
            AssemblyFilename = assemblyFilename;
            SetModuleBuilder(AssemblyBuilderAccess.Run);
            _importsLock = importsLock;
        }

        public void SetAssemblyFile(
            string assemblyName,
            string assemblyFilename) =>
            SetAssemblyFile(assemblyName, assemblyFilename, null);

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

        private void SetModuleBuilder(AssemblyBuilderAccess access) => _moduleBuilder = new Lazy<ModuleBuilder>(
                () => (Assembly = AppDomain.CurrentDomain
                    .DefineDynamicAssembly(
                        new AssemblyName(AssemblyName),
                        access))
                    .DefineDynamicModule(AssemblyName));

        private void SetModuleBuilder(AssemblyBuilderAccess access, string dir) => _moduleBuilder = new Lazy<ModuleBuilder>(
                () => (Assembly = AppDomain.CurrentDomain
                    .DefineDynamicAssembly(
                        new AssemblyName(AssemblyName),
                        access,
                        dir))
                    .DefineDynamicModule(AssemblyName));

        public Type CreateType(ObjectExpression type, HashSet<string> imports)
        {
            if (type.Identifier == null || type.Identifier.Attributes.Count == 0)
            {
                throw new InvalidOperationException("ObjectExpression has no type class attributes.");
            }

            var state = ClassAttributeScanState.Starting;
            var scanner = new AphidAttributeScanner(type.Identifier);
            scanner.Next();
            var defaultType = "System.Object";
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
            var path = new[] { name };
            Type type;

            //_importsLock.EnterReadLock();

            //try
            //{
                type = resolver.TryResolveType(
                    Interpreter.GetImports(),
                    _importsLock,
                    path,
                    isType: true);
            //}
            //finally
            //{
            //    _importsLock.ExitReadLock();
            //}

            return type;
        }

        private void AddProperty(
            TypeBuilder typeBuilder,
            string defaultType,
            IdentifierExpression propertyDecl,
            HashSet<string> imports)
        {
            var t = GetPropertyType(typeBuilder, defaultType, propertyDecl, imports);

            if (t == null)
            {
                throw Interpreter.CreateRuntimeException(
                    "Could not resolve property type for '{0}.{1}'.",
                    typeBuilder.Name,
                    propertyDecl.Identifier);
            }

            string name = propertyDecl.Identifier,
                fieldName = $"_{name}",
                getName = $"get_{name}",
                setName = $"set_{name}";

            var field = typeBuilder.DefineField(fieldName, t, FieldAttributes.Private);
            var property = typeBuilder.DefineProperty(name, PropertyAttributes.HasDefault, t, null);

            const MethodAttributes accessorAttr =
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
                setName,
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
            TypeBuilder typeBuilder,
            string defaultType,
            IdentifierExpression property,
            HashSet<string> imports)
        {
            if (property.Attributes == null || property.Attributes.Count == 0)
            {
                return Interpreter.InteropTypeResolver.ResolveType(
                    imports,
                    _importsLock,
                    new[] { InteropTypeResolver.Unalias(defaultType) },
                    isType: true);
            }

            var scanner = new AphidAttributeScanner(property);
            scanner.Next();
            var typeName = InteropTypeResolver.Unalias(scanner.CurrentAttribute);

            Type t;

            if (typeName == typeBuilder.Name)
            {
                t = typeBuilder;
            }
            else
            {
                t = Interpreter.InteropTypeResolver.ResolveType(
                    imports,
                    _importsLock,
                    new[] { typeName },
                    isType: true);
            }

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

        public string[] GetTypeNames() => _types.ToArray();

        public bool IsTypeDefined(string typeName) => _types.Contains(typeName);
    }
}
