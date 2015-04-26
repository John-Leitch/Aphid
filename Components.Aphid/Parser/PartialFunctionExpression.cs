using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public partial class PartialFunctionExpression : AphidExpression, IParentNode
    {
        public PartialFunctionExpression(AphidExpression call)
            : this ((CallExpression)call)
        {
        }
    }
}
