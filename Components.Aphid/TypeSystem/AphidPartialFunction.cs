namespace Components.Aphid.TypeSystem
{
    public class AphidPartialFunction : IAphidCallable
    {
        public AphidFunction Function { get; }

        public AphidObject[] Applied { get; }

        public AphidPartialFunction(AphidFunction function, AphidObject[] applied)
        {
            Function = function;
            Applied = applied;
        }
    }
}
