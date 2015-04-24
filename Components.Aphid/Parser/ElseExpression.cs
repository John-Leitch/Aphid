using System;
using System.Collections.Generic;

namespace Components.Aphid.Parser
{
    public class ElseExpression : IParentNode
    {
        public List<AphidExpression> Body { get; set; }

        public ElseExpression()
        {
        }

        public ElseExpression(List<AphidExpression> body)
        {
            Body = body;
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return Body;
        }
    }
}

