using Components.Aphid.Interpreter;
using System;

namespace Components.Aphid.UnitTests.Shared
{
    public class InterpreterEventArgs : EventArgs
    {
        public AphidInterpreter Interpreter { get; }

        public InterpreterEventArgs(AphidInterpreter interpreter) => Interpreter = interpreter;
    }
}
