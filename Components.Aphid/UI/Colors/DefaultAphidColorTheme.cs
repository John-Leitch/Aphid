using Components.Aphid.Lexer;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Components.Aphid.Lexer.AphidTokenType;

namespace Components.Aphid.UI.Colors
{
    public class DefaultAphidColorTheme : IAphidColorTheme
    {
        public byte[] GetBackground() => SystemColor.Black;

        public ColoredText GetColoredText(in AphidToken token) =>
            GetColoredText(token, None);

        public ColoredText GetColoredText(in AphidToken token, AphidTokenType nextType) =>
            new ColoredText(GetColor(token.TokenType, nextType), token.Lexeme);

        public byte[] GetColor(AphidTokenType type) =>
            GetColor(type, None);

        public byte[] GetColor(AphidTokenType type, AphidTokenType nextType)
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
