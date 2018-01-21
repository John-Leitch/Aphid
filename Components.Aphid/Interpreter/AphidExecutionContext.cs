using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Interpreter
{
    public class AphidExecutionContext
    {
        public bool IsModified { get; set; }

        public bool IsHandled { get; set; }
    }
}
