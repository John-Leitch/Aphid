using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Parser
{
    public class MemberExpression : AphidExpression, IParentNode
    {
        public override AphidNodeType Type
        {
            get { return AphidNodeType.MemberExpression; }
        }

        public IdentifierExpression Variable { get; set; }

        public List<IdentifierExpression> Members { get; set; }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new[] { Variable }.Concat(Members);
        }
    }
}
