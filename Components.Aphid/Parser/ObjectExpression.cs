using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Parser
{
    public partial class ObjectExpression : AphidExpression, IParentNode
    {
        public override string ToString()
        {
            return string.Format(
                "{{ {0} }}",
                Pairs
                    .DefaultIfEmpty()
                    .Select(x => x.ToString())
                    .Aggregate((x, y) => x + ", " + y));
        }
    }
}
