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

            var statement = interpreter.CurrentStatement;

            if (statement == null)
            {
                return;
            }

            Cli.WriteLine(
                "Faulting statement: ~Yellow~{0}~R~",
                statement.Code != null ? 
                    statement.Code.Substring(statement.Index, statement.Length) :
                    statement.ToString());

            var file = interpreter.GetScriptFilename();

            if (file != null)
            {
                Cli.WriteLine("Script: ~Yellow~{0}~R~", file);
            }
        }
    }
}
