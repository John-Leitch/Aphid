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
using System.Diagnostics;
using Components.Aphid.TypeSystem;
using Components.Aphid.Serialization;
using Components.Aphid.Debugging;

namespace Components.Aphid.UI
{
    public static class AphidCli
    {
        private const string _messageFormat = "[~{0}~{1}~R~] {2}";

        private const char _errorChar = '-';

        private static AphidSyntaxHighlighter _highlighter = new AphidSyntaxHighlighter();

        public static bool ShowClrStack { get; set; }

        public static int ExcerptSurroundingLines { get; set; }

        public static Action<string> WriteOut { get; set; }

        public static Action<string> WriteLineOut { get; set; }

        public static Exception LastException { get; set; }

        static AphidCli()
        {
            ExcerptSurroundingLines = 4;
            WriteOut = Cli.Write;
            WriteLineOut = Cli.WriteLine;
        }

        public static bool TryAction(AphidInterpreter interpreter, string code, Action action)
        {
            return TryAction(interpreter, code, action, allowErrorReporting: false);
        }

        public static bool TryAction(
            AphidInterpreter interpreter,
            string code,
            Action action,
            bool allowErrorReporting)
        {
            try
            {
                var backup = interpreter.SetIsInTryCatchFinally(true);
                action();
                interpreter.SetIsInTryCatchFinally(backup);

                return true;
            }
            catch (AphidParserException exception)
            {
                LastException = exception;
                AphidCli.DumpException(exception, code);
            }
            catch (AphidLoadScriptException exception)
            {
                LastException = exception;
                AphidCli.DumpException(exception, interpreter);
            }
            catch (AphidRuntimeException exception)
            {
                LastException = exception;
                AphidCli.DumpException(exception, interpreter);
            }
            catch (Exception exception)
            {
                LastException = exception;
                AphidCli.DumpException(exception, interpreter);
            }

            if (allowErrorReporting)
            {
                AphidErrorReporter.SaveErrorInformation(LastException, interpreter);
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

        public static AphidObject DumpExpression(string code)
        {
            return DumpExpression(new AphidInterpreter(), code);
        }

        public static AphidObject DumpExpression(AphidInterpreter interpreter, string code)
        {
            AphidObject result = null;

            TryAction(
                interpreter,
                code,
                () =>
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
                    interpreter.Interpret(retExp);
                    result = interpreter.GetReturnValue();

                    if (result != null && (result.Value != null || result.Any()))
                    {
                        Console.WriteLine(new AphidSerializer(interpreter).Serialize(result));
                    }
                });

            return result;
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
                AphidCli.DumpException(exception, interpreter);
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
            WriteErrorMessage(Cli.StyleEscape(GetErrorMessage(exception, code)));
        }

        public static void DumpException(
            AphidRuntimeException exception,
            AphidInterpreter interpreter)
        {
            WriteErrorMessage(Cli.StyleEscape(GetErrorMessage(exception)));
            DumpStackTrace(interpreter);
        }

        public static void DumpException(
            AphidLoadScriptException exception,
            AphidInterpreter interpreter)
        {
            WriteErrorMessage(
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
            WriteErrorMessage(Cli.StyleEscape(GetErrorMessage(exception)));

            if (interpreter != null)
            {
                DumpStackTrace(interpreter);
            }
        }

        public static void DumpStackTrace(AphidInterpreter interpreter)
        {
            
            var trace = interpreter.GetStackTrace();
            var i = 0;

            if (!Console.IsOutputRedirected)
            {
                WriteSubheader("Stack Trace", "~|Blue~~White~");
            }
            else
            {
                WriteErrorMessage("Stack Trace");
            }

            foreach (var frame in trace)
            {
                var rawFrameStr = frame.ToString(true);

                var frameStr = Cli.StyleEscape(
                    !"\r\n".Any(rawFrameStr.Contains) ?
                        rawFrameStr :
                        rawFrameStr
                            .NormalizeLines()
                            .SplitLines()
                            .Select(x => x.Trim())
                            .Join(" "));
                
                var truncated = false;
                int maxWidth;

                try
                {
                    maxWidth = Console.WindowWidth - 12;
                }
                catch
                {
                    // Todo: Move constant into config.
                    maxWidth = 80;
                }

                if (frameStr.Length > maxWidth)
                {
                    frameStr = frameStr.Remove(maxWidth);
                    truncated = true;
                }

                frameStr = Highlight(frameStr);

                if (truncated)
                {
                    frameStr += " ~White~...~R~";
                }

                var frameOut = string.Format(
                    "[~White~{0:x4}~R~] {1}",
                    i++,
                    frameStr);

                WriteLineOut(frameOut);
            }

            WriteLineOut("");

            var statement = interpreter.CurrentStatement;

            if (statement == null)
            {
                return;
            }

            WriteLineOut(
                string.Format(
                    "Faulting statement: {0}",
                    Highlight(
                        Cli.StyleEscape(
                            statement.Code != null ?
                                statement.Code.Substring(statement.Index, statement.Length) :
                                statement.ToString()))));

            DumpExcerpt(statement);
            var file = interpreter.GetScriptFilename();

            if (file != null)
            {
                WriteLineOut(string.Format("Script: ~Yellow~{0}~R~", file));
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

            var excerpt = Highlight(
                TokenHelper.GetCodeExcerpt(
                    codeCopy,
                    statement.Index + stylePrefix.Length,
                    ExcerptSurroundingLines));

            if (!string.IsNullOrEmpty(excerpt.Trim()))
            {
                WriteLineOut(string.Format("\r\nProgram Excerpt:\r\n{0}", excerpt));
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

        public static void WriteSubheader(string text, string style = "")
        {
            WriteLineOut(
                string.Format(
                    "{0}  {1}{2}{3}",
                    style,
                    Cli.Escape(text),
                    new string(' ', Cli.BufferWidth - text.Length - 3),
                    "~R~"));
        }

        public static void WriteErrorMessage(string format, params object[] arg)
        {
            WriteMessage(
                ConsoleColor.Red,
                _errorChar,
                format,
                arg);
        }

        public static void WriteMessage(ConsoleColor tokenColor, char token, string format, params object[] arg)
        {
            WriteLineOut(
                string.Format(
                    string.Format(_messageFormat, tokenColor, token, format.Replace("{", "{{").Replace("}", "}}")),
                    arg));
        }

        public static string Highlight(string code)
        {
            return code.Trim().Any() ? VT100.GetString(_highlighter.Highlight(code)) : code;
        }
    }
}
