using Components.Aphid.Lexer;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.UI
{
    public class AphidSyntaxHighlighter : ISyntaxHighlighter
    {
        public IEnumerable<ColoredText> Highlight(string text)
        {
            var isFirst = true;
            byte[] bg = null, fg = null;
            var sb = new StringBuilder();

            foreach (var t in HighlightCore(text))
            {
                if (isFirst)
                {
                    sb.Append(t.Text);
                    fg = t.ForegroundRgb;
                    bg = t.BackgroundRgb;
                    isFirst = false;
                }
                else
                {
                    if ((fg == null && t.ForegroundRgb != null) ||
                        (bg == null && t.BackgroundRgb != null) ||
                        (fg != null &&
                            (fg[0] != t.ForegroundRgb[0] ||
                            fg[1] != t.ForegroundRgb[1] ||
                            fg[2] != t.ForegroundRgb[2])) ||
                        (bg != null &&
                            (bg[0] != t.BackgroundRgb[0] ||
                            bg[1] != t.BackgroundRgb[1] ||
                            bg[2] != t.BackgroundRgb[2])))
                    {
                        var ct = new ColoredText(fg, bg, sb.ToString());
                        sb.Clear();
                        sb.Append(t.Text);
                        fg = t.ForegroundRgb;
                        bg = t.BackgroundRgb;

                        yield return ct;
                    }
                    else
                    {
                        sb.Append(t.Text);
                    }
                }
            }

            if (!isFirst)
            {
                yield return new ColoredText(fg, bg, sb.ToString());
            }
        }

        private IEnumerable<ColoredText> HighlightCore(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return Array.Empty<ColoredText>();
            }

            var allTokens = AphidLexer.GetAllTokens(text);
            var tokens = AphidLexer.GetTokens(text);

            if (tokens.Count == 0)
            {
                return allTokens.Select(x => GetColoredText(x));
            }

            var peekTable = Enumerable
                .Range(0, tokens.Count - 1)
                .ToDictionary(x => tokens[x].Index, x => tokens[x + 1].TokenType);

            void addNone(AphidToken t) => peekTable.Add(t.Index, AphidTokenType.None);
            addNone(tokens[tokens.Count - 1]);            
            allTokens.Except(tokens).For(addNone);

            return allTokens.Select(x => GetColoredText(x, peekTable[x.Index]));
        }

        private static ColoredText GetColoredText(AphidToken token) =>
            GetColoredText(token, AphidTokenType.None);

        private static ColoredText GetColoredText(AphidToken token, AphidTokenType nextType) =>
            new ColoredText(GetColor(token.TokenType, nextType), token.Lexeme);

        // Todo:
        // * Move colors into configuration file
        // * Allow for custom token groups, individual coloring,
        //   custom rbg, and themes.
        // * Generate from Mantipsid.
        // * Configuration builder/editor, possibly using WPF.
        //   - Use VT100 dump funcs or similar to build color picker.
        //   - Support custom named colors.
        //   - Live preview of colors.
        // * Unify with VS and VSC syntax highlighters
        private static byte[] GetColor(AphidTokenType type) =>
            GetColor(type, AphidTokenType.None);

        private static byte[] GetColor(AphidTokenType type, AphidTokenType nextType)
        {
            switch (type)
            {
                case AphidTokenType.String:
                    return SystemColor.Coral;

                case AphidTokenType.Number:
                case AphidTokenType.HexNumber:
                case AphidTokenType.BinaryNumber:
                    return SystemColor.PaleGoldenrod;

                case AphidTokenType.Identifier:
                    switch (nextType)
                    {
                        default:
                            return SystemColor.CadetBlue;

                        case AphidTokenType.Identifier:
                        case AphidTokenType.ImplicitArgumentOperator:
                        case AphidTokenType.ImplicitArgumentsOperator:
                        case AphidTokenType.PatternMatchingOperator:
                        case AphidTokenType.BinaryNumber:
                        case AphidTokenType.Number:
                        case AphidTokenType.HexNumber:
                            return SystemColor.DodgerBlue;                        
                    }

                case AphidTokenType.breakKeyword:
                case AphidTokenType.catchKeyword:
                case AphidTokenType.continueKeyword:
                case AphidTokenType.defaultKeyword:
                case AphidTokenType.definedKeyword:
                case AphidTokenType.deleteKeyword:
                case AphidTokenType.doKeyword:
                case AphidTokenType.elseKeyword:
                case AphidTokenType.extendKeyword:
                case AphidTokenType.falseKeyword:
                case AphidTokenType.finallyKeyword:
                case AphidTokenType.forKeyword:
                case AphidTokenType.ifKeyword:
                case AphidTokenType.inKeyword:
                case AphidTokenType.loadKeyword:
                case AphidTokenType.lockKeyword:
                case AphidTokenType.newKeyword:
                case AphidTokenType.nullKeyword:
                case AphidTokenType.retKeyword:
                case AphidTokenType.switchKeyword:
                case AphidTokenType.thisKeyword:
                case AphidTokenType.throwKeyword:
                case AphidTokenType.trueKeyword:
                case AphidTokenType.tryKeyword:
                case AphidTokenType.usingKeyword:
                case AphidTokenType.whileKeyword:

                case AphidTokenType.ImplicitArgumentOperator:
                case AphidTokenType.ImplicitArgumentsOperator:

                case AphidTokenType.FunctionOperator:
                case AphidTokenType.InteropOperator:
                case AphidTokenType.LoadLibraryOperator:
                case AphidTokenType.LoadScriptOperator:
                case AphidTokenType.PatternMatchingOperator:

                    return SystemColor.DodgerBlue;

                case AphidTokenType.AdditionOperator:
                case AphidTokenType.AggregateOperator:
                case AphidTokenType.AndOperator:
                case AphidTokenType.AnyOperator:
                case AphidTokenType.AssignmentOperator:
                case AphidTokenType.BinaryAndEqualOperator:
                case AphidTokenType.BinaryAndOperator:
                case AphidTokenType.BinaryOrOperator:
                case AphidTokenType.ColonOperator:
                case AphidTokenType.ComplementOperator:
                case AphidTokenType.ConditionalOperator:
                case AphidTokenType.DecrementOperator:
                case AphidTokenType.DistinctOperator:
                case AphidTokenType.DivisionEqualOperator:
                case AphidTokenType.DivisionOperator:
                case AphidTokenType.EqualityOperator:
                case AphidTokenType.GreaterThanOperator:
                case AphidTokenType.GreaterThanOrEqualOperator:
                case AphidTokenType.IncrementOperator:
                case AphidTokenType.LessThanOperator:
                case AphidTokenType.LessThanOrEqualOperator:
                case AphidTokenType.MinusEqualOperator:
                case AphidTokenType.MinusOperator:
                case AphidTokenType.ModulusEqualOperator:
                case AphidTokenType.ModulusOperator:
                case AphidTokenType.MultiplicationEqualOperator:
                case AphidTokenType.MultiplicationOperator:
                case AphidTokenType.NotEqualOperator:
                case AphidTokenType.NotOperator:
                case AphidTokenType.OrEqualOperator:
                case AphidTokenType.OrOperator:
                case AphidTokenType.PipelineOperator:
                case AphidTokenType.PlusEqualOperator:
                case AphidTokenType.RangeOperator:
                case AphidTokenType.SelectManyOperator:
                case AphidTokenType.SelectOperator:
                case AphidTokenType.ShiftLeftEqualOperator:
                case AphidTokenType.ShiftRightEqualOperator:
                case AphidTokenType.WhereOperator:
                case AphidTokenType.XorEqualOperator:
                case AphidTokenType.XorOperator:
                    return SystemColor.Silver;

                case AphidTokenType.LeftBrace:
                case AphidTokenType.RightBrace:
                case AphidTokenType.LeftBracket:
                case AphidTokenType.RightBracket:
                    return SystemColor.LightGray;

                case AphidTokenType.MemberOperator:
                    return SystemColor.White;

                case AphidTokenType.RightParenthesis:
                case AphidTokenType.LeftParenthesis:
                    return SystemColor.LightGray;

                case AphidTokenType.Comment:
                    return SystemColor.DarkGreen;

                default:
                    return SystemColor.White;
            }
        }
    }
}
