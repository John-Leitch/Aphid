#if !SILVERLIGHT
using Components.External.ConsolePlus;
using Components.Aphid.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.UI
{
    public static class AphidCli
    {
        public static void DumpStackTrace(AphidInterpreter interpreter)
        {
            var trace = interpreter.GetStackTrace();
            var i = 0;
            Cli.WriteSubheader("Stack Trace", "~|Blue~~White~");

            foreach (var frame in trace)
            {
                Cli.WriteLine("[~White~{0:x4}~R~] {1}", i++, frame.ToString(true));
            }

            Cli.WriteLine();
        }
    }
}
#endif