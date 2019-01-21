using Components.Aphid.Parser;
using Components.Aphid.Serialization;
using Components.Aphid.TypeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Components.Aphid.Interpreter
{
    [Serializable]
    public class AphidRuntimeException : Exception, IAphidException
    {
        public AphidExceptionType Type => AphidExceptionType.RuntimeException;

        public override string Message => GetMessage();

        [field:NonSerialized]
        public AphidInterpreter Interpreter { get; set; }

        public AphidObject ExceptionScope { get; set; }

        public AphidExpression CurrentStatement { get; set; }

        public AphidExpression CurrentExpression { get; set; }

        public virtual string Details { get; set; }

        private AphidSerializer _serializer = new AphidSerializer(new AphidInterpreter())
        {
            IgnoreLazyLists = false,
            IgnoreFunctions = false,
            IgnoreSpecialVariables = false,
            QuoteToStringResults = true,
            ToStringClrTypes = true,
        };

        protected AphidRuntimeException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
            ExceptionScope = _serializer.Deserialize(info.GetString(nameof(ExceptionScope)));
            //ExceptionScope = (AphidObject)info.GetValue(nameof(ExceptionScope), typeof(AphidObject));
            CurrentStatement = (AphidExpression)info.GetValue(nameof(CurrentStatement), typeof(AphidExpression));
            CurrentExpression = (AphidExpression)info.GetValue(nameof(CurrentExpression), typeof(AphidExpression));
            Details = info.GetString(nameof(Details));
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue(nameof(ExceptionScope), _serializer.Serialize(ExceptionScope));
            //info.AddValue(nameof(ExceptionScope), ExceptionScope);
            info.AddValue(nameof(CurrentStatement), CurrentStatement);
            info.AddValue(nameof(CurrentExpression), CurrentExpression);
            info.AddValue(nameof(Details), Details);
        }

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
            : this(
                interpreter,
                exceptionScope,
                args?.Length > 0 ?
                    string.Format(details, args) :
                    details)
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

        private static string GetType(AphidExpression expression) => expression?.Type.ToString();

        private static bool IsValid(AphidExpression expression) =>
            expression?.Context != null &&
                expression.Index != -1 &&
                expression.Length > 0;

        private static bool HasType(AphidExpression expression) => expression != null;

        private static void AppendType(
            StringBuilder sb,
            AphidExpression expression,
            bool isStmt = false) =>
            sb.AppendFormat(
                " while evaluating {0}",
                FormatType(expression, isStmt));

        private static string FormatType(AphidExpression expression, bool isStmt = false)
        {
            var t = expression.Type.ToString();
            var uppers = t.Where(char.IsUpper).ToArray();

            var words = t.Split(uppers, StringSplitOptions.RemoveEmptyEntries)
                .Select((x, i) => uppers[i].ToString().ToLower() + x)
                .Select(x => x != "expression" || !isStmt ? x : "statement")
                .Join(" ");

            return words;
        }

        private static void AppendCode(StringBuilder sb, AphidExpression expression) => sb.AppendFormat(" '{0}'", expression.ToString().Trim());

        private static void AppendFrom(StringBuilder sb, AphidExpression expression) => sb.AppendFormat(" from {0}", FormatType(expression, isStmt: true));

        private static void TryAppendFile(StringBuilder sb, AphidExpression expression, AphidExpression statement)
        {
            var file =
                expression?.Filename != null ?
                    expression.Filename :
                statement?.Filename != null ?
                    statement.Filename :
                null;

            if (file != null)
            {
                sb.AppendFormat(" in script {0}", file);
            }
        }
    }
}
