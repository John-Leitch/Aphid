using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public class PatternExpression : AphidExpression, IParentNode
    {
        public override AphidExpressionType Type
        {
            get { return AphidExpressionType.PatternExpression; }
        }

        public List<AphidExpression> Patterns { get; private set; }

        public AphidExpression Value { get; private set; }

        public PatternExpression(List<AphidExpression> patterns, AphidExpression value)
        {
            Patterns = patterns;
            Value = value;
        }

        public PatternExpression(AphidExpression value)
            : this(null, value)
        {
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return Patterns.Concat(new[] { Value });
        }
    }
}
