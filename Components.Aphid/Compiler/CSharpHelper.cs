using Microsoft.CSharp;
using System;
using System.CodeDom;
using System.IO;

namespace Components.Aphid.Compiler
{
    public static class CSharpHelper
    {
        public static string GenerateCode(CodeObject codeObj)
        {
            var provider = new CSharpCodeProvider();

            using (var stream = new MemoryStream())
            using (var writer = new StreamWriter(stream))
            {
                if (codeObj is CodeCompileUnit)
                {
                    provider.GenerateCodeFromCompileUnit(codeObj as CodeCompileUnit, writer, null);
                }
                else if (codeObj is CodeExpression)
                {
                    provider.GenerateCodeFromExpression(codeObj as CodeExpression, writer, null);
                }
                else if (codeObj is CodeStatement)
                {
                    provider.GenerateCodeFromStatement(codeObj as CodeStatement, writer, null);
                }
                else if (codeObj is CodeTypeMember)
                {
                    provider.GenerateCodeFromMember(codeObj as CodeTypeMember, writer, null);
                }
                else if (codeObj is CodeNamespace)
                {
                    provider.GenerateCodeFromNamespace(codeObj as CodeNamespace, writer, null);
                }
                else
                {
                    throw new InvalidOperationException();
                }

                writer.Flush();
                stream.Position = 0;
                using (var reader = new StreamReader(stream))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
