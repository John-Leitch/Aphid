using Components.Aphid.Lexer;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Components.Aphid.Lexer.AphidTokenType;

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

        private static IEnumerable<ColoredText> HighlightCore(string text)
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

            void addNone(in AphidToken t) => peekTable.Add(t.Index, None);
            addNone(tokens[tokens.Count - 1]);            
            allTokens.Except(tokens).For(x => addNone(in x));

            return allTokens.Select(x => GetColoredText(x, peekTable[x.Index]));
        }

        private static ColoredText GetColoredText(in AphidToken token) =>
            GetColoredText(token, None);

        private static ColoredText GetColoredText(in AphidToken token, AphidTokenType nextType) =>
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
            GetColor(type, None);

        private static byte[] GetColor(AphidTokenType type, AphidTokenType nextType)
        {
            switch (type)
            {
                case AphidTokenType.String:
                    return SystemColor.Coral;

                case Number:
                case HexNumber:
                case BinaryNumber:
                    return SystemColor.PaleGoldenrod;

                case Identifier:
                    switch (nextType)
                    {
                        default:
                            return SystemColor.CadetBlue;

                        case Identifier:
                        case ImplicitArgumentOperator:
                        case ImplicitArgumentsOperator:
                        case PatternMatchingOperator:
                        case BinaryNumber:
                        case Number:
                        case HexNumber:
                            return SystemColor.DodgerBlue;                        
                    }

                case breakKeyword:
                case catchKeyword:
                case continueKeyword:
                case defaultKeyword:
                case definedKeyword:
                case deleteKeyword:
                case doKeyword:
                case elseKeyword:
                case extendKeyword:
                case falseKeyword:
                case finallyKeyword:
                case forKeyword:
                case ifKeyword:
                case inKeyword:
                case loadKeyword:
                case lockKeyword:
                case newKeyword:
                case nullKeyword:
                case retKeyword:
                case switchKeyword:
                case thisKeyword:
                case throwKeyword:
                case trueKeyword:
                case tryKeyword:
                case usingKeyword:
                case whileKeyword:

                case ImplicitArgumentOperator:
                case ImplicitArgumentsOperator:

                case FunctionOperator:
                case InteropOperator:
                case LoadLibraryOperator:
                case LoadScriptOperator:
                case PatternMatchingOperator:

                    return SystemColor.DodgerBlue;

                case AdditionOperator:
                case AggregateOperator:
                case AndOperator:
                case AnyOperator:
                case AssignmentOperator:
                case BinaryAndEqualOperator:
                case BinaryAndOperator:
                case BinaryOrOperator:
                case ColonOperator:
                case ComplementOperator:
                case ConditionalOperator:
                case DecrementOperator:
                case DistinctOperator:
                case DivisionEqualOperator:
                case DivisionOperator:
                case EqualityOperator:
                case GreaterThanOperator:
                case GreaterThanOrEqualOperator:
                case IncrementOperator:
                case LessThanOperator:
                case LessThanOrEqualOperator:
                case MinusEqualOperator:
                case MinusOperator:
                case ModulusEqualOperator:
                case ModulusOperator:
                case MultiplicationEqualOperator:
                case MultiplicationOperator:
                case NotEqualOperator:
                case NotOperator:
                case OrEqualOperator:
                case OrOperator:
                case PipelineOperator:
                case PlusEqualOperator:
                case RangeOperator:
                case SelectManyOperator:
                case SelectOperator:
                case ShiftLeftEqualOperator:
                case ShiftRightEqualOperator:
                case WhereOperator:
                case XorEqualOperator:
                case XorOperator:
                    return SystemColor.Silver;

                case LeftBrace:
                case RightBrace:
                case LeftBracket:
                case RightBracket:
                    return SystemColor.LightGray;

                case MemberOperator:
                    return SystemColor.White;

                case RightParenthesis:
                case LeftParenthesis:
                    return SystemColor.LightGray;

                case Comment:
                    return SystemColor.DarkGreen;

                default:
                    return SystemColor.White;
            }
        }
    }
}
