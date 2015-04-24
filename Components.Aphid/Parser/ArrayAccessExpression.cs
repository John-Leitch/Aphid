using System;
using System.Collections.Generic;

namespace Components.Aphid.Parser
{
    public class ArrayAccessExpression : AphidExpression, IParentNode
    {
        public override AphidNodeType Type
        {
            get { return AphidNodeType.ArrayAccessExpression; }
        }

        public AphidExpression ArrayExpression { get; set; }

        public AphidExpression KeyExpression { get; set; }

        public ArrayAccessExpression ()
        {
        }

        public ArrayAccessExpression(AphidExpression arrayExpression, AphidExpression keyExpression)
        {
            ArrayExpression = arrayExpression;
            KeyExpression = keyExpression;
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new[] { ArrayExpression, KeyExpression };
        }        
    }
}

