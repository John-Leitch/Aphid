using Components.Aphid.Parser;
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

        public AphidExpression CurrentStatement { get; set; }

        public AphidExpression CurrentExpression { get; set; }

        //public AphidRuntimeException(
        //    AphidExpression currentStatement,
        //    AphidExpression currentExpression)
        //    : this(currentStatement, currentExpression, null)
        //{
        //}

        public AphidRuntimeException(
            AphidExpression currentStatement,
            AphidExpression currentExpression,
            Exception innerException)
            : base(
                string.Format(
                    "Runtime exception when evaluating expression {0}.",
                    currentExpression),
                innerException)
        {
            CurrentStatement = currentStatement;
            CurrentExpression = currentExpression;
        }

        public AphidRuntimeException(
            AphidExpression currentStatement,
            AphidExpression currentExpression,
            string message,
            params object[] args)
            : base(string.Format(message, args))
        {
            CurrentStatement = currentStatement;
            CurrentExpression = currentExpression;
        }
    }
}
