using Components.Aphid.Parser;
using System.Collections.Generic;
using System.Linq;

namespace VSCodeDebug
{
    public class AphidBreakpointController
    {
        private string _code;

        private List<AphidExpression> _ast;

        public AphidBreakpointController(string code, List<AphidExpression> ast)
        {
            _code = code;
            _ast = ast;
        }

        public List<Breakpoint> UpdateBreakpoints(int[] clientLines)
        {
            var lineResolver = new AphidLineResolver(_code, _ast);
            var breakpointExpressions = lineResolver.ResolveLineExpressions(clientLines);
            var bps = new List<Breakpoint>();
            var j = 0;

            foreach (var exp in breakpointExpressions)
            {
                var line = clientLines[j++];
                Program.Log("Setting breakpoint on line {0}: {1}", line, exp.ToString());
                bps.Add(new Breakpoint(true, line));
                exp.HasBreakpoint = true;
            }

            var others = lineResolver.IndexTable
                .Where(x => !breakpointExpressions.Any(y => x.Value == y))
                .ToArray();

            foreach (var exp in others)
            {
                Program.Log("Clearing breakpoint on line {0}: {1}", exp.Key, exp.Value.ToString());
                exp.Value.HasBreakpoint = false;
            }

            return bps;
        }
    }
}
