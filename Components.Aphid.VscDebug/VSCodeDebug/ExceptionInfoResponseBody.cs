using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSCodeDebug
{
    public class ExceptionInfoResponseBody : ResponseBody
    {
        public string exceptionId { get; private set; }
        public string description { get; private set; }
        public string breakMode { get; private set; }
        public ExceptionDetails details { get; private set; }

        public ExceptionInfoResponseBody(
            string exceptionId,
            string description,
            string breakMode = "unhandled",
            ExceptionDetails details = null)
        {
            this.exceptionId = exceptionId;
            this.description = description;
            this.breakMode = breakMode;
            this.details = details;
        }

        public ExceptionInfoResponseBody()
        {
        }
    }
}
