﻿#if APHID_DEBUGGING_ENABLED
#if CHECKED
#define APHID_DEBUGGING_TRACE
#define APHID_DEBUGGING_TRACE_VERBOSE
#endif
using Components;
using Components.Aphid.Parser;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Debugging
{
    public class AphidBreakpointVisitor : AphidVisitor
    {
        private readonly string _filename;

        private readonly int[] _indexes;

        private readonly Dictionary<int, bool> _indexSet = new Dictionary<int, bool>();

        public AphidBreakpointVisitor(string filename, int[] indexes)
        {
            _filename = filename;
            _indexes = indexes;
            _indexSet = _indexes.AsKeyFor(x => false);
        }

        protected override void Visit(AphidExpression expression)
        {
            if (_filename.Equals(expression.Filename, StringComparison.OrdinalIgnoreCase))
            {
#if APHID_DEBUGGING_TRACE
                var oldValue = expression.HasBreakpoint;
#endif
                if (_indexes.Contains(expression.Index))
                {
                    if (!_indexSet[expression.Index])
                    {
                        expression.HasBreakpoint = true;
                        _indexSet[expression.Index] = true;
                    }
                }
                else if (expression.HasBreakpoint)
                {
                    expression.HasBreakpoint = false;
                }

#if APHID_DEBUGGING_TRACE
                if (oldValue != expression.HasBreakpoint)
                {
                    if (expression.HasBreakpoint)
                    {
                        Cli.WriteSuccessMessage(
                            "Breakpoint set on expression ~Green~{0}~R~",
                            expression);
                    }
                    else
                    {
                        Cli.WriteSuccessMessage(
                            "Breakpoint disabled expression ~Magenta~{0}~R~",
                            expression);
                    }
                }
#endif
            }
#if APHID_DEBUGGING_TRACE_VERBOSE
            else
            {
                Cli.WriteErrorMessage(
                    "Breakpoint visitor mismatch at expression {0}:\r\n" +
                        "    Expected: ~Yellow~{1}~R~\r\n" +
                        "    Found:    ~Yellow~{2}~R~",
                    expression,
                    _filename ?? "[null]",
                    expression != null && expression.Filename != null ?
                        expression.Filename : "[null]");
            }
#endif
        }
    }
}
#endif
