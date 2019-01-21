using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LLex
{
    public class GroupExpression : RegexExpression
    {
        public RegexExpression Expression { get; }

        public GroupExpression(RegexExpression expression) =>
            Expression = expression;

        public override string ToString() =>
            $"({Expression}){base.ToString()}";
    }
}
