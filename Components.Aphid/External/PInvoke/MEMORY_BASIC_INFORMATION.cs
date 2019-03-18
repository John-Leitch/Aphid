using System;
using System.Runtime.InteropServices;

namespace Components.PInvoke
{
    [StructLayout(LayoutKind.Sequential)]
    public struct MEMORY_BASIC_INFORMATION
    {
        public IntPtr BaseAddress;
        public IntPtr AllocationBase;
        public AllocationProtect AllocationProtect;
        public IntPtr RegionSize;
        public uint State;
        public AllocationProtect Protect;
        public uint Type;
    }
}
