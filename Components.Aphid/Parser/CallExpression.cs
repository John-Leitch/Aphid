using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Components.Aphid.Parser
{
    public partial class CallExpression : AphidExpression, IParentNode
    {
        public CallExpression(AphidExpression functionExpression, AphidExpression expression)
            : this(functionExpression, new List<AphidExpression> { expression })
        {

        }

        public override string ToString()
        {
            return string.Format("{0}({1})", FunctionExpression, Args.Select(x => x.ToString()).DefaultIfEmpty().Aggregate((x, y) => x + ", " + y));
        }        
    }
}
