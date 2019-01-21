using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Interpreter
{
    public abstract class AphidRuntimeComponent
    {
        public AphidInterpreter Interpreter { get; }

        protected AphidRuntimeComponent(AphidInterpreter interpreter) => Interpreter = interpreter;
    }
}
