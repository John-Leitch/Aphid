namespace Components.Aphid.Parser
{
    public partial class PartialFunctionExpression : AphidExpression, IParentNode
    {
        internal PartialFunctionExpression(
            AphidExpressionContext context,
            AphidExpression call)
            : this(context, (CallExpression)call)
        {
        }

        public PartialFunctionExpression(AphidExpression call)
            : this ((CallExpression)call)
        {
        }
    }
}
