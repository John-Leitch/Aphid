using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public class AphidMacroBodyMutator : AphidMutator
    {
        private Dictionary<string, AphidExpression> _arguments;

        public AphidMacroBodyMutator(Dictionary<string, AphidExpression> arguments)
        {
            _arguments = arguments;
        }

        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            var idExp = expression as IdentifierExpression;

            AphidExpression argument;

            if (idExp == null || !_arguments.TryGetValue(idExp.Identifier, out argument))
            {
                hasChanged = false;

                return null;
            }

            hasChanged = true;

            return new List<AphidExpression> { argument };
        }
    }
}
