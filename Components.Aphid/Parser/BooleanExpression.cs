using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Parser
{
    public class BooleanExpression : AphidExpression
    {
        public override AphidNodeType Type
        {
            get { return AphidNodeType.BooleanExpression; }
        }

        public bool Value { get; set; }

        public BooleanExpression()
        {
        }

        public BooleanExpression(bool value)
        {
            Value = value;
        }
    }
}
