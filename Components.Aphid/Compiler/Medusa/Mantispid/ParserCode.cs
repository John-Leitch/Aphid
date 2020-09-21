﻿using Components.Aphid.Compiler;
using System.CodeDom;
using System.Collections.Generic;

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
