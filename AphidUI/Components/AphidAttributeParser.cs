using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.External;
using System.Collections.Generic;

namespace Components.Aphid.Wpf
{
    public static class AphidAttributeParser
    {
        private static readonly AphidTokenType _tickType = AphidLexer.GetTokenType("`");

        private static readonly Memoizer<string, AphidExpression> _memoizer = new Memoizer<string, AphidExpression>();        

        public static AphidExpression Parse(string expression) => _memoizer.Call(ParseCore, expression);

        private static AphidExpression ParseCore(string expression)
        {
            var fixedExpression = expression;
            List<AphidToken> tokens;
            AphidToken lastToken = default;
            int state, offset = 0;

            do
            {
                tokens = AphidLexer.GetTokens(fixedExpression);
                state = 0;

                for (var i = 0; i < tokens.Count; i++)
                {
                    lastToken = tokens[i];

                    if (lastToken.TokenType == _tickType)
                    {
                        offset = lastToken.Index;
                        fixedExpression = fixedExpression.Remove(offset, 1).Insert(offset, "'");

                        if (++state == 2)
                        {
                            break;
                        }
                    }
                }

                if (state == 1)
                {
                    throw new AphidParserException(
                        $"Unterminated string beginning at {expression.Substring(offset)}")
                    {
                        UnexpectedToken = lastToken,
                    };
                }

            }
            while (state != 0);

            return AphidParser.ParseExpression(tokens, expression);
        }
    }
}
