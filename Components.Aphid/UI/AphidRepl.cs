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
        private AphidInterpreter _interpreter;

        public void Run()
        {
            _interpreter = new AphidInterpreter();

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
                        AphidCli.DumpStackTrace(_interpreter);
                    }
                }
                else
                {
                    RunCode(code);
                }

                _interpreter.ResetState();
            }
        }

        private void RunCode(string code)
        {
            var lexer = new AphidLexer(code);
            var tokens = lexer.GetTokens();
            var exp = AphidParser.ParseExpression(tokens, code);
            var retExp = new UnaryOperatorExpression(AphidTokenType.retKeyword, exp);
            new AphidCodeVisitor(code).VisitExpression(retExp);
            _interpreter.Interpret(retExp);
            var value = _interpreter.GetReturnValue();

            if (value != null && (value.Value != null || value.Any()))
            {
                Console.WriteLine(new AphidSerializer().Serialize(value));
            }
        }
    }
}
