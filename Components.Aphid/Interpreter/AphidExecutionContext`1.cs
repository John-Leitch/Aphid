namespace Components.Aphid.Interpreter
{
    public class AphidExecutionContext<TExpression> : AphidExecutionContext
    {
        public TExpression Expression { get; set; }

        public AphidExecutionContext(TExpression expression)
            : base() => Expression = expression;

        public AphidExecutionContext(TExpression expression, bool isModified, bool isHandled)
            : base(isModified, isHandled) => Expression = expression;

        public static implicit operator AphidExecutionContext<TExpression>(TExpression expression) => new AphidExecutionContext<TExpression>(expression);
    }
}
