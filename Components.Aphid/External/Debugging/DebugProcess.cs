using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Cypress
{
    public class DebugProcess
    {
        public Process Process { get; }

        public DebugProcess Parent { get; }

        public List<DebugProcess> Children { get; }

        public DebugProcess(Process process, DebugProcess parent)
        {
            Process = process;
            Parent = parent;
            Children = new List<DebugProcess>();
        }

        public IEnumerable<DebugProcess> Flatten() =>
            new[] { this }.Concat(Children.SelectMany(x => x.Flatten()));
    }
}
