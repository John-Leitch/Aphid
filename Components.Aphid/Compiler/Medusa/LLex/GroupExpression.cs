using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LLex
{
    public class GroupExpression : RegexExpression
    {
        public RegexExpression Expression { get; private set; }

        public GroupExpression(RegexExpression expression)
        {
            Expression = expression;
        }

        public override string ToString()
        {
            return string.Format("({0}){1}", Expression, base.ToString());
        }
    }
}
