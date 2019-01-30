using Components.Aphid.Compiler;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Mantispid
{
    public class RuleTypeBuilder
    {
        private const string _getCollection = "GetCollection";

        private ParserGeneratorConfig _config;

        private IEnumerable<RuleStruct> _ruleTypes;

        private RuleStructResolver _resolver;

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
                    MemberAttributes.Final,
            };

            var argName = "collection";
            var methodTypeName = "System.Collections.Generic.IEnumerable<" + _baseTypeName + ">";
            var methodType = CodeHelper.TypeRef(methodTypeName);
            var t = Type.GetType(methodTypeName);

            var method = new CodeMemberMethod
            {
                Name = _getCollection,
                ReturnType = methodType,
                Attributes =
                    MemberAttributes.Public |
                    MemberAttributes.Static,
            };

            method.Parameters.Add(new CodeParameterDeclarationExpression(
                methodType,
                argName));

            method.Statements.Add(
                new CodeConditionStatement(
                    CodeHelper.BinOpExp(
                        CodeHelper.VarRef(argName),
                        CodeBinaryOperatorType.ValueEquality,
                        CodeHelper.Null()),
                    new CodeStatement[]
                    {
                        CodeHelper.Return(new CodeArrayCreateExpression(
                            CodeHelper.TypeRef(_baseTypeName),
                            0))
                    },
                    new CodeStatement[]
                    {
                        CodeHelper.Return(CodeHelper.VarRef(argName))
                    }));
            
            type.Members.Add(method);

            return type;
        }

        private CodeTypeDeclaration CreateCodeType(RuleStruct rule)
        {
            var decl = CreateType(rule.Name);
            decl.BaseTypes.Add(CodeHelper.TypeRef(rule.BaseName));
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
                decl.Members.AddRange(CreateAutoProperty(CodeHelper.TypeRef<string>(), n));
            }

            return decl;
        }

        private static CodeTypeDeclaration CreateType(string name)
        {
            // Todo: extract code helper methods from this bullshit
            var decl = new CodeTypeDeclaration(name)
            {
                IsPartial = true,
            };

            decl.CustomAttributes.Add(
                new CodeAttributeDeclaration(
                    CodeHelper.TypeRef<SerializableAttribute>()));

            decl.CustomAttributes.Add(
                new CodeAttributeDeclaration(
                    CodeHelper.TypeRef<DataContractAttribute>(),
                    new CodeAttributeArgument("IsReference", CodeHelper.True())));

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
                                CodeHelper.TypeRef<DataMemberAttribute>())
                        }),
                })
                .ToArray();

            foreach (var p in properties)
            {
                p.GetStatements.Add(CodeHelper.Return(GetFieldName(p.Name)));

                if (isMutable)
                {
                    p.SetStatements.Add(
                        CodeHelper.Assign(
                            GetFieldName(p.Name),
                            CodeHelper.VarRef("value")));
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
                                CodeHelper.TypeRef<DataMemberAttribute>())
                        } :
                        new CodeAttributeDeclaration[0]),
            };

            prop.GetStatements.Add(CodeHelper.Return(fieldName));

            if (isMutable)
            {
                prop.SetStatements.Add(CodeHelper.Assign(fieldName, CodeHelper.VarRef("value")));
            }

            return new CodeTypeMember[] { field, prop };
        }

        private static CodeMemberField[] CreateFields(CodeMemberProperty[] properties)
        {
            return properties
                .Select(x => new CodeMemberField(x.Type, GetFieldName(x.Name))
                {
                    Attributes = MemberAttributes.Private,
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
                    MemberAttributes.Assembly,
            };

            if (isInternal)
            {
                ctor.Parameters.Add(
                    new CodeParameterDeclarationExpression(
                        CodeHelper.TypeRef(_config.ExpressionContextClass),
                        ParserName.ContextParam));

                ctor.Statements.Add(
                    CodeHelper.Assign(
                        ParserName.ContextProperty,
                        ParserName.ContextParam));
            }
            else
            {
                ctor.Statements.Add(
                    CodeHelper.Assign(
                            ParserName.ContextProperty,
                            CodeHelper.New(CodeHelper.TypeRef(_config.ExpressionContextClass))));
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
            var assignStmt = CodeHelper.Assign(fieldName, paramName);
            var stmts = new List<CodeStatement>();

            if (property.Type.BaseType != typeof(List<>).FullName || !IsOptional(rule, property))
            {
                stmts.Add(assignStmt);
            }
            else
            {
                stmts.Add(
                    new CodeConditionStatement(
                        CodeHelper.BinOpExp(
                            CodeHelper.VarRef(paramName),
                            CodeBinaryOperatorType.IdentityInequality,
                            CodeHelper.Null()),
                        new[] { assignStmt },
                        new[]
                        { 
                            CodeHelper.Assign(
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
                    new CodeAttributeDeclaration(CodeHelper.TypeRef<OptionalAttribute>()));
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
                .Select(x => CodeHelper.VarRef(x.Name))
                .ToArray(); ;

            CodeExpression childExpression = scalarChildren.Length > 0 ?
                new CodeArrayCreateExpression(_baseTypeName, scalarChildren) :
                null;

            var hasLists = false;

            foreach (var child in children.Where(x => x.IsList))
            {
                hasLists = true;
                CodeExpression childRef = CodeHelper.VarRef(child.Name);

                if (childExpression != null)
                {
                    var target = childExpression is CodeArrayCreateExpression ? 
                        childExpression : 
                        CodeHelper.Invoke(childExpression, "OfType", new[] { _baseTypeName });

                    childRef = CodeHelper.Invoke(
                        CodeHelper.TypeRefExp(_helperName),
                        _getCollection,
                        childRef);

                    childExpression = CodeHelper.Invoke(target, "Concat", childRef);
                }
                else
                {
                    childExpression = childRef;
                }
            }

            if (hasLists)
            {
                childExpression = CodeHelper.Invoke(childExpression, "ToArray");
            }

            var method = new CodeMemberMethod
            {
                Attributes = MemberAttributes.Public | MemberAttributes.Final,
                Name = "GetChildren",
                ReturnType = new CodeTypeReference("IEnumerable", CodeHelper.TypeRef(_baseTypeName)),
            };

            method.Statements.Add(CodeHelper.Return(childExpression));
            decl.Members.Add(method);
        }

        private void AddTypeProperty(RuleStruct rule, CodeTypeDeclaration decl)
        {
            var enumType = _baseTypeName + "Type";

            var prop = new CodeMemberProperty
            {
                Attributes = MemberAttributes.Public | MemberAttributes.Override,
                Type = CodeHelper.TypeRef(enumType),
                Name = "Type",
            };

            prop.GetStatements.Add(CodeHelper.Return(CodeHelper.PropRef(enumType, rule.Name)));
            decl.Members.Add(prop);
        }

        private static string GetFieldName(string name) => "_" + GetLocalName(name);

        private static string GetLocalName(string name) => name.Substring(0, 1).ToLower() + name.Substring(1);

        private static bool IsOptional(RuleStruct rule, CodeMemberProperty property) =>
            rule.Properties.Single(x => x.Name == property.Name).IsOptional;
    }
}