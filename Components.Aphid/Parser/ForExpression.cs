using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public class ForExpression : AphidExpression, IParentNode
    {
        public override AphidExpressionType Type
        {
            get { return AphidExpressionType.ForExpression; }
        }

        public AphidExpression Initialization { get; set; }

        public AphidExpression Condition { get; set; }

        public AphidExpression Afterthought { get; set; }

        public List<AphidExpression> Body { get; set; }

        public ForExpression(
            AphidExpression initialization,
            AphidExpression condition,
            AphidExpression afterthought,
            List<AphidExpression> body)
        {
            Initialization = initialization;
            Condition = condition;
            Afterthought = afterthought;
            Body = body;
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new[] { Initialization, Condition, Afterthought }.Concat(Body);
        }
    }
}
