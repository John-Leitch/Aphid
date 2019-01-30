using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Components.PInvoke
{
    [StructLayout(LayoutKind.Sequential)]
    public struct LASTINPUTINFO
    {
        public static readonly int SizeOf = Marshal.SizeOf(typeof(LASTINPUTINFO));

        [MarshalAs(UnmanagedType.U4)]
        public uint cbSize;
        [MarshalAs(UnmanagedType.U4)]
        public uint dwTime;
    }
}
