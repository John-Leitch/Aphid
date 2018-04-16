using Components.Aphid.Interpreter;
using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.TypeSystem
{
    public class AphidOperationException : AphidRuntimeException
    {
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
    }
}
