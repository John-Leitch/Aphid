using System;
using System.Runtime.InteropServices;

namespace Components.PInvoke
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct MINIDUMP_EXCEPTION_INFORMATION
    {
        public uint ThreadId;
        public IntPtr ExceptionPointers;
        [MarshalAs(UnmanagedType.Bool)]
        public bool ClientPointers;
    }
}
