using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Components.External.ConsolePlus
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct ScannerToken
    {
        [FieldOffset(0)]
        public ScannerTokenType Type;

        [FieldOffset(4)]
        public int Index;

        [FieldOffset(8)]
        [MarshalAs(UnmanagedType.LPStr)]
        public string Lexeme;

        public ScannerToken(ScannerTokenType type, int index, string lexeme)
        {
            Type = type;
            Index = index;
            Lexeme = lexeme;
        }
    }
}
