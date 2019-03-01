using Components.Aphid.Compiler;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantispid
{
    public static class ParserCode
    {
        public static CodeTypeReference GetTypeRef(ParserIdentifier property)
        {
            CodeTypeReference typeRef;

            switch (property.Type)
            {
                case "bool":
                    typeRef = CodeHelper.TypeRef<bool>();
                    break;

                case "string":
                    typeRef = CodeHelper.TypeRef<string>();
                    break;

                case "decimal":
                    typeRef = CodeHelper.TypeRef<decimal>();
                    break;

                default:
                    typeRef = CodeHelper.TypeRef(property.Type);
                    break;
            }

            if (property.IsList)
            {
                return GetListTypeRef(typeRef);
            }

            return typeRef;
        }


        public static CodeTypeReference GetListTypeRef(CodeTypeReference typeArg)
        {
            var listTypeRef = CodeHelper.TypeRef(typeof(List<>));
            listTypeRef.TypeArguments.Add(typeArg);

            return listTypeRef;
        }
    }
}
