using Components.Aphid.Interpreter;
using System.Diagnostics;
using Components.Aphid.TypeSystem;

namespace Components.Aphid.Library
{
    [AphidLibrary("dbg.breakpoint")]
    public static class DebugLibrary
    {
        [AphidInteropFunction("dbg.breakpoint")]
        private static void DebuggerBreak() => Debugger.Break();
    }
}

