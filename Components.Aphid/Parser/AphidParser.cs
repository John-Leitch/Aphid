using Components.Aphid.Lexer;
using System.Collections.Generic;

namespace Components.Aphid.Parser
{
    public partial class AphidParser
    {
        private readonly List<AphidToken> _tokens;

        private int _tokenIndex = -1;

        public AphidToken CurrentToken { get; private set; }

        public bool UseImplicitReturns { get; set; }

        public AphidParser(List<AphidToken> tokens)
        {
            UseImplicitReturns = true;
            _tokens = tokens;
        }


#if DBG_STEPTHROUGH
        [System.Diagnostics.DebuggerStepThrough]
#endif
        public bool Match(AphidTokenType tokenType)
        {
            if (CurrentToken.TokenType == tokenType)
            {
                NextToken();
                return true;
            }

            throw new AphidParserException(CurrentToken, tokenType);
        }

#if DBG_STEPTHROUGH
        [System.Diagnostics.DebuggerStepThrough]
#endif
        public bool NextToken()
        {
            _tokenIndex++;

            if (_tokenIndex < _tokens.Count)
            {
                CurrentToken = _tokens[_tokenIndex];
                return true;
            }

            CurrentToken = AphidToken.GetNone(CurrentToken.Index + CurrentToken.Lexeme.Length);

            return false;
        }

#if DBG_STEPTHROUGH
        [System.Diagnostics.DebuggerStepThrough]
#endif
        public bool PreviousToken()
        {
            if (_tokens.Count == 0 || _tokenIndex == 0)
            {
                CurrentToken = AphidToken.None;

                return false;
            }

            CurrentToken = _tokens[--_tokenIndex];

            return true;
        }

#if DBG_STEPTHROUGH
        [System.Diagnostics.DebuggerStepThrough]
#endif
        public bool SetToken(int index)
        {
            _tokenIndex = index;

            if (_tokenIndex < _tokens.Count)
            {
                CurrentToken = _tokens[_tokenIndex];
                return true;
            }

            CurrentToken = AphidToken.None;

            return false;
        }

        public static List<AphidExpression> Parse(List<AphidToken> tokens, string code) =>
            Parse(tokens, code, useImplicitReturns: true);

        public static List<AphidExpression> Parse(
            List<AphidToken> tokens,
            string code,
            bool useImplicitReturns = true) =>
            Parse(tokens, code, null, useImplicitReturns);

        public static List<AphidExpression> Parse(
            List<AphidToken> tokens,
            string code,
            string filename,
            bool useImplicitReturns = true)
        {
            if (tokens.Count == 0)
            {
                return new List<AphidExpression>();
            }

            var parser = new AphidParser(tokens) { UseImplicitReturns = useImplicitReturns };

            List<AphidExpression> ast;

            try
            {
                ast = parser.Parse();
            }
            catch (AphidParserException e)
                when (!string.IsNullOrEmpty(filename) && string.IsNullOrEmpty(e.Filename))
            {
                e.Filename = filename;
                throw;
            }

            if (ast.Count != 0)
            {
                if (code != null)
                {
                    ast[0].Code = code;
                }

                if (filename != null)
                {
                    ast[0].Filename = filename;
                }
            }

            new AphidCodeVisitor().Visit(ast);

            return ast;
        }

        public static AphidExpression ParseExpression(string code) =>
            ParseExpression(AphidLexer.GetTokens(code), code);

        public static AphidExpression ParseExpression(List<AphidToken> tokens, string code)
        {
            var ast = Parse(tokens, code);

            if (ast.Count != 1)
            {
                throw new AphidParserException(
                    "Expected end of expression, found: {0}",
                    code.Substring(ast[1].Index));
            }

            return ast[0];
        }

        public static List<AphidExpression> Parse(string code) =>
            Parse(code, useImplicitReturns: true);

        public static List<AphidExpression> Parse(
            string code,
            bool isTextDocument = false,
            bool useImplicitReturns = true) =>
            Parse(code, null, isTextDocument, useImplicitReturns);

        public static List<AphidExpression> Parse(
            string code,
            string filename,
            bool isTextDocument = false,
            bool useImplicitReturns = true)
        {
            var lexer = new AphidLexer(code);

            if (isTextDocument)
            {
                lexer.SetTextMode();
            }

            return Parse(
                lexer.GetTokens(),
                code,
                filename,
                useImplicitReturns: useImplicitReturns);
        }

        public static List<AphidExpression> ParseFile(string filename) =>
            ParseFile(
                filename,
                isTextDocument: false,
                useImplicitReturns: true);

        public static List<AphidExpression> ParseFile(
            string filename,
            bool isTextDocument = false,
            bool useImplicitReturns = true) =>
            Parse(
                AphidScript.Read(filename),
                filename,
                isTextDocument,
                useImplicitReturns);
    }
}
