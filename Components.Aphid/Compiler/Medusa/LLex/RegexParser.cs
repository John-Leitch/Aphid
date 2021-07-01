﻿using System;
using System.Collections.Generic;

namespace LLex
{
    /*
     * exp-seq  -> exp, { conj exp | exp }
     * conj     -> "|"
     * exp      -> char, quant 
     *          | "(", exp-seq, ")", quant 
     *          | "[", set, "]", quant
     * quant    -> ""
     *          | "?"
     *          | "+"
     *          | "*"
     * set      -> setObj, { setObj }
     * setObj   -> char
     *          | char, "-", char
     * char     -> literalChar
     *          | "\u", hexChar, hexChar, hexChar, hexChar,
     *          | "\x", hexChar, hexChar
     */
    public partial class RegexParser
    {
        private readonly RegexToken[] _tokens;

        private readonly List<RegexToken> _expressionTokens = new();

        private int _tokenIndex = -1;

        private RegexToken _currentToken;

        public RegexParser(RegexToken[] tokens) => _tokens = tokens;

        private bool Match(RegexTokenType tokenType)
        {
            if (_currentToken.TokenType == tokenType)
            {
                NextToken();
                return true;
            }

            return false;
        }

        private bool NextToken()
        {
            _tokenIndex++;

            if (_tokenIndex < _tokens.Length)
            {
                _currentToken = _tokens[_tokenIndex];
                return true;
            }

            _currentToken = default;

            return false;
        }

        private RegexExpression Char()
        {
            switch (_currentToken.Lexeme.Length)
            {
                case 1:
                    var c = _currentToken.Lexeme[0];
                    Match(RegexTokenType.Character);
                    return new CharExpression(c);
                case 2:
                    if (_currentToken.TokenType == RegexTokenType.Character)
                    {
                        var c2 = _currentToken.Lexeme[1];
                        Match(RegexTokenType.Character);
                        return new CharExpression(c2);
                    }
                    else if (_currentToken.TokenType == RegexTokenType.SpecialCharacter)
                    {
                        var c3 = _currentToken.Lexeme[1] == 's' ?
                            ' ' :
                            System.Text.RegularExpressions.Regex.Unescape(_currentToken.Lexeme)[0];
                        Match(RegexTokenType.SpecialCharacter);
                        return new CharExpression(c3);
                    }
                    else
                    {
                        throw new InvalidOperationException();
                    }

                default:
                    return null;
            }
        }

        private RegexTokenType Quantifier()
        {
            if (_currentToken.Lexeme != null &&
                (_currentToken.TokenType == RegexTokenType.OneOrMoreQuantifier ||
                _currentToken.TokenType == RegexTokenType.ZeroOrOneQuantifier ||
                _currentToken.TokenType == RegexTokenType.ZeroOrMoreQuantifier))
            {
                var t = _currentToken.TokenType;
                NextToken();
                return t;
            }

            return RegexTokenType.None;
        }

        private RegexExpression Expression()
        {
            RegexExpression exp = null;
            switch (_currentToken.TokenType)
            {
                case RegexTokenType.LeftParenthesis:
                    Match(RegexTokenType.LeftParenthesis);
                    var statement = ExpressionSeq();
                    Match(RegexTokenType.RightParenthesis);
                    exp = new GroupExpression(statement);
                    break;
                default:
                    exp = Char();
                    break;
            }

            exp.Quantifier = Quantifier();

            return exp;
        }

        private RegexExpression ExpressionSeq()
        {
            var expressionStack = new Stack<RegexExpression>();

            while (true)
            {
                if (_currentToken.Lexeme == null ||
                    _currentToken.TokenType == RegexTokenType.RightParenthesis ||
                    _currentToken.TokenType == RegexTokenType.RightBracket)
                {
                    break;
                }
                else if (expressionStack.Count > 0)
                {
                    var opType = RegexTokenType.None;
                    if (_currentToken.TokenType == RegexTokenType.OrOperator)
                    {
                        opType = RegexTokenType.OrOperator;
                        NextToken();
                    }

                    expressionStack.Push(new OperatorExpression(opType));
                }

                expressionStack.Push(Expression());
            }

            var lastExp = expressionStack.Pop();

            while (expressionStack.Count > 0)
            {
                var op = expressionStack.Pop() as OperatorExpression;
                lastExp = new BinaryExpression(expressionStack.Pop(), op.Type, lastExp);
            }

            return lastExp;
        }

        public RegexExpression Parse()
        {
            NextToken();
            return ExpressionSeq();
        }
    }
}
