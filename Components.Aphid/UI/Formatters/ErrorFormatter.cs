using System;
using System.Linq;
using System.Text;
using Components.Aphid.Interpreter;
using Components.Aphid.Parser;

namespace Components.Aphid.UI.Formatters
{
    public static class ErrorFormatter
    {
        public static string Format(AphidParserException exception, string code) =>
            $"Unhandled parser exception: {ParserErrorMessage.Create(code, exception, true)}";

        public static string Format(AphidRuntimeException exception) =>
            $"{exception.Message}\r\n";

        public static string Format(AphidLoadScriptException exception, string code)
        {
            var sb = new StringBuilder("Load script exception\r\n");
            var t = exception.LoadScriptExceptionType;

            sb.AppendLine(
                t == AphidExceptionType.ParserException ?
                    Format(exception.ParserException, code) :
                t == AphidExceptionType.AphidRuntimeException ?
                    Format(exception.AphidRuntimeException) :
                Format(exception.InnerException));

            return sb.ToString();
        }

        public static string Format(Exception exception)
        {
            var ex = ExceptionHelper.Unwrap(exception);
            var flattened = ExceptionHelper.Flatten(ex);

            return flattened.Count == 1 ?
                FormatException(ex, -1) :
                flattened
                    .Select((x, i) => FormatException(x, i))
                    .JoinLines();
        }

        private static string FormatException(Exception x, int i)
        {
            var prefix = i >= 0 ? "[{0:x4}] " : "";
            var suffix = AphidConfig.Current.ExceptionHandlingClrStack ? "\r\n{2}\r\n" : "";
            

            return string.Format(
                prefix + "Unhandled Exception: {1}\r\nSource: {3}\r\nTarget Site: {4}" + suffix,
                i,
                x.Message,
                x.StackTrace,
                x.Source,
                x.TargetSite)
                .Indent("    ")
                .TrimStart(' ', '\r', '\n');
        }
    }
}
