using Components.Aphid.Compiler;
using System.CodeDom;
using System.Collections.Generic;

namespace Mantispid
{
    public static class ParserCode
    {
        public static CodeTypeReference GetTypeRef(ParserIdentifier property)
        {
            CodeTypeReference typeRef = property.Type switch
            {
                "bool" => CodeHelper.TypeRef<bool>(),
                "string" => CodeHelper.TypeRef<string>(),
                "decimal" => CodeHelper.TypeRef<decimal>(),
                _ => CodeHelper.TypeRef(property.Type),
            };
            return property.IsList ? GetListTypeRef(typeRef) : typeRef;
        }


        public static CodeTypeReference GetListTypeRef(CodeTypeReference typeArg)
        {
            var listTypeRef = CodeHelper.TypeRef(typeof(List<>));
            listTypeRef.TypeArguments.Add(typeArg);

            return listTypeRef;
        }
    }
}
