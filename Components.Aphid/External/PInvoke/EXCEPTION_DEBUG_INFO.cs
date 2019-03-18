using System.Runtime.InteropServices;

namespace Components.PInvoke
{
    [StructLayout(LayoutKind.Sequential)]
    public struct EXCEPTION_DEBUG_INFO
    {
        public EXCEPTION_RECORD ExceptionRecord;
        public uint dwFirstChance;
    }
}
