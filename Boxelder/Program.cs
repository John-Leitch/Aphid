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

        private static string GenerateTokenMethods()
        {
            var fmt = "protected virtual void Emit{0}({0} expression) {{ " +
                "throw new NotImplementedException(); }}";

            var methods = Enum
                .GetValues(typeof(AphidExpressionType))
                .OfType<AphidExpressionType>()
                .Select(x => new
                {
                    Token = x,
                    Decl = string.Format(fmt, x.ToString())
                })
                .ToArray();

            var methodDecls = methods
                .Select(x => x.Decl)
                .Aggregate((x, y) => x + "\r\n" + y);

            var expCases = methods
                .Select(x => string.Format(
                    "case AphidExpressionType.{0}: Emit{0}(({0})expression); break;",
                    x.Token))
                .Aggregate((x, y) => x + "\r\n" + y);

            var expSwitchFmt = @"
                private void Emit(AphidExpression expression)
                {{
                    switch (expression.Type)
                    {{
                        {0}
                        default:
                            throw new NotImplementedException();
                    }}
                }}
";
            var expSwitch = string.Format(expSwitchFmt, expCases);

            var code = expSwitch + "\r\n" + methodDecls;


            return "";
        }
    }
}
