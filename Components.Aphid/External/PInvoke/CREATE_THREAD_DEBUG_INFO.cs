using System;
using System.Runtime.InteropServices;

namespace Components.PInvoke
{
    [StructLayout(LayoutKind.Sequential)]
    public struct CREATE_THREAD_DEBUG_INFO
    {
        public IntPtr hThread;
        public IntPtr lpThreadLocalBase;
        public PTHREAD_START_ROUTINE lpStartAddress;
    }
}
