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
x = true;
func = @(x, y) x + y;
addTen = @(x) x + 10;
10 |> addTen |> print;
print(func(10, 20));
if (x) print('Hello world');
else print('Nope I guess');
";

        static void Main(string[] args)
        {
            var emitter = new AphidPythonEmitter();
            var python = emitter.Compile(AphidParser.Parse(_code));
            File.WriteAllText(@"C:\temp\test.py", python);
        }
    }
}
