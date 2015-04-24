using Components.Aphid.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public static class ParserErrorMessage
    {
        public static string Create(string code, AphidParserException exception)
        {
            var line = TokenHelper.GetIndexPosition(code, exception.UnexpectedToken.Index);

            return string.Format(
                "Unexpected {0} {1} on line {2}\r\n\r\n{3}\r\n",
                exception.UnexpectedToken.TokenType.ToString().ToLower(),
                exception.UnexpectedToken.Lexeme,
                line.Item1,
                TokenHelper.GetCodeExcerpt(code, exception.UnexpectedToken));
        }
    }
}
