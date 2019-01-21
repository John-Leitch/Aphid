using System;
using System.CodeDom;

namespace Components.Aphid.Compiler
{
    public static class CodeMemberMethodExtension
    {
        public static void AddParameter(this CodeMemberMethod method, Type type, string name) =>
            method.Parameters.Add(new CodeParameterDeclarationExpression(type, name));

        public static void AddParameter(this CodeMemberMethod method, string type, string name) =>
            method.Parameters.Add(new CodeParameterDeclarationExpression(type, name));
    }
}
