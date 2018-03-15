using Components.Aphid.Interpreter;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using Components.Aphid.TypeSystem;

namespace Components.Aphid.Library
{
    [AphidLibraryAttribute("dbg.breakpoint")]
    public class DebugLibrary
    {
        [AphidInteropFunction("dbg.breakpoint")]
        private static void DebuggerBreak()
        {
            Debugger.Break();
        }        
    }
}

