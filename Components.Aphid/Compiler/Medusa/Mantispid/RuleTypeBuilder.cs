using Components.Aphid.Compiler;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static Components.Aphid.Compiler.CodeHelper;

namespace Mantispid
{
    public class RuleTypeBuilder
    {
        private const string _getCollection = "GetCollection";

        private readonly ParserGeneratorConfig _config;

        private readonly IEnumerable<RuleStruct> _ruleTypes;

        private readonly RuleStructResolver _resolver;

        private readonly string _helperName;

        private readonly string _baseTypeName;

        public RuleTypeBuilder(ParserGeneratorConfig config, IEnumerable<RuleStruct> ruleTypes)
        {
            _config = config;
            _baseTypeName = config.BaseClass;
            _helperName = config.HelperClass;
            _resolver = new RuleStructResolver(_ruleTypes = ruleTypes);
        }

        public CodeTypeDeclarationCollection CreateRuleTypeClasses()
        {
            return new CodeTypeDeclarationCollection(
                _ruleTypes
                    .Select(CreateCodeType)
                    .Concat(new [] { CreateHelperType(), CreateParserContextType() })
                    .ToArray());
        }

        private CodeTypeDeclaration CreateHelperType()
        {
            var type = new CodeTypeDeclaration(_helperName)
            {
                Attributes =
                    MemberAttributes.Public |
                    MemberAttributes.Abstract |
                    MemberAttributes.Final
            };

            const string argName = "collection";
            var methodTypeName = "System.Collections.Generic.IEnumerable<" + _baseTypeName + ">";
            var methodType = TypeRef(methodTypeName);
            var t = Type.GetType(methodTypeName);

            var method = new CodeMemberMethod
            {
                Name = _getCollection,
                ReturnType = methodType,
                Attributes =
                    MemberAttributes.Public |
                    MemberAttributes.Static
            };

            method.Parameters.Add(new CodeParameterDeclarationExpression(
                methodType,
                argName));

            method.Statements.Add(
                new CodeConditionStatement(
                    BinOpExp(
                        VarRef(argName),
                        CodeBinaryOperatorType.ValueEquality,
                        Null()),
                    new CodeStatement[]
                    {
                        Return(new CodeArrayCreateExpression(
                            TypeRef(_baseTypeName),
                            0))
                    },
                    new CodeStatement[]
                    {
                        Return(VarRef(argName))
                    }));

            type.Members.Add(method);

            return type;
        }

        private CodeTypeDeclaration CreateCodeType(RuleStruct rule)
        {
            var decl = CreateType(rule.Name);
            decl.BaseTypes.Add(TypeRef(rule.BaseName));
            var properties = CreateProperties(rule);
            decl.Members.AddRange(properties);
            decl.Members.AddRange(CreateFields(properties));
            var publicCtor = CreateConstructor(rule, properties, isInternal: false);
            decl.Members.Add(publicCtor);
            decl.Members.Add(CreateConstructor(rule, properties, isInternal: true));

            if (publicCtor.Parameters.Count != 0)
            {
                decl.Members.Add(new CodeConstructor
                {
                    Attributes = MemberAttributes.Private
                });
            }

            AddGetChildrenMethod(rule, decl);
            AddTypeProperty(rule, decl);

            return decl;
        }

        private CodeTypeDeclaration CreateParserContextType()
        {
            var decl = CreateType(_config.ExpressionContextClass);

            foreach (var n in new[] { "Filename", "Code" })
            {
                decl.Members.AddRange(CreateAutoProperty(TypeRef<string>(), n));
            }

            return decl;
        }

        private static CodeTypeDeclaration CreateType(string name)
        {
            // Todo: extract code helper methods from this bullshit
            var decl = new CodeTypeDeclaration(name)
            {
                IsPartial = true,
                TypeAttributes = TypeAttributes.Sealed | TypeAttributes.Public
            };

            decl.CustomAttributes.Add(
                new CodeAttributeDeclaration(
                    TypeRef<SerializableAttribute>()));

            decl.CustomAttributes.Add(
                new CodeAttributeDeclaration(
                    TypeRef<DataContractAttribute>(),
                    new CodeAttributeArgument("IsReference", True())));

            return decl;
        }

        private static CodeMemberProperty[] CreateProperties(RuleStruct ruleType)
        {
            var isMutable = ParserGeneratorConfig.Current.IsAstMutable;

            var properties = ruleType.Properties
                .Select(x => new CodeMemberProperty
                {
                    Name = x.Name,
                    Attributes = MemberAttributes.Public | MemberAttributes.Final,
                    Type = ParserCode.GetTypeRef(x),
                    HasGet = true,
                    HasSet = isMutable,
                    CustomAttributes = new CodeAttributeDeclarationCollection(
                        new[]
                        {
                            new CodeAttributeDeclaration(
                                TypeRef<DataMemberAttribute>())
                        })
                })
                .ToArray();

            foreach (var p in properties)
            {
                p.GetStatements.Add(Return(GetFieldName(p.Name)));

                if (isMutable)
                {
                    p.SetStatements.Add(
                        Assign(
                            GetFieldName(p.Name),
                            VarRef("value")));
                }
            }

            return properties;
        }

        private static CodeTypeMember[] CreateAutoProperty(
            CodeTypeReference type,
            string name,
            bool isMutable = true,
            bool isDataMember = true)
        {
            var fieldName = GetFieldName(name);

            var field = new CodeMemberField(type, fieldName)
            {
                Attributes = MemberAttributes.Private
            };

            var prop = new CodeMemberProperty
            {
                Name = name,
                Attributes = MemberAttributes.Public | MemberAttributes.Final,
                Type = type,
                HasGet = true,
                HasSet = isMutable,
                CustomAttributes = new CodeAttributeDeclarationCollection(
                    isDataMember ?
                        new[]
                        {
                            new CodeAttributeDeclaration(
                                TypeRef<DataMemberAttribute>())
                        } :
                        new CodeAttributeDeclaration[0])
            };

            prop.GetStatements.Add(Return(fieldName));

            if (isMutable)
            {
                prop.SetStatements.Add(Assign(fieldName, VarRef("value")));
            }

            return new CodeTypeMember[] { field, prop };
        }

