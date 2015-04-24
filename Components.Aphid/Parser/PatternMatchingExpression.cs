using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public class PatternMatchingExpression : AphidExpression, IParentNode
    {
        public override AphidNodeType Type
        {
            get { return AphidNodeType.PatternMatchingExpression; }
        }

        public AphidExpression TestExpression { get; set; }

        public List<PatternExpression> Patterns { get; set; }

        public PatternMatchingExpression(AphidExpression testExpression, List<PatternExpression> patterns)
        {
            TestExpression = testExpression;
            Patterns = patterns;
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new[] { TestExpression }.Concat(Patterns);
        }
    }
}
