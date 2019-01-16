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
            using (var provider = new CSharpCodeProvider())
            {
                using (var stream = new MemoryStream())
                {
                    using (var writer = new StreamWriter(stream))
                    {
                        if (codeObj is CodeCompileUnit cu)
                        {
                            provider.GenerateCodeFromCompileUnit(cu, writer, null);
                        }
                        else if (codeObj is CodeExpression exp)
                        {
                            provider.GenerateCodeFromExpression(exp, writer, null);
                        }
                        else if (codeObj is CodeStatement stmt)
                        {
                            provider.GenerateCodeFromStatement(stmt, writer, null);
                        }
                        else if (codeObj is CodeTypeMember member)
                        {
                            provider.GenerateCodeFromMember(member, writer, null);
                        }
                        else if (codeObj is CodeNamespace ns)
                        {
                            provider.GenerateCodeFromNamespace(ns, writer, null);
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
    }
}
