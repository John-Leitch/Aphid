using Components.Aphid.Parser;
using System.Collections.Generic;

namespace Coywolf.Visitors
{
    public class PhpUseIdFinder : ExpressionFinder
    {
        public List<AphidExpression> Find(List<AphidExpression> source) => Find(source, AphidExpressionType.IdentifierExpression);

        protected override IEnumerable<AphidExpression> GetChildren(IParentNode parent)
        {
            if (parent is not FunctionExpression callExp)
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
