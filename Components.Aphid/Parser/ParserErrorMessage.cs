using Components.Aphid.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public static partial class ParserErrorMessage
    {
        public static string Create(string code, AphidParserException exception, bool highlight)
        {
            return
                exception.UnexpectedToken.TokenType != AphidTokenType.None ? FromToken(code, exception, highlight) :
                exception.Expression != null ? FromExpression(code, exception, highlight) :
                exception.Message;
        }
    }
}
