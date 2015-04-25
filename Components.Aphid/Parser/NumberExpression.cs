using System;

namespace Components.Aphid.Parser
{
    public partial class NumberExpression : AphidExpression
    {
        public override string ToString ()
        {
            return Value.ToString ();
        }
    }
}

