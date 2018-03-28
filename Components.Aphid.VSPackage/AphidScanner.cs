using Components.Aphid.Lexer;
using Microsoft.VisualStudio.Package;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                case AphidTokenType.Number:
                case AphidTokenType.HexNumber:
                case AphidTokenType.BinaryNumber:
                    tokenInfo.Type = TokenType.Literal;
                    tokenInfo.Color = TokenColor.Number;
                    break;

                case AphidTokenType.Identifier:
                    if (_tokens.Length != _index &&
                        _tokens[_index].TokenType == AphidTokenType.Identifier)
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

                    tokenInfo.Type = TokenType.Keyword;
                    tokenInfo.Color = TokenColor.Keyword;
                    break;

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
                    tokenInfo.Type = TokenType.Operator;                    
                    break;

                case AphidTokenType.LeftBrace:
                case AphidTokenType.RightBrace:
                case AphidTokenType.LeftBracket:
                case AphidTokenType.RightBracket:
                    tokenInfo.Trigger = TokenTriggers.MatchBraces;                    
                    break;

                case AphidTokenType.MemberOperator:
                    tokenInfo.Trigger = TokenTriggers.MemberSelect;
                    tokenInfo.Type = TokenType.Delimiter;                    
                    break;

                case AphidTokenType.LeftParenthesis:
                    tokenInfo.Trigger = TokenTriggers.MatchBraces;                    
                    //tokenInfo.Trigger = TokenTriggers.ParameterStart;
                    break;

                case AphidTokenType.RightParenthesis:
                    tokenInfo.Trigger = TokenTriggers.MatchBraces;                    
                    //tokenInfo.Trigger = TokenTriggers.ParameterEnd;
                    break;

                case AphidTokenType.Comment:
                    tokenInfo.Type = TokenType.Comment;
                    tokenInfo.Color = TokenColor.Comment;
                    break;

                default:
                    tokenInfo.Trigger = TokenTriggers.MemberSelect;
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
                    .Where(x => x.TokenType != AphidTokenType.WhiteSpace)
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
