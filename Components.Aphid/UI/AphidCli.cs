using Components.External.ConsolePlus;
using Components.Aphid.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Components.Aphid.Parser;

namespace Components.Aphid.UI
{
    public static class AphidCli
    {
        public static void DumpException(AphidParserException exception, string code)
        {
            Console.WriteLine(GetErrorMessage(exception, code));
        }

        public static void DumpException(
            AphidRuntimeException exception,
            AphidInterpreter interpreter)
        {
            Console.WriteLine(GetErrorMessage(exception));
            DumpStackTrace(interpreter);
        }

        public static void DumpException(
            AphidLoadScriptException exception,
            AphidInterpreter interpreter,
            string code)
        {
            Console.WriteLine(GetErrorMessage(exception, code));
            DumpStackTrace(interpreter);
        }

        public static void DumpException(
            Exception exception,
            AphidInterpreter interpreter)
        {
            Console.WriteLine(GetErrorMessage(exception));
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

            var file = interpreter.GetScriptFilename();

            if (file != null)
            {
                Cli.WriteLine("Script: ~Yellow~{0}~R~", file);
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
            return string.Format(
                "Unexpected exception\r\n\r\n{0}\r\n",
                ExceptionHelper.Unwrap(exception).Message);
        }
    }
}
