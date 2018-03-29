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
            var highlights = AphidLexer
                .GetAllTokens(text)
                .Select(x => new ColoredText(GetColor(x.TokenType), x.Lexeme));

            return highlights;
        }

        private byte[] GetColor(AphidTokenType type)
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
                    return SystemColor.CadetBlue;

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
                case AphidTokenType.newKeyword:
                case AphidTokenType.nullKeyword:
                case AphidTokenType.retKeyword:
                case AphidTokenType.switchKeyword:
                case AphidTokenType.thisKeyword:
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
