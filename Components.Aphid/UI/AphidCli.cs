using Components.External.ConsolePlus;
using Components.Aphid.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Components.Aphid.Parser;
using System.IO;
using Components.Aphid.Lexer;

namespace Components.Aphid.UI
{
    public static class AphidCli
    {
        public static bool ShowClrStack { get; set; }

        public static int ExcerptSurroundingLines { get; set; }

        static AphidCli()
        {
            ExcerptSurroundingLines = 4;
        }

        public static bool TryAction(AphidInterpreter interpreter, string code, Action action)
        {
            try
            {
                action();

                return true;
            }
            catch (AphidParserException exception)
            {
                AphidCli.DumpException(exception, code);
            }
            catch (AphidLoadScriptException exception)
            {
                AphidCli.DumpException(exception, interpreter, code);
            }
            catch (AphidRuntimeException exception)
            {
                AphidCli.DumpException(exception, interpreter);
            }
            catch (Exception exception)
            {
                AphidCli.DumpException(exception, interpreter);
            }

            return false;
        }

        public static void ExecuteCode(string code)
        {
            ExecuteCode(code, isTextDocument: false);
        }

        public static void ExecuteCode(AphidInterpreter interpreter, string code)
        {
            ExecuteCode(interpreter, code, isTextDocument: false);
        }

        public static void ExecuteCode(string code, bool isTextDocument)
        {
            ExecuteCode(new AphidInterpreter(), code, isTextDocument);
        }

        public static void ExecuteCode(
            AphidInterpreter interpreter,
            string code,
            bool isTextDocument)
        {
            try
            {
                interpreter.Interpret(code, isTextDocument);
            }
            catch (AphidParserException exception)
            {
                AphidCli.DumpException(exception, code);
                Environment.Exit((int)AphidExitCode.ParserError);
            }
            catch (AphidLoadScriptException exception)
            {
                AphidCli.DumpException(exception, interpreter, code);
                Environment.Exit((int)AphidExitCode.LoadScriptError);
            }
            catch (AphidRuntimeException exception)
            {
                AphidCli.DumpException(exception, interpreter);
                Environment.Exit((int)AphidExitCode.RuntimeError);
            }
            catch (Exception exception)
            {
                AphidCli.DumpException(exception, interpreter);
                Environment.Exit((int)AphidExitCode.GeneralError);
            }
        }

        public static void DumpException(AphidParserException exception, string code)
        {
            Cli.WriteErrorMessage(Cli.StyleEscape(GetErrorMessage(exception, code)));
        }

        public static void DumpException(
            AphidRuntimeException exception,
            AphidInterpreter interpreter)
        {
            Cli.WriteErrorMessage(Cli.StyleEscape(GetErrorMessage(exception)));
            DumpStackTrace(interpreter);
        }

        public static void DumpException(
            AphidLoadScriptException exception,
            AphidInterpreter interpreter,
            string code)
        {
            Cli.WriteErrorMessage(
                Cli.StyleEscape(
                    GetErrorMessage(
                        exception,
                        File.ReadAllText(exception.ScriptFile))));

            DumpStackTrace(interpreter);
        }

        public static void DumpException(
            Exception exception,
            AphidInterpreter interpreter)
        {
            Cli.WriteErrorMessage(Cli.StyleEscape(GetErrorMessage(exception)));
            DumpStackTrace(interpreter);
        }

        public static void DumpStackTrace(AphidInterpreter interpreter)
        {
            var trace = interpreter.GetStackTrace();
            var i = 0;

            if (!Console.IsOutputRedirected)
            {
                Cli.WriteSubheader("Stack Trace", "~|Blue~~White~");
            }
            else
            {
                Cli.WriteErrorMessage("Stack Trace");
            }

            foreach (var frame in trace)
            {
                Cli.WriteLine("[~White~{0:x4}~R~] {1}", i++, Cli.StyleEscape(frame.ToString(true)));
            }

            Cli.WriteLine();

            var statement = interpreter.CurrentStatement;

            if (statement == null)
            {
                return;
            }

            Cli.WriteLine(
                "Faulting statement: ~Yellow~{0}~R~",
                Cli.StyleEscape(
                    statement.Code != null ? 
                        statement.Code.Substring(statement.Index, statement.Length) :
                        statement.ToString()));

            DumpExcerpt(statement);
            var file = interpreter.GetScriptFilename();

            if (file != null)
            {
                Cli.WriteLine("Script: ~Yellow~{0}~R~", file);
            }
        }

        private static void DumpExcerpt(AphidExpression statement)
        {
            if (statement == null ||
                string.IsNullOrEmpty(statement.Code) ||
                statement.Index < 0)
            {
                return;
            }

            string stylePrefix = "~Cyan~", styleSuffix = "~R~";

            var codeCopy = Cli.StyleEscape(statement.Code);
            codeCopy.Insert(statement.Index + statement.Length, styleSuffix);
            codeCopy.Insert(statement.Index, stylePrefix);

            var excerpt = TokenHelper.GetCodeExcerpt(
                codeCopy,
                statement.Index + stylePrefix.Length,
                ExcerptSurroundingLines);

            if (excerpt != null)
            {
                Cli.WriteLine("\r\nProgram Excerpt:\r\n{0}", excerpt);
            }
        }

        public static string GetErrorMessage(
            AphidParserException exception,
            string code)
        {
            return string.Format(
                "Parser exception\r\n{0}",
                ParserErrorMessage.Create(code, exception));
        }

        public static string GetErrorMessage(AphidRuntimeException exception)
        {
            return string.Format(
                "Unexpected runtime exception\r\n\r\n{0}\r\n",
                exception.Message);
        }

        public static string GetErrorMessage(AphidLoadScriptException exception, string code)
        {
            var sb = new StringBuilder("Load script exception\r\n");
            var t = exception.LoadScriptExceptionType;

            sb.AppendLine(
                t == AphidExceptionType.ParserException ?
                    GetErrorMessage(exception.ParserException, code) :
                t == AphidExceptionType.AphidRuntimeException ? 
                    GetErrorMessage(exception.AphidRuntimeException) :
                GetErrorMessage(exception.InnerException));

            return sb.ToString();
        }

        public static string GetErrorMessage(Exception exception)
        {
            var ex = ExceptionHelper.Unwrap(exception);

            return string.Format(
                ShowClrStack ?
                    "Unexpected exception: {0}\r\n\r\n{1}\r\n" :
                    "Unexpected exception: {0}\r\n",
                ex.Message,
                ex.StackTrace);
        }
    }
}
