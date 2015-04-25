using AphidCodeGenerator;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantispid
{
    public class EnumBuilder
    {
        private string _baseTypeName;

        private IEnumerable<string> _ruleTypes;

        public EnumBuilder(string baseTypeName, IEnumerable<string> ruleTypes)
        {
            _baseTypeName = baseTypeName;
            _ruleTypes = ruleTypes;
        }

        private string GetEnumName()
        {
            return _baseTypeName + "Type";
        }

        public CodeTypeDeclaration CreateEnum()
        {
            var name = GetEnumName();
            var decl = new CodeTypeDeclaration(name) { IsEnum = true };
            decl.Members.AddRange(_ruleTypes.Select(x => new CodeMemberField(name, x)).ToArray());

            return decl;
        }
    }
}
