using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public class PartialFunctionExpression : AphidExpression, IParentNode
    {
        public override AphidExpressionType Type
        {
            get { return AphidExpressionType.PartialFunctionExpression; }
        }

        public CallExpression Call { get; set; }

        public PartialFunctionExpression()
        {
        }

        public PartialFunctionExpression(CallExpression call)
        {
            Call = call;
        }

        public PartialFunctionExpression(AphidExpression call)
            : this ((CallExpression)call)
        {
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new[] { Call };
        }
    }
}
