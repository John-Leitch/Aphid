using Components.Aphid.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Parser
{
    public partial class AphidParser
    {
        private List<AphidToken> _tokens;

        private int _tokenIndex = -1;

        private AphidToken _currentToken;

        public bool UseImplicitReturns { get; set; }

        public AphidParser(List<AphidToken> tokens)
        {
            UseImplicitReturns = true;
            _tokens = tokens;
        }

        [System.Diagnostics.DebuggerStepThrough]
        private bool Match(AphidTokenType tokenType)
        {
            if (_currentToken.TokenType == tokenType)
            {
                NextToken();
                return true;
            }
            else
            {
                throw new AphidParserException(_currentToken, tokenType);
            }
        }

        [System.Diagnostics.DebuggerStepThrough]
        public bool NextToken()
        {
            _tokenIndex++;

            if (_tokenIndex < _tokens.Count)
            {
                _currentToken = _tokens[_tokenIndex];
                return true;
            }
            else
            {
                _currentToken = default(AphidToken);
                return false;
            }
        }

        public static List<AphidExpression> Parse(string code, bool isTextDocument = false)
        {
            var lexer = new AphidLexer(code);

            if (isTextDocument)
            {
                lexer.SetTextMode();
            }

            return new AphidParser(lexer.GetTokens()).Parse();
        }
    }
}
