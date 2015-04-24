using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public class NullExpression : AphidExpression
    {
        public override AphidNodeType Type
        {
            get { return AphidNodeType.NullExpression; }
        }
    }
}
