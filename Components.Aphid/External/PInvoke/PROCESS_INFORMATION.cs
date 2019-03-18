using System;
using System.Runtime.InteropServices;

namespace Components.PInvoke
{
    [StructLayout(LayoutKind.Sequential)]
    public class PROCESS_INFORMATION
    {
        public IntPtr hProcess;
        public IntPtr hThread;
        public uint dwProcessId;
        public uint dwThreadId;
    }
}
