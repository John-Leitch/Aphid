using Group = Components.Aphid.Parser.AphidMutatorGroup;

namespace Components.Aphid.Parser
{
    public static class MutatorGroups
    {
        public static Group GetMinimal() => new(Mutators.GetMinimal());
        public static Group GetStandard() => new(Mutators.GetStandard());
        public static Group GetOptimizing() => new(Mutators.GetOptimizing());
    }
}
