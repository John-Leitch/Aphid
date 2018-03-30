using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Library;
using Components.Aphid.Parser;
using Components.Aphid.Serialization;
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

        public AphidRepl()
        {
        }

        public AphidRepl(AphidInterpreter interpreter)
            : this()
        {
            Interpreter = interpreter;
        }

        public void Run()
        {
            try
            {
                VT100.Enable();
            }
            catch { }

            if (Interpreter == null)
            {
                Interpreter = new AphidInterpreter();
            }

            using (var console = new AphidAutocompleteConsole(Interpreter))
            {
                while (true)
                {
                    string code;

                    if (!Debugger.IsAttached)
                    {
                        try
                        {
                            code = console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Cli.WriteCriticalErrorMessage(
                                "Internal error encountered in autocomplete console:\r\n{0}",
                                e.Message);

                            continue;
                        }
                    }
                    else
                    {
                        code = console.ReadLine();
                    }

                    if (!Debugger.IsAttached)
                    {
                        AphidCli.TryAction(Interpreter, code, () => RunCode(code));
                    }
                    else
                    {
                        var backup = Interpreter.SetIsInTryCatchFinally(true);
                        RunCode(code);
                        Interpreter.SetIsInTryCatchFinally(backup);
                    }

                    Interpreter.ResetState();
                }
            }
        }

        private void RunCode(string code)
        {
            if (code.Trim() == "")
            {
                return;
            }

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
