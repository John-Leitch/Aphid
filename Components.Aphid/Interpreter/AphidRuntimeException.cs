using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Interpreter
{
    public class AphidRuntimeException : Exception
    {
        public AphidRuntimeException(string message, params object[] args)
            : base(string.Format(message, args))
        {
        }
    }
}
