using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public class ArgToken
    {
        public ArgTokenType Type { get; set; }

        public int Offset { get; set; }

        public int EndOffset { get; set; }

        public string Lexeme { get; set; }

        public string Value { get; set; }

        public ArgToken(ArgTokenType type, int offset, int endOffset, string lexeme, string value)
        {
            Type = type;
            Offset = offset;
            EndOffset = endOffset;
            Lexeme = lexeme;
            Value = value;
        }

        public override string ToString() =>
            $"[{Type.ToString()}] {Offset:x4}-{EndOffset:x4} {Lexeme}: {Value}";
    }
}
