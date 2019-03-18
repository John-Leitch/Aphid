using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using System.Collections.Generic;

namespace Components.Aphid.Serialization
{
    public class AphidObjectThisKeywordMutator : AphidMutator
    {
        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            if (expression.Type != AphidExpressionType.ThisExpression &&
                (expression.Type != AphidExpressionType.IdentifierExpression ||
                    expression.ToIdentifier().Identifier != "this"))
            {
                hasChanged = false;

                return null;
            }

            hasChanged = true;

            return new List<AphidExpression> { new IdentifierExpression(AphidSerializer.Root) };
        }
    }
}
