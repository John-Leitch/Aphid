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

        public AphidObject ExceptionScope { get; set; }

        public AphidExpression CurrentStatement { get; set; }

        public AphidExpression CurrentExpression { get; set; }

        //public AphidRuntimeException(
        //    AphidExpression currentStatement,
        //    AphidExpression currentExpression)
        //    : this(currentStatement, currentExpression, null)
        //{
        //}

        public AphidRuntimeException(
            AphidObject exceptionScope,
            AphidExpression currentStatement,
            AphidExpression currentExpression,
            Exception innerException)
            : this(
                exceptionScope,
                string.Format(
                    "Runtime exception when evaluating expression {0}.",
                    currentExpression),
                innerException)
        {
            CurrentStatement = currentStatement;
            CurrentExpression = currentExpression;
        }

        public AphidRuntimeException(
            AphidObject exceptionScope,
            AphidExpression currentStatement,
            AphidExpression currentExpression,
            string message,
            params object[] args)
            : this(exceptionScope, string.Format(message, args))
        {
            CurrentStatement = currentStatement;
            CurrentExpression = currentExpression;
        }

        private AphidRuntimeException(
            AphidObject exceptionScope,
            string message,
            Exception innerException = null)
            : base(message, innerException)
        {
            ExceptionScope = exceptionScope;
        }
    }
}
