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
    class Program
    {
        static void Main(string[] args)
        {
            var code = File.ReadAllText("test.alx");
            var ast = AphidParser.Parse(code, isTextDocument: true);
            var emitter = new AphidPhpEmitter();
            var str = emitter.Compile(ast);
            File.WriteAllText(@"c:\xampp\htdocs\test.php", str);
        }
    }
}
