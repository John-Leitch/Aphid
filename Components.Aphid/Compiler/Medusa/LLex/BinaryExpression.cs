namespace LLex
{
    public class BinaryExpression : RegexExpression
    {
        public RegexExpression Left { get; }

        public RegexTokenType Operator { get; }

        public RegexExpression Right { get; }

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
