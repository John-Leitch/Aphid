using System;
using System.Linq;
using System.Collections.Generic;

namespace Components.Aphid.Parser
{
    public class ForEachExpression : AphidExpression, IParentNode
    {
        public override AphidNodeType Type
        {
            get { return AphidNodeType.ForEachExpression; }
        }

        public AphidExpression Collection { get; set; }

        public AphidExpression Element { get; set; }

        public List<AphidExpression> Body { get; set; }

        public ForEachExpression (AphidExpression collection, AphidExpression element, List<AphidExpression> body)
        {
            Collection = collection;
            Element = element;
            Body = body;
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new[] { Collection, Element }.Concat(Body);
        }
    }
}

