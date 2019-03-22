namespace LLex
{
    public abstract class RegexExpression : RegexNode
    {
        public RegexTokenType Quantifier { get; set; }

        public override string ToString() => Quantifier == RegexTokenType.None ? "" :
                Quantifier == RegexTokenType.OneOrMoreQuantifier ? "+" :
                Quantifier == RegexTokenType.ZeroOrMoreQuantifier ? "*" :
                Quantifier == RegexTokenType.ZeroOrOneQuantifier ? "?" :
                "[Error]";
    }
}
