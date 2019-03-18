using Group = Components.Aphid.Parser.AphidMutatorGroup;

namespace Components.Aphid.Parser
{
    public static class MutatorGroups
    {
        public static Group GetMinimal() => new Group(Mutators.GetMinimal());
        public static Group GetStandard() => new Group(Mutators.GetStandard());
        public static Group GetOptimizing() => new Group(Mutators.GetOptimizing());
    }
}
