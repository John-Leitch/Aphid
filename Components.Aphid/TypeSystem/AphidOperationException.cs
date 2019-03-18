using Components.Aphid.Interpreter;
using Components.Aphid.Parser;
using System;
using System.Runtime.Serialization;

namespace Components.Aphid.TypeSystem
{
    [Serializable]
    public class AphidOperationException : AphidRuntimeException
    {
        protected AphidOperationException(SerializationInfo info, StreamingContext context) :
            base(info, context)
        {
        }

        public AphidOperationException(
            AphidInterpreter interpreter,
            AphidObject exceptionScope,
            AphidExpression currentStatement,
            AphidExpression currentExpression,
            string op)
            : base(
                interpreter,
                exceptionScope,
                currentStatement,
                currentExpression,
                "Cannot perform {0} operation on null.",
                op)
        {
        }

        public AphidOperationException(
            AphidInterpreter interpreter,
            AphidObject exceptionScope,
            AphidExpression currentStatement,
            AphidExpression currentExpression,
            Exception innerException) :
            base(interpreter, exceptionScope, currentStatement, currentExpression, innerException)
        {
        }

        public AphidOperationException(
            AphidInterpreter interpreter,
            AphidObject exceptionScope,
            AphidExpression currentStatement,
            AphidExpression currentExpression,
            string details, params object[] args) :
            base(interpreter, exceptionScope, currentStatement, currentExpression, details, args)
        {
        }
    }
}
