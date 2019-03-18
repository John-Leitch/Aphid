using System.Collections.Generic;

namespace Components.Aphid.Parser
{
    public partial class CallExpression : AphidExpression, IParentNode
    {
        public CallExpression(AphidExpression functionExpression, AphidExpression expression)
            : this(functionExpression, new List<AphidExpression> { expression })
        {
        }
    }
}
