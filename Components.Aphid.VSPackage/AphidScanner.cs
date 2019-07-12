using Components.Aphid.Lexer;
using Microsoft.VisualStudio.Package;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Components.Aphid.Lexer.AphidTokenType;

namespace Components.Aphid.VSPackage
{
    public class AphidScanner : IScanner
    {
        private int _index, _lexerMode;
        private AphidToken[] _tokens;

        public bool ScanTokenAndProvideInfoAboutIt(TokenInfo tokenInfo, ref int state)
        {
            if (_tokens.Length <= _index)
            {
                state = -1;
                return false;
            }

            state++;

            var t = _tokens[_index++];
            tokenInfo.StartIndex = t.Index;
            tokenInfo.EndIndex = t.Index + t.Lexeme.Length - 1;
            tokenInfo.Type = TokenType.Text;
            tokenInfo.Color = TokenColor.Text;            

            switch (t.TokenType)
            {
                case AphidTokenType.String:
                    tokenInfo.Type = TokenType.String;
                    tokenInfo.Color = TokenColor.String;
                    break;

                case Number:
                case HexNumber:
                case BinaryNumber:
                    tokenInfo.Type = TokenType.Literal;
                    tokenInfo.Color = TokenColor.Number;
                    break;

                case Identifier:
                    if (_tokens.Length != _index &&
                        _tokens[_index].TokenType == Identifier)
                    {
                        tokenInfo.Type = TokenType.Keyword;
                        tokenInfo.Color = TokenColor.Keyword;
                    }
                    else
                    {
                        tokenInfo.Type = TokenType.Identifier;
                        tokenInfo.Color = TokenColor.Identifier;
                    }
                    break;
                // AphidTokenType |> Enum.GetValues-?(@()$_.ToString().EndsWith('Keyword'))->@format('case AphidTokenType.{0}:') @join('\r\n') |> print
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

                    tokenInfo.Type = TokenType.Keyword;
                    tokenInfo.Color = TokenColor.Keyword;
                    break;

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
                    tokenInfo.Type = TokenType.Operator;                    
                    break;

                case LeftBrace:
                case RightBrace:
                case LeftBracket:
                case RightBracket:
                    tokenInfo.Trigger = TokenTriggers.MatchBraces;                    
                    break;

                case MemberOperator:
                    tokenInfo.Trigger = TokenTriggers.MemberSelect;
                    tokenInfo.Type = TokenType.Delimiter;                    
                    break;

                case LeftParenthesis:
                    tokenInfo.Trigger = TokenTriggers.MatchBraces;                    
                    //tokenInfo.Trigger = TokenTriggers.ParameterStart;
                    break;

                case RightParenthesis:
                    tokenInfo.Trigger = TokenTriggers.MatchBraces;                    
                    //tokenInfo.Trigger = TokenTriggers.ParameterEnd;
                    break;

                case Comment:
                    tokenInfo.Type = TokenType.Comment;
                    tokenInfo.Color = TokenColor.Comment;
                    break;

                default:
                    //tokenInfo.Trigger = TokenTriggers.MemberSelect;
                    break;
            }

            return true;
        }

        public void SetSource(string source, int offset)
        {
           _index = 0;
            try
            {
                var lexer = new AphidLexer(source);

                if (_lexerMode != 0)
                {
                    lexer.SetMode(_lexerMode);
                }

                _tokens = lexer
                    .GetAllTokens()
                    .Where(x => x.TokenType != WhiteSpace)
                    .ToArray();

                _lexerMode = lexer.GetMode();
            }
            catch
            {
                _tokens = new AphidToken[0];
            }
        }
    }
}
