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
            if (exception.ExpectedToken == AphidTokenType.None &&
                exception.UnexpectedToken.TokenType == AphidTokenType.None &&
                exception.Expression == null)
            {
                return exception.Message;
            }

            var sb = new StringBuilder();
            sb.AppendFormat(
                "Unexpected {0} '{1}'",
                exception.UnexpectedToken.TokenType.ToString().ToLower(),
                exception.UnexpectedToken.Lexeme);

            if (exception.ExpectedToken != default(AphidTokenType))
            {
                sb.AppendFormat(" expected {0}", exception.ExpectedToken);
            }

            if (exception.UnexpectedToken.Index < code.Length)
            {
                var line = TokenHelper.GetIndexPosition(code, exception.UnexpectedToken.Index);

                sb.AppendFormat(
                    " on line {0}\r\n\r\n{1}\r\n",
                    line.Item1,
                    TokenHelper.GetCodeExcerpt(code, exception.UnexpectedToken));
            }
            else
            {
                //sb.AppendFormat("\r\n{0}", exception.);
            }

            return sb.ToString();
        }
    }
}
