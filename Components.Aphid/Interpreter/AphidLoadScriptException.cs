using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
using System;
using System.Text;

namespace Components.Aphid.Interpreter
{
    public class AphidLoadScriptException : AphidRuntimeException
    {
        public string ScriptFile { get; set; }

        public AphidParserException ParserException { get; set; }

        public AphidRuntimeException AphidRuntimeException { get; set; }

        public Exception RuntimeException { get; set; }

        public override string Details => GetMessage();

        public AphidExceptionType LoadScriptExceptionType =>
            ParserException != null ? AphidExceptionType.ParserException :
                    AphidRuntimeException != null ? AphidExceptionType.AphidRuntimeException :
                    RuntimeException != null ? AphidExceptionType.RuntimeException :
                    AphidExceptionType.Unknown;

        public AphidLoadScriptException(
            AphidInterpreter interpreter,
            AphidObject exceptionScope,
            AphidExpression currentStatement,
            AphidExpression currentExpression,
            string scriptFile,
            AphidParserException parserException)
            : this(
                interpreter,
                exceptionScope,
                currentStatement,
                currentExpression,
                parserException,
                scriptFile) => ParserException = parserException;

        public AphidLoadScriptException(
            AphidInterpreter interpreter,
            AphidObject exceptionScope,
            AphidExpression currentStatement,
            AphidExpression currentExpression,
            string scriptFile,
            AphidRuntimeException runtimeException)
            : this(
                interpreter,
                exceptionScope,
                currentStatement,
                currentExpression,
                runtimeException,
                scriptFile) => AphidRuntimeException = runtimeException;

        public AphidLoadScriptException(
            AphidInterpreter interpreter,
            AphidObject exceptionScope,
            AphidExpression currentStatement,
            AphidExpression currentExpression,
            string scriptFile,
            Exception runtimeException)
            : this(
                interpreter,
                exceptionScope,
                currentStatement,
                currentExpression,
                runtimeException,
                scriptFile) => RuntimeException = runtimeException;

        private AphidLoadScriptException(
            AphidInterpreter interpreter,
            AphidObject exceptionScope,
            AphidExpression currentStatement,
            AphidExpression currentExpression,
            Exception innerException,
            string scriptFile)
            : base(
                interpreter,
                exceptionScope,
                currentStatement,
                currentExpression,
                innerException) => ScriptFile = scriptFile;

        public AphidLoadScriptException(
            AphidInterpreter interpreter,
            AphidObject exceptionScope,
            AphidExpression currentStatement,
            AphidExpression currentExpression,
            string message,
            params object[] args)
            : base(
                interpreter,
                exceptionScope,
                currentStatement,
                currentExpression,
                message,
                args)
        {
        }

        public AphidLoadScriptException(
            AphidInterpreter interpreter,
            AphidObject exceptionScope,
            AphidExpression currentStatement,
            AphidExpression currentExpression, Exception innerException) :
            base(interpreter, exceptionScope, currentStatement, currentExpression, innerException)
        {
        }

        private string GetMessage()
        {
            var sb = new StringBuilder();

            sb.AppendFormat(
                "Exception encountered while {0} included script {1}",
                LoadScriptExceptionType == AphidExceptionType.ParserException ? "parsing" :
                LoadScriptExceptionType == AphidExceptionType.AphidRuntimeException ? "interpreting" :
                "evaluating",
                ScriptFile);

            TryAppendClause(sb, InnerException);
            sb.Append(".");

            return sb.ToString();
        }

        private void TryAppendClause(StringBuilder sb, object value)
        {
            string tmp;

            if ((tmp = Format(ParserException)) != null)
            {
                sb.AppendFormat(", {0}", tmp);
            }
        }

        private static string Format(object value)
        {
            string s;

            return value != null && !string.IsNullOrEmpty(s = value.ToString().Trim()) ?
                s[0].ToString().ToUpper() + s.Substring(1) :
                null;
        }
    }
}
