using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Cypress
{
    public class DebugProcess
    {
        public Process Process { get; private set; }

        public DebugProcess Parent { get; private set; }

        public List<DebugProcess> Children { get; private set; }

        public DebugProcess(Process process, DebugProcess parent)
        {
            Process = process;
            Parent = parent;
            Children = new List<DebugProcess>();
        }

        public IEnumerable<DebugProcess> Flatten()
        {
            return new[] { this }.Concat(Children.SelectMany(x => x.Flatten()));
        }
    }
}
