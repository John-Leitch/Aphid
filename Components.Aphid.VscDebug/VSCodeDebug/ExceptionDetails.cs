using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSCodeDebug
{
    public class ExceptionDetails
    {
        public string message { get; set; }
        public string typeName { get; set; }
        public string fullTypeName { get; set; }
        public string evaluateName { get; set; }
        public string stackTrace { get; set; }
        public ExceptionDetails[] innerException { get; set; }
    }
}
