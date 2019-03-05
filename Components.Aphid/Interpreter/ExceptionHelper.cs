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
        public static List<Exception> Flatten(Exception exception) => Flatten(exception, new List<Exception>());

        private static List<Exception> Flatten(Exception exception, List<Exception> traversed)
        {
            if (exception == null || traversed.Contains(exception))
            {
                return traversed;
            }

            traversed.Add(exception);

            switch (exception)
            {
                case ReflectionTypeLoadException ex:
                    Flatten(ex.LoaderExceptions, traversed);
                    break;

                case AggregateException ex:
                    Flatten(ex.InnerExceptions, traversed);
                    break;
            }

            Flatten(exception.InnerException, traversed);

            return traversed;
        }

        private static List<Exception> Flatten(IEnumerable<Exception> exceptions, List<Exception> traversed) =>
            traversed.DoIf(exceptions != null, _ => exceptions.For(x => Flatten(x, _)));

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
