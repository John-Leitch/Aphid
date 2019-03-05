using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            var flat = ExceptionHelper
                .Flatten(ex)
                .Select((x, i) => string.Format(
                    AphidConfig.Current.ExceptionHandlingClrStack ?
                        "[{0:x4}] Unhandled exception: {1}\r\n\r\n{2}\r\n" :
                        "[{0:x4}] Unhandled exception: {1}\r\n",
                    i,
                    x.Message,
                    x.StackTrace))
                .JoinLines();
            
            return flat;
            // Todo: implement properly
            // +
            //(ex.InnerException != null ? 
            //    "Inner:\r\n\r\n" + GetErrorMessage(ex.InnerException) :
            //    "");
        }
    }
}
