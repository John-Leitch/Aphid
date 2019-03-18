using System.Collections.Generic;
using System.Runtime.InteropServices;

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

        public override bool Equals(object obj)
        {
            if (!(obj is ScannerToken))
            {
                return false;
            }

            var token = (ScannerToken)obj;
            return Type == token.Type &&
                   Index == token.Index &&
                   Lexeme == token.Lexeme;
        }

        public override int GetHashCode()
        {
            var hashCode = -379766517;
            hashCode = (hashCode * -1521134295) + Type.GetHashCode();
            hashCode = (hashCode * -1521134295) + Index.GetHashCode();
            hashCode = (hashCode * -1521134295) + EqualityComparer<string>.Default.GetHashCode(Lexeme);
            return hashCode;
        }

        public static bool operator ==(ScannerToken token1, ScannerToken token2) => token1.Equals(token2);

        public static bool operator !=(ScannerToken token1, ScannerToken token2) => !(token1 == token2);
    }
}
