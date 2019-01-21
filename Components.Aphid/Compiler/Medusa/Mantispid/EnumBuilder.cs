using Components.Aphid.Compiler;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Mantispid
{
    public class EnumBuilder
    {
        private readonly string _baseTypeName;

        private IEnumerable<string> _ruleTypes;

        public EnumBuilder(string baseTypeName, IEnumerable<string> ruleTypes)
        {
            _baseTypeName = baseTypeName;
            _ruleTypes = ruleTypes;
        }

        private string GetEnumName() => _baseTypeName + "Type";

        public CodeTypeDeclaration CreateEnum()
        {
            var name = GetEnumName();
            var decl = new CodeTypeDeclaration(name) { IsEnum = true };

            decl.CustomAttributes.Add(
                new CodeAttributeDeclaration(
                    CodeHelper.TypeRef<DataContractAttribute>(),
                    new CodeAttributeArgument("Name", CodeHelper.Value(name))));

            decl.Members.AddRange(
                _ruleTypes
                .Select(x => new CodeMemberField(name, x)
                {
                    CustomAttributes = new CodeAttributeDeclarationCollection(
                        new[]
                        {
                            new CodeAttributeDeclaration(
                                CodeHelper.TypeRef<EnumMemberAttribute>())
                        })
                })
                .ToArray());

            return decl;
        }
    }
}
