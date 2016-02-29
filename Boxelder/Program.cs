using Components.Aphid.Compiler;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxelder
{
    class Program
    {
        private const string _code = @"
class foo { x: 20, y: 30 };
obj = foo();
add = @(x, y) x + y;
obj.x |> @add(10) |> print;
";

        static void Main(string[] args)
        {
            var ast = AphidParser.Parse(_code);
            var emitter = new AphidPythonEmitter();
            var python = emitter.Compile(ast);
            File.WriteAllText(@"C:\temp\test.py", python);
        }
    }
}
