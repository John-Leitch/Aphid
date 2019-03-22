using System.Collections.Generic;

namespace Components.Aphid.Lexer
{
    // Todo: generate based on Mantispin input
    public partial class AphidLexer
    {
        public int GetMode() => mode;

        public void SetMode(int m) => mode = m;

        public void SetCodeMode() => mode = 0;

        public void SetTextMode() => mode = 1;

        public void SetShellMode() => mode = 2;

        public static List<AphidToken> GetTokens(string text) => new AphidLexer(text).GetTokens();

        public static List<AphidToken> GetAllTokens(string text) => new AphidLexer(text).GetAllTokens();

        public static AphidToken GetToken(string text) => GetToken(text, 0);

        public static AphidToken GetToken(string text, int offset)
        {
            var lexer = new AphidLexer(text) { charIndex = offset - 1 };
            var type = lexer.GetToken();
            var index = lexer.lastIndex + 1;
            var lexeme = text.Substring(index, lexer.charIndex - lexer.lastIndex);

            return new AphidToken(type, lexeme, index);
        }

        public static AphidTokenType GetTokenType(string text) => GetTokenType(text, 0);

        public static AphidTokenType GetTokenType(string text, int offset)
        {
            var lexer = new AphidLexer(text) { charIndex = offset - 1 };

            return lexer.GetToken();
        }
    }
}
