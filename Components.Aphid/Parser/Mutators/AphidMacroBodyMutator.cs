using System.Collections.Generic;

namespace Components.Aphid.Parser
{
    public class AphidMacroBodyMutator : AphidMutator
    {
        protected Dictionary<string, AphidExpression> _arguments;

        public AphidMacroBodyMutator(Dictionary<string, AphidExpression> arguments) => _arguments = arguments;

        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            if (expression.Type != AphidExpressionType.IdentifierExpression ||
                !_arguments.TryGetValue(
                    ((IdentifierExpression)expression).Identifier,
                    out var argument))
            {
                hasChanged = false;

                return null;
            }

            hasChanged = true;

            return new List<AphidExpression> { argument };
        }
    }
}
