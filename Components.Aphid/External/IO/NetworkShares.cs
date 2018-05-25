using Components.PInvoke;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Components.IO
{
    public static class NetworkShares
    {
        public static string[] GetShares(string hostName)
        {
            var sharePtr = IntPtr.Zero;
            string[] shares;

            try
            {
                int errorCode, entriesRead = 0, totalEntries = 0, resumeHandle = 0;

                if ((errorCode = NetApi32.NetShareEnum(
                    new StringBuilder(hostName),
                    0,
                    ref sharePtr,
                    uint.MaxValue,
                    ref entriesRead,
                    ref totalEntries,
                    ref resumeHandle)) != 0)
                {
                    throw new Win32Exception(errorCode);
                }

                var structSize = Marshal.SizeOf<SHARE_INFO_0>();
                var shareInfo = Marshal.PtrToStructure<SHARE_INFO_0>(sharePtr);

                shares = Enumerable
                    .Range(0, entriesRead)
                    .Select(x => Marshal
                        .PtrToStructure<SHARE_INFO_0>(sharePtr + x * structSize)
                        .shi0_netname)
                    .ToArray();
            }
            finally
            {
                if (sharePtr != IntPtr.Zero)
                {
                    NetApi32.NetApiBufferFree(sharePtr);
                }
            }

            return shares;
        }
    }
}
