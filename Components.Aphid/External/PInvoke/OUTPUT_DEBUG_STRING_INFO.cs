using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.PInvoke
{
    [StructLayout(LayoutKind.Sequential)]
    public struct OUTPUT_DEBUG_STRING_INFO
    {
        [MarshalAs(UnmanagedType.LPStr)]
        public string lpDebugStringData;
        public ushort fUnicode;
        public ushort nDebugStringLength;
    }
}
