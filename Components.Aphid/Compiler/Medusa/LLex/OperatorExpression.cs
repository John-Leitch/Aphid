namespace LLex
{
    public class OperatorExpression : RegexExpression
    {
        public RegexTokenType Type { get; }

        public OperatorExpression(RegexTokenType type) => Type = type;
    }
}
