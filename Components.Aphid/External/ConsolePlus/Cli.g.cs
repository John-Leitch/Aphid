using System.Diagnostics;

namespace Components.External.ConsolePlus
{
    public static partial class Cli
    {

        [DebuggerStepThrough]
        public static void WriteLine(string format, object arg0)
        {
            WriteCore(format, true, arg0);
        }

        [DebuggerStepThrough]
        public static void WriteLine(string format, object arg0, object arg1)
        {
            WriteCore(format, true, arg0, arg1);
        }

        [DebuggerStepThrough]
        public static void WriteLine(string format, object arg0, object arg1, object arg2)
        {
            WriteCore(format, true, arg0, arg1, arg2);
        }

        [DebuggerStepThrough]
        public static void WriteLine(string format, object arg0, object arg1, object arg2, object arg3)
        {
            WriteCore(format, true, arg0, arg1, arg2, arg3);
        }

        [DebuggerStepThrough]
        public static void Write(string format, object arg0)
        {
            WriteCore(format, false, arg0);
        }

        [DebuggerStepThrough]
        public static void Write(string format, object arg0, object arg1)
        {
            WriteCore(format, false, arg0, arg1);
        }

        [DebuggerStepThrough]
        public static void Write(string format, object arg0, object arg1, object arg2)
        {
            WriteCore(format, false, arg0, arg1, arg2);
        }

        [DebuggerStepThrough]
        public static void Write(string format, object arg0, object arg1, object arg2, object arg3)
        {
            WriteCore(format, false, arg0, arg1, arg2, arg3);
        }

    }
}

