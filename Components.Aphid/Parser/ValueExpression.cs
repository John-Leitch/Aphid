using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public abstract class ValueExpression<TValue> : AphidExpression
    {
        public TValue Value { get; set; }

        public ValueExpression(TValue value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
