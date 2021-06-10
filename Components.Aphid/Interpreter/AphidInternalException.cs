﻿using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;
using System;
using System.Runtime.Serialization;

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

#if !LOW_SECURITY
        protected AphidInternalException(SerializationInfo info, StreamingContext context) :
            base(info, context)
        {
        }
#endif

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
