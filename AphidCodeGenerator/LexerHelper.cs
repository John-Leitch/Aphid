using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AphidCodeGenerator
{
    public static class LexerHelper
    {
        public static string GenerateLexer(string scriptFile)
        {
            var llex = PathHelper.GetExecutingPath("llex.exe");
            var tmpFile = Path.GetTempFileName();

            AppDomain.CurrentDomain.ExecuteAssembly(
                llex,
                new[] { scriptFile, tmpFile });

            var snippet = File.ReadAllText(tmpFile);
            File.Delete(tmpFile);
            return snippet;
        }

        public static CodeSnippetCompileUnit GenerateLexerCompileUnit(string scriptFile)
        {
            return new CodeSnippetCompileUnit(GenerateLexer(scriptFile));
        }
    }
}
