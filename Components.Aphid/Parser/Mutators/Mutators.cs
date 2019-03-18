namespace Components.Aphid.Parser
{
    public static class Mutators
    {
        public static AphidMutator[] GetMinimal() => new AphidMutator[]
        {
            new PartialOperatorMutator(),
            new AphidMacroMutator(),
            new AphidPreprocessorDirectiveMutator()
        };

        public static AphidMutator[] GetStandard() => new AphidMutator[]
        {
                new PartialOperatorMutator(),
                new AphidMacroMutator(),
                new AphidPreprocessorDirectiveMutator(),
                new ConstantFoldingMutator()
        };

        public static AphidMutator[] GetOptimizing() => new AphidMutator[]
        {
                new PartialOperatorMutator(),
                new AphidMacroMutator(),
                new AphidPreprocessorDirectiveMutator(),
                new IncludeMutator(),
                new ConstantFoldingMutator()
        };
    }
}
