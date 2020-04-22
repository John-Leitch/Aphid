namespace Components.Aphid.TypeSystem
{
    public class AphidPartialComposition : IAphidCallable
    {
        public AphidFunctionComposition Composition { get; }

        public object[] Applied { get; }

        public AphidPartialComposition(AphidFunctionComposition composition, object[] applied)
        {
            Composition = composition;
            Applied = applied;
        }
    }
}
