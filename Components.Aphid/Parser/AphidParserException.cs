using Components.Aphid.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public class AphidParserException : Exception
    {
        public AphidToken UnexpectedToken { get; set; }

        public AphidTokenType ExpectedToken { get; set; }

        private string _message;

        public override string Message
        {
            get { return _message; }
        }

        public AphidParserException(AphidToken unexpectedToken)
        {
            UnexpectedToken = unexpectedToken;
            _message = CreateUnexpectedMessage(unexpectedToken) + ".";
        }

        public AphidParserException(AphidToken unexpectedToken, AphidTokenType expectedToken)
        {
            UnexpectedToken = unexpectedToken;
            ExpectedToken = expectedToken;
            
            _message = string.Format(
                "{0}; expected {1}.",
                CreateUnexpectedMessage(unexpectedToken),
                expectedToken);
        }

        private string CreateUnexpectedMessage(AphidToken token)
        {
            return string.Format(
                "Unexpected {0} ({1}) at offset {2}",
                token.TokenType,
                token.Lexeme,
                token.Index);
        }
    }
}
