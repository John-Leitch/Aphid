using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Library;
using Components.Aphid.Parser;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.UI
{
    public class AphidRepl
    {
        public void Run()
        {
            var interpreter = new AphidInterpreter();

            while (true)
            {
                Console.Write(">>> ");
                var code = Console.ReadLine();

                try
                {
                    var lexer = new AphidLexer(code);
                    var tokens = lexer.GetTokens();
                    var parser = new AphidParser(tokens);
                    parser.NextToken();

                    var exp = new UnaryOperatorExpression(
                        AphidTokenType.retKeyword,
                        parser.ParseExpression());

                    if (parser.NextToken())
                    {
                        throw new AphidParserException(parser.CurrentToken);
                    }

                    interpreter.InterpretExpression(exp);
                    var value = interpreter.GetReturnValue();

                    if (value != null && (value.Value != null || value.Any()))
                    {
                        Console.WriteLine(new AphidSerializer().Serialize(value));
                    }
                }
                catch (AphidParserException e)
                {
                    Cli.WriteErrorMessage("Syntax error:\r\n{0}", e.Message);
                }
                catch (Exception e)
                {
                    Cli.WriteErrorMessage("Runtime error:\r\n{0}", e.Message);
                    AphidCli.DumpStackTrace(interpreter);
                }
            }
        }
    }
}
