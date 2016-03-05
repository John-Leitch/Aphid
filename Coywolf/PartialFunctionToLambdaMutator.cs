using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coywolf
{
    public class PartialFunctionToLambdaMutator : AphidMutator
    {
        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            if (expression.Type != AphidExpressionType.PartialFunctionExpression)
            {
                hasChanged = false;

                return null;
            }
            else
            {
                hasChanged = true;



                return null;
            }
        }
    }
}
