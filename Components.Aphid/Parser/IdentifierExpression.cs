using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public class IdentifierExpression : AphidExpression, IParentNode
    {
        public override AphidNodeType Type
        {
            get { return AphidNodeType.IdentifierExpression; }
        }

        public List<IdentifierExpression> Attributes { get; set; }

        public string Identifier { get; set; }

        public IdentifierExpression(string identifier, List<IdentifierExpression> attributes)
        {
            Identifier = identifier;
            Attributes = attributes;
        }

        public IdentifierExpression(string identifier)
            : this(identifier, new List<IdentifierExpression>())
        {

        }

        public override string ToString()
        {
            return Identifier;
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return Attributes;
        }

        public bool HasAttribute(string attribute)
        {
            return Attributes.Any(x => x.Identifier == attribute);
        }
    }
}
