using System;

namespace Components.Aphid.Parser
{
    public class NumberExpression : AphidExpression
    {
        public override AphidNodeType Type
        {
            get { return AphidNodeType.NumberExpression; }
        }

        public decimal Value { get; set; }

        public NumberExpression(decimal value)
        {
            Value = value;
        }

        public override string ToString ()
        {
            return Value.ToString ();
        }
    }
}

