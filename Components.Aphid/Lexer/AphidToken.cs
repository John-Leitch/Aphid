using System.Collections.Generic;

namespace Components.Aphid.Lexer
{
    public readonly partial struct AphidToken
    {
        public static readonly AphidToken None = GetNone(-1);

        public static AphidToken GetNone(int index) =>
            new AphidToken(AphidTokenType.None, null, index);

        public override bool Equals(object obj) => !(obj is AphidToken token)
                ? false
                : TokenType == token.TokenType &&
                   Lexeme == token.Lexeme &&
                   Index == token.Index;

        public override int GetHashCode()
        {
            var hashCode = 98192144;
            hashCode = (hashCode * -1521134295) + TokenType.GetHashCode();
            hashCode = (hashCode * -1521134295) + EqualityComparer<string>.Default.GetHashCode(Lexeme);
            hashCode = (hashCode * -1521134295) + Index.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(in AphidToken token1, in AphidToken token2) => token1.Equals(token2);

        public static bool operator !=(in AphidToken token1, in AphidToken token2) => !(token1 == token2);
    }
}
