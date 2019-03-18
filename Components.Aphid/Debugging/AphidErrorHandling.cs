using System.Diagnostics;

namespace Components.Aphid.Debugging
{
    public static class AphidErrorHandling
    {
        public static bool HandleErrors => !Debugger.IsAttached || IgnoreDebugger;

        public static bool IgnoreDebugger { get; set; }
    }
}
