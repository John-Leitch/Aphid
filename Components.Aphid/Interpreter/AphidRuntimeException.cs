using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Interpreter
{
    public class AphidRuntimeException : Exception, IAphidException
    {
        public AphidExceptionType Type
        {
            get { return AphidExceptionType.RuntimeException; }
        }

        public override string Message
        {
            get { return GetMessage(); }
        }

        public AphidInterpreter Interpreter { get; set; }

        public AphidObject ExceptionScope { get; set; }

        public AphidExpression CurrentStatement { get; set; }

        public AphidExpression CurrentExpression { get; set; }

        public virtual string Details { get; set; }

        public AphidRuntimeException(
            AphidInterpreter interpreter,
            AphidObject exceptionScope,
            AphidExpression currentStatement,
            AphidExpression currentExpression,
            Exception innerException)
            : this(interpreter, exceptionScope, String.Empty, innerException)
        {
            CurrentStatement = currentStatement;
            CurrentExpression = currentExpression;
        }

        public AphidRuntimeException(
            AphidInterpreter interpreter,
            AphidObject exceptionScope,
            AphidExpression currentStatement,
            AphidExpression currentExpression,
            string details,
            params object[] args)
            : this(interpreter, exceptionScope, string.Format(details, args))
        {
            CurrentStatement = currentStatement;
            CurrentExpression = currentExpression;
        }

        private AphidRuntimeException(
            AphidInterpreter interpreter,
            AphidObject exceptionScope,
            string details,
            Exception innerException = null)
            : base(string.Empty, innerException)
        {
            Interpreter = interpreter;
            ExceptionScope = exceptionScope;
            Details = details;
        }

        private string GetMessage()
        {
            var sb = new StringBuilder("Runtime exception occurred");
            bool expValid = IsValid(CurrentExpression),
                stmtValid = IsValid(CurrentStatement),
                hasExpType = HasType(CurrentExpression),
                hasStmtType = HasType(CurrentStatement);

            if (expValid && stmtValid)
            {
                AppendType(sb, CurrentExpression);
                AppendCode(sb, CurrentExpression);

                if (CurrentExpression.Type != CurrentStatement.Type ||
                    CurrentExpression.Index != CurrentStatement.Index ||
                    CurrentExpression.Length != CurrentStatement.Length)
                {
                    AppendFrom(sb, CurrentStatement);
                    AppendCode(sb, CurrentStatement);                    
                }
            }
            else if (expValid)
            {
                AppendType(sb, CurrentExpression);
                AppendCode(sb, CurrentExpression);

                if (hasStmtType)
                {
                    AppendFrom(sb, CurrentStatement);
                }
            }
            else if (stmtValid)
            {
                if (hasExpType)
                {
                    AppendType(sb, CurrentExpression);
                    AppendFrom(sb, CurrentStatement);
                }
                else
                {
                    AppendType(sb, CurrentStatement, isStmt: true);
                }

                AppendCode(sb, CurrentStatement);
            }
            else if (hasExpType && hasStmtType)
            {
                AppendType(sb, CurrentExpression);
                AppendFrom(sb, CurrentStatement);
            }
            else if (hasExpType)
            {
                AppendType(sb, CurrentExpression);
            }
            else if (hasStmtType)
            {
                AppendType(sb, CurrentExpression);
            }

            TryAppendFile(sb, CurrentExpression, CurrentStatement);
            sb.Append(".");

            if (!string.IsNullOrEmpty(Details))
            {
                sb.AppendFormat(" {0}", Details);
            }

            return sb.ToString();
        }

        private string GetType(AphidExpression expression)
        {
            return expression != null ? expression.Type.ToString() : null;
        }

        private bool IsValid(AphidExpression expression)
        {
            return expression != null &&
                expression.Context != null &&
                expression.Index != -1 &&
                expression.Length > 0;
        }

        private bool HasType(AphidExpression expression)
        {
            return expression != null;
        }

        private void AppendType(
            StringBuilder sb,
            AphidExpression expression,
            bool isStmt = false)
        {
            sb.AppendFormat(
                " while evaluating {0}",
                FormatType(expression, isStmt));
        }

        private string FormatType(AphidExpression expression, bool isStmt = false)
        {
            var t = expression.Type.ToString();
            var uppers = t.Where(char.IsUpper).ToArray();

            var words = t.Split(uppers, StringSplitOptions.RemoveEmptyEntries)
                .Select((x, i) => uppers[i].ToString().ToLower() + x)
                .Select(x => x != "expression" || !isStmt ? x : "statement")
                .Join(" ");

            return words;
        }

        private void AppendCode(StringBuilder sb, AphidExpression expression)
        {
            sb.AppendFormat(" '{0}'", expression.ToString().Trim());
        }

        private void AppendFrom(StringBuilder sb, AphidExpression expression)
        {
            sb.AppendFormat(" from {0}", FormatType(expression, isStmt: true));
        }

        private void TryAppendFile(
            StringBuilder sb,
            AphidExpression expression,
            AphidExpression statement)
        {
            var file =
                expression != null && expression.Filename != null ?
                    expression.Filename :
                statement != null && statement.Filename != null ?
                    statement.Filename :
                null;

            if (file != null)
            {
                sb.AppendFormat(" in script {0}", file);
            }
        }
    }
}
