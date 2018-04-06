#if UNSAFE_CONSOLE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Components.External.ConsolePlus
{
    // Todo: compare perf of 4/8 byte alignment
    // versus packing to leverage CPU cache
#if AMD64
    [StructLayout(LayoutKind.Explicit, Pack = 8, Size = CliWriteMessage.Size)]
    public unsafe struct CliWriteMessage
    {
        public const int Size = 0x8 * 0x3;

        [FieldOffset(0), MarshalAs(UnmanagedType.LPTStr)]
        public string Format;

        [FieldOffset(8), MarshalAs(UnmanagedType.Bool)]
        public bool NewLine;

        [FieldOffset(16)]
        public IntPtr ArgsPointer;
    }
#else
    [StructLayout(LayoutKind.Explicit, Pack = 4, Size = 0xc)]
    public unsafe struct CliWriteMessage
    {
        public const int Size = 0x4 * 0x3;

        [FieldOffset(0), MarshalAs(UnmanagedType.LPTStr)]
        public string Format;

        [FieldOffset(7), MarshalAs(UnmanagedType.Bool)]
        public bool NewLine;

        [FieldOffset(8)]
        public IntPtr ArgsPointer;
    }
#endif
}
#endif