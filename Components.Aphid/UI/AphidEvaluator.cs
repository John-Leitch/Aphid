using System;
using System.Linq;
using System.Threading;
using Components.Aphid.Debugging;
using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
using Components.Aphid.UI.Formatters;
using static Components.Aphid.UI.AphidCli;
using static System.Environment;
using static Components.Aphid.UI.AphidExitCode;

namespace Components.Aphid.UI
{
    public class AphidEvaluator
    {
        public static void Eval(string code) =>
            Eval(code, isTextDocument: false);

        public static void Eval(string code, bool isTextDocument) =>
            Eval(new AphidInterpreter(), code, isTextDocument);

        public static void Eval(AphidInterpreter interpreter, string code) =>
            Eval(interpreter, code, isTextDocument: false);

        public static void Eval(AphidInterpreter interpreter, string code, bool isTextDocument)
        {
            if (AphidErrorHandling.HandleErrors)
            {
                var backup = false;

                try
                {
                    backup = interpreter.SetIsInTryCatchFinally(true);
                    interpreter.Interpret(code, isTextDocument);
                }
                catch (ThreadAbortException exception)
                {
                    if (!IsAborting)
                    {
                        Thread.ResetAbort();
                        DumpException(exception, interpreter);
                        Exit((int)GeneralError);
                    }
                }
                catch (AphidParserException exception)
                {
                    DumpException(exception, code);
                    Exit((int)ParserError);
                }
                catch (AphidLoadScriptException exception)
                {
                    DumpException(exception, interpreter);
                    Exit((int)LoadScriptError);
                }
                catch (AphidRuntimeException exception)
                {
                    DumpException(exception, interpreter);
                    Exit((int)RuntimeError);
                }
                catch (Exception exception)
                {
                    DumpException(exception, interpreter);
                    Exit((int)GeneralError);
                }
                finally
                {
                    interpreter.SetIsInTryCatchFinally(backup);
                }
            }
            else
            {
                interpreter.Interpret(code, isTextDocument);
            }
        }

        public static AphidObject EvalExpression(string code) =>
            EvalExpression(new AphidInterpreter(), code);

        public static AphidObject EvalExpression(AphidInterpreter interpreter, string code)
        {
            AphidObject result = null;

            void action()
            {
                if (code.Trim()?.Length == 0)
                {
                    return;
                }

                var lexer = new AphidLexer(code);
                var tokens = lexer.GetTokens();
                var exp = AphidParser.ParseExpression(tokens, code);
                var retExp = new UnaryOperatorExpression(AphidTokenType.retKeyword, exp);
                //new AphidCodeVisitor(code).VisitExpression(retExp);
                interpreter.Interpret(retExp);
                result = interpreter.GetReturnValue();

                if (result != null && (result.Value != null || result.Any()))
                {
                    WriteLineHighlighted(
                        SerializingFormatter.Format(
                            interpreter,
                            result,
                            ignoreNull: false,
                            ignoreClrObj: false));
                }
            }

            if (AphidErrorHandling.HandleErrors)
            {
                TryAction(interpreter, code, action);
            }
            else
            {
                action();
            }

            return result;
        }
    }
}
