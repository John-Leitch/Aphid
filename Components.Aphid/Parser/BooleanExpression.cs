using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Parser
{
    public class BooleanExpression : AphidExpression
    {
        public override AphidExpressionType Type
        {
            get { return AphidExpressionType.BooleanExpression; }
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
