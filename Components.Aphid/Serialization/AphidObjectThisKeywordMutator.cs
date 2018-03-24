using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
