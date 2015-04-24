using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LLex
{
    public class BinaryExpression : RegexExpression
    {
        public RegexExpression Left { get; private set; }

        public RegexTokenType Operator { get; private set; }

        public RegexExpression Right { get; private set; }

        public BinaryExpression(RegexExpression left, RegexTokenType op, RegexExpression right)
        {
            Left = left;
            Operator = op;
            Right = right;
        }

        public override string ToString()
        {
            var op = Operator == RegexTokenType.OrOperator ? "|" : "";

            return string.Format("{0}{1}{2}", Left, op, Right);
        }
    }
}
