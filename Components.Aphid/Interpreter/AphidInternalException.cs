using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Components.Aphid.Interpreter
{
    [Serializable]
    public class AphidInternalException : AphidRuntimeException
    {
        public AphidInternalException(
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

        protected AphidInternalException(SerializationInfo info, StreamingContext context) :
            base(info, context)
        {
        }

        public AphidInternalException(
            AphidInterpreter interpreter,
            AphidObject exceptionScope,
            AphidExpression currentStatement,
            AphidExpression currentExpression,
            Exception innerException) :
            base(interpreter, exceptionScope, currentStatement, currentExpression, innerException)
        {
        }
    }
}
