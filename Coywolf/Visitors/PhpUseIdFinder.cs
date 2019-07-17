using Components.Aphid.Parser;
using System.Collections.Generic;

namespace Coywolf.Visitors
{
    public class PhpUseIdFinder : ExpressionFinder
    {
        public List<AphidExpression> Find(List<AphidExpression> source) => Find(source, AphidExpressionType.IdentifierExpression);

        protected override IEnumerable<AphidExpression> GetChildren(IParentNode parent)
        {
            var callExp = parent as FunctionExpression;

            if (callExp == null)
            {
                return base.GetChildren(parent);
            }
            else
            {
                return callExp.Body;
            }
        }
    }
}
