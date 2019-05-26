using Components.Aphid.Parser;
using System.Collections.Generic;
using System.Linq;

namespace Components.Aphid.Wpf
{
    public class AphidBindingScriptMutator : AphidMutator
    {
        private Dictionary<IdentifierExpression, AphidExpression[]> _aliases;
        private Dictionary<AphidExpression, IdentifierExpression> _aliasesFlipped;

        public AphidBindingScriptMutator(Dictionary<IdentifierExpression, AphidExpression[]> aliases)
        {
            _aliases = aliases;

            _aliasesFlipped = _aliases
                .SelectMany(x => x.Value
                    .Select(y =>
                        new KeyValuePair<AphidExpression, IdentifierExpression>(y, x.Key)))
                .ToDictionary();
        }

        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            if (!_aliasesFlipped.TryGetValue(expression, out var id))
            {
                hasChanged = false;
                return null;
            }

            hasChanged = true;

            return new List<AphidExpression> { id };
        }
    }
}
