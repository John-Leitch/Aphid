using AphidCodeGenerator;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mantispid
{
    public class RuleTypeBuilder
    {
        private IEnumerable<RuleStruct> _ruleTypes;

        private RuleStructResolver _resolver;

        private string _baseTypeName;

        public RuleTypeBuilder(string baseTypeName, IEnumerable<RuleStruct> ruleTypes)
        {
            _baseTypeName = baseTypeName;
            _resolver = new RuleStructResolver(_ruleTypes = ruleTypes);
        }

        public CodeTypeDeclarationCollection CreateRuleTypeClasses()
        {
            return new CodeTypeDeclarationCollection(
                _ruleTypes
                    .Select(CreateCodeType)
                    .ToArray());
        }

        private CodeTypeDeclaration CreateCodeType(RuleStruct rule)
        {
            // Todo: extract code helper methods from this bullshit
            var decl = new CodeTypeDeclaration(rule.Name)
            {
                IsPartial = true,
            };

            decl.BaseTypes.Add(CodeHelper.TypeRef(rule.BaseName));
            var properties = CreateProperties(rule);
            decl.Members.AddRange(properties);
            decl.Members.AddRange(CreateFields(properties));
            decl.Members.Add(CreateConstructor(rule, properties));
            AddGetChildrenMethod(rule, decl);
            AddTypeProperty(rule, decl);

            return decl;
        }

        private CodeMemberProperty[] CreateProperties(RuleStruct ruleType)
        {
            var properties = ruleType.Properties
                .Select(x => new CodeMemberProperty()
                {
                    Name = x.Name,
                    Attributes = MemberAttributes.Public | MemberAttributes.Final,
                    Type = ParserCode.GetTypeRef(x),
                    HasGet = true,
                })
                .ToArray();

            foreach (var p in properties)
            {
                p.GetStatements.Add(CodeHelper.Return(GetFieldName(p.Name)));
            }

            return properties;
        }

        private CodeMemberField[] CreateFields(CodeMemberProperty[] properties)
        {
            return properties
                .Select(x => new CodeMemberField(x.Type, GetFieldName(x.Name))
                {
                    Attributes = MemberAttributes.Private,
                })
                .ToArray();
        }

        private CodeConstructor CreateConstructor(RuleStruct rule, CodeMemberProperty[] properties)
        {
            var ctor = new CodeConstructor()
            {
                Attributes = MemberAttributes.Public,
            };

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

        private CodeStatement[] CreateConstructorAssignmentStatements(
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
                var condition = CodeHelper.BinOpExp(
                    CodeHelper.VarRef(paramName), 
                    CodeBinaryOperatorType.IdentityInequality,
                    CodeHelper.Null());

                var createStmt = CodeHelper.Assign(
                    fieldName, 
                    new CodeObjectCreateExpression(property.Type));

                var conditionStmt = new CodeConditionStatement(
                    condition, 
                    new[] { assignStmt },
                    new[] { createStmt });

                stmts.Add(conditionStmt);
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

                CodeExpression childExpression = scalarChildren.Any() ? 
                    new CodeArrayCreateExpression(_baseTypeName, scalarChildren) : 
                    null;

                var hasLists = false;

                foreach (var child in children.Where(x => x.IsList))
                {
                    hasLists = true;
                    var childRef = CodeHelper.VarRef(child.Name);

                    if (childExpression != null)
                    {
                        childExpression = CodeHelper.Invoke(childExpression, "Concat", childRef);
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

                var method = new CodeMemberMethod()
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

            var prop = new CodeMemberProperty()
            {
                Attributes = MemberAttributes.Public | MemberAttributes.Override,
                Type = CodeHelper.TypeRef(enumType),
                Name = "Type",
            };

            prop.GetStatements.Add(CodeHelper.Return(CodeHelper.PropRef(enumType, rule.Name)));
            decl.Members.Add(prop);
        }        

        private string GetFieldName(string name)
        {
            return "_" + GetLocalName(name);
        }

        private string GetLocalName(string name)
        {
            return name.Substring(0, 1).ToLower() + name.Substring(1);
        }

        private bool IsOptional(RuleStruct rule, CodeMemberProperty property)
        {
            return rule.Properties.Single(x => x.Name == property.Name).IsOptional;
        }
    }
}