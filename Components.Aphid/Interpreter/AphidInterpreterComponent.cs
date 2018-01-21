using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Interpreter
{
    public abstract class AphidInterpreterComponent
    {
        public AphidInterpreter Interpreter { get; private set; }

        public AphidInterpreterComponent(AphidInterpreter interpreter)
        {
            Interpreter = interpreter;
        }
    }
}