        private static CodeMemberField[] CreateFields(CodeMemberProperty[] properties)
        {
            return properties
                .Select(x => new CodeMemberField(x.Type, GetFieldName(x.Name))
                {
                    Attributes = MemberAttributes.Private
                })
                .ToArray();
        }

        private CodeConstructor CreateConstructor(
            RuleStruct rule,
            CodeMemberProperty[] properties,
            bool isInternal)
        {
            var ctor = new CodeConstructor
            {
                Attributes = !isInternal ?
                    MemberAttributes.Public :
                    MemberAttributes.Assembly
            };

            if (isInternal)
            {
                ctor.Parameters.Add(
                    new CodeParameterDeclarationExpression(
                        TypeRef(_config.ExpressionContextClass),
                        ParserName.ContextParam));

                ctor.Statements.Add(
                    Assign(
                        ParserName.ContextProperty,
                        ParserName.ContextParam));
            }
            else
            {
                ctor.Statements.Add(
                    Assign(
                            ParserName.ContextProperty,
                            New(TypeRef(_config.ExpressionContextClass))));
            }

            ctor.Parameters.AddRange(
                properties
                    .Select(x => CreateConstructorParameter(rule, x))
                    .ToArray());

            ctor.Statements.AddRange(
                properties
                    .SelectMany(x => CreateConstructorAssignmentStatements(rule, x))
                    .ToArray());

            return ctor;
        }

        private static CodeStatement[] CreateConstructorAssignmentStatements(
            RuleStruct rule,
            CodeMemberProperty property)
        {
            var paramName = GetLocalName(property.Name);
            var fieldName = GetFieldName(property.Name);
            var assignStmt = Assign(fieldName, paramName);
            var stmts = new List<CodeStatement>();

            if (property.Type.BaseType != typeof(List<>).FullName || !IsOptional(rule, property))
            {
                stmts.Add(assignStmt);
            }
            else
            {
                stmts.Add(
                    new CodeConditionStatement(
                        BinOpExp(
                            VarRef(paramName),
                            CodeBinaryOperatorType.IdentityInequality,
                            Null()),
                        new[] { assignStmt },
                        new[]
                        {
                            Assign(
                                fieldName,
                                new CodeObjectCreateExpression(property.Type))
                        }));
            }

            return stmts.ToArray();
        }

        private CodeParameterDeclarationExpression CreateConstructorParameter(
            RuleStruct rule,
            CodeMemberProperty property)
        {
            var exp = new CodeParameterDeclarationExpression(
                property.Type,
                GetLocalName(property.Name));

            if (IsOptional(rule, property))
            {
                exp.CustomAttributes.Add(
                    new CodeAttributeDeclaration(TypeRef<OptionalAttribute>()));
            }

            return exp;
        }

        private void AddGetChildrenMethod(RuleStruct rule, CodeTypeDeclaration decl)
        {
            if (!rule.Properties.Any(x => _resolver.Is(x.Type, _baseTypeName)))
            {
                return;
            }

            decl.BaseTypes.Add("IParentNode");

            var children = rule.Properties
                .Where(x => _resolver.Is(x.Type, _baseTypeName))
                .ToArray();

            var scalarChildren = children
                .Where(x => !x.IsList)
                .Select(x => VarRef(x.Name))
                .ToArray(); ;

            CodeExpression childExpression = scalarChildren.Length > 0 ?
                new CodeArrayCreateExpression(_baseTypeName, scalarChildren) :
                null;

            var hasLists = false;

            foreach (var child in children.Where(x => x.IsList))
            {
                hasLists = true;
                CodeExpression childRef = VarRef(child.Name);

                if (childExpression != null)
                {
                    var target = childExpression is CodeArrayCreateExpression ?
                        childExpression :
                        Invoke(childExpression, "OfType", new[] { _baseTypeName });

                    childRef = Invoke(
                        TypeRefExp(_helperName),
                        _getCollection,
                        childRef);

                    childExpression = Invoke(target, "Concat", childRef);
                }
                else
                {
                    childExpression = childRef;
                }
            }

            if (hasLists)
            {
                childExpression = Invoke(childExpression, "ToArray");
            }

            var method = new CodeMemberMethod
            {
                Attributes = MemberAttributes.Public | MemberAttributes.Final,
                Name = "GetChildren",
                ReturnType = new CodeTypeReference("IEnumerable", TypeRef(_baseTypeName))
            };

            method.Statements.Add(Return(childExpression));
            decl.Members.Add(method);
        }

        private void AddTypeProperty(RuleStruct rule, CodeTypeDeclaration decl)
        {
            var enumType = _baseTypeName + "Type";

            var prop = new CodeMemberProperty
            {
                Attributes = MemberAttributes.Public |
                    MemberAttributes.Override,
                Type = TypeRef(enumType),
                Name = "Type"
            };

            prop.GetStatements.Add(Return(PropRef(enumType, rule.Name)));
            decl.Members.Add(prop);
        }

        private static string GetFieldName(string name) => "_" + GetLocalName(name);

        private static string GetLocalName(string name) => name.Substring(0, 1).ToLower() + name.Substring(1);

        private static bool IsOptional(RuleStruct rule, CodeMemberProperty property) =>
            rule.Properties.Single(x => x.Name == property.Name).IsOptional;
    }
}