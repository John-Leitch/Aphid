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
                var ex = exception as TargetInvocationException;
                
                if (ex != null)
                {
                    exception = ex.InnerException;
                }
                else
                {
                    return exception;
                }
            }
        }
    }
}
