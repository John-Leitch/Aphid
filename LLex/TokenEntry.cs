using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LLex
{
    public class TokenEntry
    {
        public int? NewMode { get; set; }
        public string Lexeme { get; set; }
        public string TokenType { get; set; }
        public string Code { get; set; }

        public TokenEntry(string lexeme, string tokenType, string code, int? newMode)
        {
            Lexeme = lexeme;
            NewMode = newMode;
            TokenType = tokenType;
            Code = code;
        }

        public TokenEntry(string lexeme, string tokenType)
            : this(lexeme, tokenType, null, null)
        {
        }

        public TokenEntry(string lexeme, string tokenType, string code)
            : this(lexeme, tokenType, code, null)
        {
        }

        public override string ToString()
        {
            return Lexeme;
        }
    }
}
