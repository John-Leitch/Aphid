using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LLex
{
    public abstract class RegexExpression : RegexNode
    {
        public RegexTokenType Quantifier { get; set; }

        public override string ToString()
        {
            return Quantifier == RegexTokenType.None ? "" :
                Quantifier == RegexTokenType.OneOrMoreQuantifier ? "+" :
                Quantifier == RegexTokenType.ZeroOrMoreQuantifier ? "*" :
                Quantifier == RegexTokenType.ZeroOrOneQuantifier ? "?" :
                "[Error]";
        }
    }
}
