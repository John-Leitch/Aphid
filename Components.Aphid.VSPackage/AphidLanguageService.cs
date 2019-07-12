using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Microsoft.VisualStudio.Package;
using Microsoft.VisualStudio.TextManager.Interop;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.VSPackage
{
    public class AphidLanguageService : LanguageService
    {
        private readonly bool _isTest = true;

        public override string GetFormatFilterList() => "Aphid files (*.alx)\n*.alx\n";

        public override LanguagePreferences GetLanguagePreferences() => new LanguagePreferences()
        {
            EnableMatchBracesAtCaret = true,
            EnableCodeSense = true,
            CodeSenseDelay = 500,
            AutoListMembers = true,
            EnableFormatSelection = true,
            EnableMatchBraces = true,
            LineNumbers = true,
            EnableCommenting = true,
            EnableShowMatchingBrace = true,
            IndentStyle = IndentingStyle.Smart,
            IndentSize = 4,
            InsertTabs = false,
            EnableQuickInfo = true,
            MaxErrorMessages = 100,
            AutoOutlining = true,
            EnableAsyncCompletion = true,
            ParameterInformation = true,
            HighlightMatchingBraceFlags = _HighlightMatchingBraceFlags.HMB_USERECTANGLEBRACES,
        };

        public override IScanner GetScanner(Microsoft.VisualStudio.TextManager.Interop.IVsTextLines buffer) => new AphidScanner();

        public override string Name => "Aphid";

        private void CheckParseRequest(ParseRequest req)
        {
            try
            {
                var lexer = new AphidLexer(req.Text);
                var parser = new AphidParser(lexer.GetTokens());
                parser.Parse();
            }
            catch (AphidParserException e)
            {
                var lineCol = TokenHelper.GetIndexPosition(req.Text, e.UnexpectedToken.Index);

                var span = new TextSpan()
                {
                    iStartLine = lineCol.Item1,
                    iEndLine = lineCol.Item1,
                    iStartIndex = lineCol.Item2,
                    iEndIndex = lineCol.Item2 + (e.UnexpectedToken.Lexeme != null ? e.UnexpectedToken.Lexeme.Length : 0)
                };

                var msg = string.Format(
                    "Unexpected {0}: {1}, expected {2}",
                    e.UnexpectedToken.TokenType.ToString(),
                    e.UnexpectedToken.Lexeme,
                    e.ExpectedToken);

                req.Sink.AddError(req.FileName, msg, span, Severity.Error);
            }
        }

        static TextSpan CreateSpan(int line, int col) => new TextSpan()
        {
            iStartLine = line,
            iStartIndex = col,
            iEndLine = line,
            iEndIndex = col + 1,
        };

        private List<AphidToken> GetTokens(string text) => new AphidLexer(text).GetAllTokens();

        public override AuthoringScope ParseSource(ParseRequest req)
        {
            Debug.WriteLine("Parse reason: {0}", req.Reason);

            var scope = new AphidAuthoringScope
            {
                Identifiers = GetTokens(req.Text)
                    .Where(x => x.TokenType == AphidTokenType.Identifier)
                    .Select(x => x.Lexeme)
                    .Distinct()
                    .ToArray()
            };

            switch (req.Reason)
            {
                case ParseReason.QuickInfo:
                    break;

                case ParseReason.MemberSelect:
                    break;

                case ParseReason.DisplayMemberList:
                    break;

                case ParseReason.CompleteWord:
                    break;

                case ParseReason.MatchBraces:
                case ParseReason.MemberSelectAndHighlightBraces:
                case ParseReason.HighlightBraces:
                    var braces = TokenHelper.GetBraces(
                        req.Text,
                        req.Line,
                        req.Col - 1);

                    if (braces != null)
                    {
                        req.Sink.MatchPair(
                            CreateSpan(braces[0][0],
                            braces[0][1]),
                            CreateSpan(braces[1][0],
                            braces[1][1]), 1);

                        return scope;
                    }

                    var index = TokenHelper.GetIndex(req.Text, req.Line, req.Col - 1);
                    var str = req.Text.Substring(index);
                    var tokens = new AphidLexer(str).GetAllTokens();

                    var depth = 1;
                    var rightBraceIndex = -1;
                    var braceType = tokens[0].TokenType;
                    var i = 1;

                    switch (braceType)
                    {
                        case AphidTokenType.LeftBrace:
                            for (; i < tokens.Count; i++)
                            {
                                switch (tokens[i].TokenType)
                                {
                                    case AphidTokenType.LeftBrace:
                                        depth++;
                                        break;

                                    case AphidTokenType.RightBrace:
                                        depth--;
                                        break;
                                }

                                if (depth == 0)
                                {
                                    rightBraceIndex = index + tokens[i].Index;
                                    break;
                                }
                            }
                            break;

                        case AphidTokenType.LeftParenthesis:
                            for (; i < tokens.Count; i++)
                            {
                                switch (tokens[i].TokenType)
                                {
                                    case AphidTokenType.LeftParenthesis:
                                        depth++;
                                        break;

                                    case AphidTokenType.RightParenthesis:
                                        depth--;
                                        break;
                                }

                                if (depth == 0)
                                {
                                    rightBraceIndex = index + tokens[i].Index;
                                    break;
                                }
                            }
                            break;

                        case AphidTokenType.LeftBracket:
                            for (; i < tokens.Count; i++)
                            {
                                switch (tokens[i].TokenType)
                                {
                                    case AphidTokenType.LeftBracket:
                                        depth++;
                                        break;

                                    case AphidTokenType.RightBracket:
                                        depth--;
                                        break;
                                }

                                if (depth == 0)
                                {
                                    rightBraceIndex = index + tokens[i].Index;
                                    break;
                                }
                            }
                            break;

                            //Todo: handle other direction
                    }


                    


                    if (rightBraceIndex != -1)
                    {
                        var rightLineCol = TokenHelper.GetIndexPosition(req.Text, rightBraceIndex);

                        req.Sink.MatchPair(
                            CreateSpan(req.Line, req.Col - 1),
                            CreateSpan(rightLineCol.Item1, rightLineCol.Item2), 1);
                    }

                    break;

                case ParseReason.Check:
                    CheckParseRequest(req);
                    break;

                default:
                    break;
            }

            return scope;
        }
    }
}
