using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Interpreter
{
    public class AphidLoadScriptException : AphidRuntimeException
    {
        private string _message;

        public override string Message { get { return _message ?? GetMessage(); } }

        public string ScriptFile { get; set; }

        public AphidParserException ParserException { get; set; }

        public AphidRuntimeException AphidRuntimeException { get; set; }

        public Exception RuntimeException { get; set; }

        public AphidExceptionType LoadScriptExceptionType
        {
            get
            {
                return
                    ParserException != null ? AphidExceptionType.ParserException :
                    AphidRuntimeException != null ? AphidExceptionType.AphidRuntimeException :
                    RuntimeException != null ? AphidExceptionType.RuntimeException :
                    AphidExceptionType.Unknown;
            }
        }

        public AphidLoadScriptException(
            AphidExpression currentStatement,
            AphidExpression currentExpression,
            string scriptFile,
            AphidParserException parserException)
            : this(currentStatement, currentExpression, parserException, scriptFile)
        {
            ParserException = parserException;
        }

        public AphidLoadScriptException(
            AphidExpression currentStatement,
            AphidExpression currentExpression,
            string scriptFile,
            AphidRuntimeException runtimeException)
            : this(currentStatement, currentExpression, runtimeException, scriptFile)
        {
            AphidRuntimeException = runtimeException;
        }

        public AphidLoadScriptException(
            AphidExpression currentStatement,
            AphidExpression currentExpression,
            string scriptFile,
            Exception runtimeException)
            : this(currentStatement, currentExpression, runtimeException, scriptFile)
        {
            RuntimeException = runtimeException;
        }

        private AphidLoadScriptException(
            AphidExpression currentStatement,
            AphidExpression currentExpression,
            Exception innerException,
            string scriptFile)
            : base(currentStatement, currentExpression, innerException)
        {
            ScriptFile = scriptFile;
        }

        public AphidLoadScriptException(
            AphidExpression currentStatement,
            AphidExpression currentExpression,
            string message,
            params object[] args)
            : base(currentStatement, currentExpression, message, args)
        {
        }

        private string GetMessage()
        {
            return
                LoadScriptExceptionType == AphidExceptionType.ParserException ?
                    string.Format("Error parsing {0}:\r\n{1}", ScriptFile, ParserException) :
                CurrentExpression == CurrentStatement ?
                    string.Format(
                        "Error evaluating {0} in {1}:\r\n{2}",
                        CurrentStatement,
                        ScriptFile,
                        InnerException) :
                    string.Format(
                        "Error evaluating expression {0} from statement {1} in {2}:\r\n{2}",
                        CurrentExpression,
                        CurrentStatement,
                        ScriptFile,
                        InnerException);
        }
    }
}
