using System.Runtime.InteropServices;

namespace Components.PInvoke
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RIP_INFO
    {
        public uint dwError;
        public uint dwType;
    }
}
