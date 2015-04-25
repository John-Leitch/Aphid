using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public class SwitchExpression : AphidExpression, IParentNode
    {
        public override AphidExpressionType Type
        {
            get { return AphidExpressionType.SwitchExpression; }
        }

        public AphidExpression Expression { get; set; }

        public List<SwitchCase> Cases { get; set; }

        public List<AphidExpression> DefaultCase { get; set; }

        public SwitchExpression()
        {
        }

        public SwitchExpression(AphidExpression expression, List<SwitchCase> cases, List<AphidExpression> defaultCase)
        {
            Expression = expression;
            Cases = cases;
            DefaultCase = defaultCase;
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new[] { Expression }
                .Concat(Cases.SelectMany(x => x.GetChildren()))
                .Concat(DefaultCase);
        }
    }
}
