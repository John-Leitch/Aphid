using Components;
using Components.Aphid.Parser;
using Components.External;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VSCodeDebug
{
    public class AphidBreakpointController
    {
        //private readonly Dictionary<string, DateTime> _codeCacheTime = new Dictionary<string, DateTime>();

        //private ArgLockingMemoizer<string, string> _codeMemoizer = new ArgLockingMemoizer<string, string>();

        private ArgLockingMemoizer<string, List<AphidExpression>> _astMemoizer = new ArgLockingMemoizer<string, List<AphidExpression>>(StringComparer.OrdinalIgnoreCase);

        public List<Breakpoint> UpdateBreakpoints(
            AphidDebugSession session,
            Response response,
            string scriptFile,
            SourceBreakpoint[] sourceBreakpoints)
        {
            // Todo: better handle forward slashes
            var fullScriptFile = Path.GetFullPath(scriptFile).Replace('/', '\\');
            var lastWrite = new FileInfo(fullScriptFile).LastWriteTime;

            //if (_codeCacheTime.TryGetValue(fullScriptFile, out var time) && time < lastWrite)
            //{
            //    _astMemoizer.Remove(fullScriptFile);
            //    _codeMemoizer.Remove(fullScriptFile);
            //    _codeCacheTime[fullScriptFile] = lastWrite;
            //}
            //else
            //{
            //    _codeCacheTime.Add(fullScriptFile, lastWrite);
            //}
            
            Cli.WriteInfoMessage("Parsing {0}", fullScriptFile);
            //var code = _codeMemoizer.Call(File.ReadAllText, fullScriptFile);
            var code = File.ReadAllText(fullScriptFile);

            var ast = _astMemoizer.Call(x => session.Parse(response, x), fullScriptFile);

            if (ast == null)
            {
                return null;
            }

            var lineResolver = new AphidLineResolver();
            
            var breakpointExpressions = lineResolver.ResolveLineExpressions(
                ast,
                code,
                sourceBreakpoints);
            
            var bps = new List<Breakpoint>();
            var j = 0;
            var bpExps = new List<AphidExpression>();

            foreach (var exp in breakpointExpressions)
            {
                //var line = clientLines[j++];
                Program.Log("Setting breakpoint at index {0}: {1}",
                    exp.Index,
                    exp.ToString());
                
            }            

            session.Interpreter.SetFileBreakpoints(
                fullScriptFile,
                breakpointExpressions.Select(x => x.Index).ToArray());

            return sourceBreakpoints
                .Select(x => new Breakpoint(true, x.line, x.column))
                .ToList(); ;
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
