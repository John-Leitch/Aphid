using Components.Aphid.Parser;

namespace Components.Aphid.TypeSystem
{
    public class AphidFunctionComposition : IAphidCallable
    {
        public AphidExpression LeftExpression { get; }

        public AphidExpression RightExpression { get; }

        public object LeftFunction { get; }

        public object RightFunction { get; }

        public AphidFunctionComposition(
            AphidExpression leftExpression,
            AphidExpression rightExpression,
            object leftFunction, 
            object rightFunction)
        {
            LeftExpression = leftExpression;
            RightExpression = rightExpression;
            LeftFunction = leftFunction;
            RightFunction = rightFunction;
        }
    }
}
