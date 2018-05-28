using Components;
using Components.Aphid.Parser;
using Components.External;
using Components.External.ConsolePlus;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VSCodeDebug
{
    public class AphidBreakpointController
    {
        private Memoizer<string, string> _codeMemoizer = new Memoizer<string, string>();

        private Memoizer<string, List<AphidExpression>> _astMemoizer = new Memoizer<string, List<AphidExpression>>();

        public List<Breakpoint> UpdateBreakpoints(
            AphidDebugSession session,
            Response response,
            string scriptFile,
            int[] clientLines)
        {
            // Todo: better handle forward slashes
            var fullScriptFile = Path.GetFullPath(scriptFile).Replace('/', '\\');
            Cli.WriteInfoMessage("Parsing {0}", fullScriptFile);
            var code = _codeMemoizer.Call(File.ReadAllText, fullScriptFile);
            var ast = _astMemoizer.Call(x => session.Parse(response, x), fullScriptFile);

            if (ast == null)
            {
                return null;
            }

            var lineResolver = new AphidLineResolver();
            
            var breakpointExpressions = lineResolver.ResolveLineExpressions(
                ast,
                code,
                clientLines);
            
            var bps = new List<Breakpoint>();
            var j = 0;
            var bpExps = new List<AphidExpression>();

            foreach (var exp in breakpointExpressions)
            {
                var line = clientLines[j++];
                Program.Log("Setting breakpoint on line {0}: {1}", line, exp.ToString());
                bps.Add(new Breakpoint(true, line));
            }

            session.Interpreter.SetFileBreakpoints(
                fullScriptFile,
                breakpointExpressions.Select(x => x.Index).ToArray());

            return bps;
        }

        //public void SetExpressionBreakpointFlags(string filename, List<AphidExpression> ast)
        //{
        //    var bpExps = _fileIndexTable[Path.GetFullPath(filename)];

        //    if (bpExps == null)
        //    {
        //        foreach (var n in ast)
        //        {
        //            n.HasBreakpoint = false;
        //        }

        //        return;
        //    }

        //    foreach (var n in ast)
        //    {
                
        //        n.HasBreakpoint = bpExps.Contains(n.Index);
                
        //        Program.Log(
        //            "{0} breakpoint at index {1}: {2}",
        //            n.HasBreakpoint ? "Setting" : "Clearing",
        //            n.Index,
        //            n);
        //    }
        //}
    }
}
