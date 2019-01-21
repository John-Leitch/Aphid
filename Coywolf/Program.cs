using Components.Aphid.Compiler;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coywolf
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            new StringCompilerCli(
                "Coywolf",
                "PHP",
                "php",
                new AphidPhpEmitter(),
                isText: true)
                .Compile();
        }
    }
}
