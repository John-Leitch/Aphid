using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Library;
using Components.Aphid.Parser;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.UI
{
    public class AphidRepl
    {
        public AphidInterpreter Interpreter { get; set; }

        public void Run()
        {
            if (Interpreter == null)
            {
                Interpreter = new AphidInterpreter();
            }

            while (true)
            {
                Console.Write(">>> ");
                var code = Console.ReadLine();

                if (!Debugger.IsAttached)
                {
                    try
                    {
                        RunCode(code);
                    }
                    catch (AphidParserException e)
                    {
                        Cli.WriteErrorMessage("Syntax error:\r\n{0}", e.Message);
                    }
                    catch (Exception e)
                    {
                        Cli.WriteErrorMessage("Runtime error:\r\n{0}", e.Message);
                        AphidCli.DumpStackTrace(Interpreter);
                    }
                }
                else
                {
                    RunCode(code);
                }

                Interpreter.ResetState();
            }
        }

        private void RunCode(string code)
        {
            var lexer = new AphidLexer(code);
            var tokens = lexer.GetTokens();
            var exp = AphidParser.ParseExpression(tokens, code);
            var retExp = new UnaryOperatorExpression(AphidTokenType.retKeyword, exp);
            new AphidCodeVisitor(code).VisitExpression(retExp);
            Interpreter.Interpret(retExp);
            var value = Interpreter.GetReturnValue();

            if (value != null && (value.Value != null || value.Any()))
            {
                Console.WriteLine(new AphidSerializer(Interpreter).Serialize(value));
            }
        }
    }
}
