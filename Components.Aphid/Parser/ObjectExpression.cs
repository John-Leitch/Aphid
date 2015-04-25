using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Parser
{
    public class ObjectExpression : AphidExpression, IParentNode
    {
        public override AphidExpressionType Type
        {
            get { return AphidExpressionType.ObjectExpression; }
        }

        public List<BinaryOperatorExpression> Pairs { get; set; }

        public ObjectExpression()
        {
        }

        public ObjectExpression(List<BinaryOperatorExpression> pairs)
        {
            Pairs = pairs;
        }

        public override string ToString()
        {
            return string.Format(
                "{{ {0} }}",
                Pairs
                    .DefaultIfEmpty()
                    .Select(x => x.ToString())
                    .Aggregate((x, y) => x + ", " + y));
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return Pairs;
        }
    }
}
