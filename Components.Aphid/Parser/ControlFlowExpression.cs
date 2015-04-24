using Components.Aphid.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Parser
{
    public abstract class ControlFlowExpression : AphidExpression, IParentNode
    {
        public AphidTokenType ControlFlowType { get; set; }

        public AphidExpression Condition { get; set; }

        public List<AphidExpression> Body { get; set; }

        public ControlFlowExpression(AphidTokenType type, AphidExpression condition, List<AphidExpression> body)
        {
            ControlFlowType = type;
            Condition = condition;
            Body = body;
        }

        public virtual IEnumerable<AphidExpression> GetChildren()
        {
            return new[] { Condition }.Concat(Body);
        }
    }
}
