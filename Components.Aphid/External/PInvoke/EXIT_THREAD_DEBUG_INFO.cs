using System.Runtime.InteropServices;

namespace Components.PInvoke
{
    [StructLayout(LayoutKind.Sequential)]
    public struct EXIT_THREAD_DEBUG_INFO
    {
        public uint dwExitCode;
    }
}
