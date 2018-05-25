using System.Runtime.InteropServices;

namespace Components.PInvoke
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct SHARE_INFO_0
    {
        public string shi0_netname;
    }
}
