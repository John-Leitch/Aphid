using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AphidHdl
{
    public class NumberToStringMutator : AphidMutator
    {
        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            if (expression.Type != AphidExpressionType.NumberExpression)
            {
                hasChanged = false;

                return null;
            }

            hasChanged = true;
            var numExp = (NumberExpression)expression;

            return new List<AphidExpression> { new StringExpression(string.Format("'{0}'", numExp.Value)) };
        }
    }
}
