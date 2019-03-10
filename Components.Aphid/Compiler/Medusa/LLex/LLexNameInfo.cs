using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LLex
{
    public class LLexNameInfo
    {
        public string FullName { get; set; }

        public string Name { get; set; }

        public string Namespace { get; set; }

        public string LexerName { get; set; }

        public string TokenName { get; set; }

        public string TokenTypeName { get; set; }

        public static LLexNameInfo Parse(string fullName)
        {
            var lastDot = fullName.LastIndexOf('.');
            var name = fullName.Substring(lastDot + 1);

            return new LLexNameInfo
            {
                FullName = fullName,
                Name = name,
                Namespace = fullName.Remove(lastDot),
                LexerName = name + "Lexer",
                TokenName = name + "Token",
                TokenTypeName = name + "TokenType"
            };
        }
    }
}
