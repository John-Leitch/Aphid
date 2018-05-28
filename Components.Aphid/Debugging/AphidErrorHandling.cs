using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Debugging
{
    public static class AphidErrorHandling
    {
        public static bool HandleErrors
        {
            get { return !Debugger.IsAttached || IgnoreDebugger; }
        }

        public static bool IgnoreDebugger { get; set; }
    }
}
