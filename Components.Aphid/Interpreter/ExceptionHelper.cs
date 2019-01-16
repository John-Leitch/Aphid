using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Interpreter
{
    public static class ExceptionHelper
    {
        public static Exception Unwrap(Exception exception)
        {
            while (true)
            {
                if (exception is TargetInvocationException ex)
                {
                    exception = ex.InnerException;
                }
                else
                {
                    return exception;
                }
            }
        }

        public static string StackTrace(AphidFrame[] frames)
        {
            var sb = new StringBuilder();

            foreach (var f in frames)
            {
                sb.AppendLine(f.ToString());
            }

            return sb.ToString();
        }
    }
}
