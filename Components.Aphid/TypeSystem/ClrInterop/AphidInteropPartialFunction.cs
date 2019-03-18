namespace Components.Aphid.TypeSystem
{
    public class AphidInteropPartialFunction : IAphidCallable
    {
        public AphidInteropMember Member { get; }

        public object[] Applied { get; }

        public AphidInteropPartialFunction(AphidInteropMember member, object[] applied)
        {
            Member = member;
            Applied = applied;
        }
    }
}
