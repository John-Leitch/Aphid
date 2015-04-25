using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public partial class IdentifierExpression : AphidExpression, IParentNode
    {
        public override string ToString()
        {
            return Identifier;
        }
    }
}
