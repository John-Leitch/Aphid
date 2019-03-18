using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Components.PInvoke
{
    public static class NetApi32
    {
        [DllImport("Netapi32.dll", CharSet = CharSet.Unicode)]
        public static extern int NetShareEnum(
             StringBuilder ServerName,
             int level,
             ref IntPtr bufPtr,
             uint prefmaxlen,
             ref int entriesread,
             ref int totalentries,
             ref int resume_handle);

        [DllImport("Netapi32.dll", SetLastError = true)]
        public static extern int NetApiBufferFree(IntPtr Buffer);
    }
}
