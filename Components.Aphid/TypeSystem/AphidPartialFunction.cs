using Components.Aphid.Parser;

namespace Components.Aphid.TypeSystem
{
    public class AphidPartialFunction : IAphidCallable
    {
        //public AphidExpression Expression { get; }

        public AphidFunction Function { get; }

        public AphidObject[] Applied { get; }

        public AphidPartialFunction(
            //AphidExpression expression,
            AphidFunction function,
            AphidObject[] applied)
        {
            //Expression = expression;
            Function = function;
            Applied = applied;
        }
    }
}
