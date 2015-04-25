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

        public RuleTypeBuilder(IEnumerable<RuleStruct> ruleTypes)
        {
            _ruleTypes = ruleTypes;
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

            foreach (var p in properties)
            {
                p.GetStatements.Add(CodeHelper.Return(GetFieldName(p.Name)));
            }

            decl.Members.AddRange(properties);

            decl.Members.AddRange(
                properties
                    .Select(x => new CodeMemberField(x.Type, GetFieldName(x.Name))
                    {
                        Attributes = MemberAttributes.Private,
                    })
                    .ToArray());

            var ctor = new CodeConstructor()
            {
                Attributes = MemberAttributes.Public,
            };

            ctor.Parameters.AddRange(
                properties
                    .Select(x => CreateCtorParameter(rule, x))
                    .ToArray());

            ctor.Statements.AddRange(
                properties
                    .Select(x => CodeHelper.Assign(GetFieldName(x.Name), GetLocalName(x.Name)))
                    .ToArray());

            decl.Members.Add(ctor);

            return decl;
        }

        private CodeMemberProperty[] CreateProperties(RuleStruct ruleType)
        {
            return ruleType.Properties
                .Select(x => new CodeMemberProperty()
                {
                    Name = x.Name,
                    Attributes = MemberAttributes.Public | MemberAttributes.Final,
                    Type = ParserCode.GetTypeRef(x),
                    HasGet = true,
                })
                .ToArray();
        }

        private CodeParameterDeclarationExpression CreateCtorParameter(RuleStruct rule, CodeMemberProperty property)
        {
            var exp = new CodeParameterDeclarationExpression(
                property.Type,
                GetLocalName(property.Name));

            if (rule.Properties.Single(x => x.Name == property.Name).IsOptional)
            {
                exp.CustomAttributes.Add(new CodeAttributeDeclaration(CodeHelper.TypeRef<OptionalAttribute>()));
            }

            return exp;
        }

        private string GetFieldName(string name)
        {
            return "_" + GetLocalName(name);
        }

        private string GetLocalName(string name)
        {
            return name.Substring(0, 1).ToLower() + name.Substring(1);
        }
    }
}
