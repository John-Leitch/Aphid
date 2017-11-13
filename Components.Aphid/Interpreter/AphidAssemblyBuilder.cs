using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Interpreter
{
    public class AphidAssemblyBuilder
    {
        private enum ClassAttributeScanState
        {
            Starting,
            InClass,
            InOfAttribute,
            InProperty,
        }

        public string AssemblyName { get; private set; }

        public string AssemblyFilename { get; private set; }

        private Lazy<ModuleBuilder> _moduleBuilder;

        public AphidAssemblyBuilder()
            : this(string.Format("AphidModule_{0}", Guid.NewGuid()))
        {
        }

        public AphidAssemblyBuilder(string assemblyName)
            : this(assemblyName, string.Format("{0}.dll", assemblyName))
        {
        }

        public AphidAssemblyBuilder(string assemblyName, string assemblyFilename)
        {
            AssemblyName = assemblyName;
            AssemblyFilename = assemblyFilename;

            _moduleBuilder = new Lazy<ModuleBuilder>(
                () => AppDomain.CurrentDomain
                    .DefineDynamicAssembly(
                        new AssemblyName(AssemblyName),
                        AssemblyBuilderAccess.Run)
                    .DefineDynamicModule(assemblyName));
        }

        public Type CreateType(ObjectExpression type, IEnumerable<string> imports)
        {
            if (type.Identifier == null ||
                !type.Identifier.Attributes.Any())
            {
                throw new InvalidOperationException("ObjectExpression has no type class attributes.");
            }

            var state = ClassAttributeScanState.Starting;
            var scanner = new AphidAttributeScanner(type.Identifier);
            scanner.Next();
            string defaultType = "System.Object";
            var defaultTypeSet = false;

            do
            {
                switch (state)
                {
                    case ClassAttributeScanState.Starting:
                        scanner.Require("class");
                        state = ClassAttributeScanState.InClass;
                        break;

                    case ClassAttributeScanState.InClass:
                        if (scanner.Match("of"))
                        {
                            if (defaultTypeSet || scanner.CurrentAttribute == null)
                            {
                                throw new AphidRuntimeException("Invalid 'of' attribute.");
                            }

                            defaultType = scanner.CurrentAttribute;
                            defaultTypeSet = true;
                            scanner.Next();
                            break;
                        }
                        else
                        {
                            throw new AphidRuntimeException(
                                "Invalid class attribute '{0}'.",
                                scanner.CurrentAttribute);
                        }

                    default:
                        throw new AphidRuntimeException(
                            "Invalid class attribute '{0}'.",
                            scanner.CurrentAttribute);
                }
            } while (!scanner.EndOfStream());

            if (state != ClassAttributeScanState.InClass)
            {
                throw new AphidParserException("Invalid class attributes.");
            }

            var name = type.Identifier.Identifier;

            var typeBuilder = _moduleBuilder.Value.DefineType(
                name,
                TypeAttributes.Public);

            foreach (var kvp in type.Pairs)
            {
                if (kvp.LeftOperand.Type != AphidExpressionType.IdentifierExpression)
                {
                    throw new AphidRuntimeException("Invalid class property lhs.");
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

            return typeBuilder.CreateType();
        }

        private void AddProperty(
            TypeBuilder typeBuilder,
            string defaultType,
            IdentifierExpression propertyDecl,
            IEnumerable<string> imports)
        {
            var t = GetPropertyType(defaultType, propertyDecl, imports);

            if (t == null)
            {
                throw new AphidRuntimeException(
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
            IEnumerable<string> imports)
        {
            if (property.Attributes == null || !property.Attributes.Any())
            {
                return InteropTypeResolver.ResolveType(
                    imports,
                    new[] { InteropTypeResolver.Unalias(defaultType) },
                    isType: true);
            }

            var scanner = new AphidAttributeScanner(property);
            scanner.Next();

            var t = InteropTypeResolver.ResolveType(
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
    }
}
