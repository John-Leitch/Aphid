using Components.Aphid.Lexer;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.UI
{
    public class AphidScanner : IScanner
    {
        public IEnumerable<ScannerToken> Tokenize(string text)
        {
            return AphidLexer
                .GetTokens(text)
                .Select(x => new ScannerToken(
                    x.TokenType == AphidTokenType.Identifier ? ScannerTokenType.Identifier :
                    x.TokenType == AphidTokenType.MemberOperator ? ScannerTokenType.MemberOperator :
                    ScannerTokenType.Other,
                    x.Index,
                    x.Lexeme));
        }
    }
}
