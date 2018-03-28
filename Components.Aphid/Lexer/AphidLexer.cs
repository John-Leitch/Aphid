using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Lexer
{
    // Todo: generate based on Mantispin input
    public partial class AphidLexer
    {
        public int GetMode()
        {
            return mode;
        }

        public void SetMode(int m)
        {
            mode = m;
        }

        public void SetCodeMode()
        {
            mode = 0;
        }

        public void SetTextMode()
        {
            mode = 1;
        }

        public void SetShellMode()
        {
            mode = 2;
        }

        public static List<AphidToken> GetTokens(string text)
        {
            return new AphidLexer(text).GetTokens();
        }

        public static List<AphidToken> GetAllTokens(string text)
        {
            return new AphidLexer(text).GetAllTokens();
        }

        public static AphidToken GetToken(string text)
        {
            return GetToken(text, 0);
        }

        public static AphidToken GetToken(string text, int offset)
        {
            var lexer = new AphidLexer(text);
            lexer.charIndex = offset - 1;
            var type = lexer.GetToken();
            var index = lexer.lastIndex + 1;
            var lexeme = text.Substring(index, lexer.charIndex - lexer.lastIndex);

            return new AphidToken(type, lexeme, index);
        }

        public static AphidTokenType GetTokenType(string text)
        {
            return GetTokenType(text, 0);
        }

        public static AphidTokenType GetTokenType(string text, int offset)
        {
            var lexer = new AphidLexer(text);
            lexer.charIndex = offset - 1;

            return lexer.GetToken();
        }
    }
}
