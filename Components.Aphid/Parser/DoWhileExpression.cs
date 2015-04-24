using Components.Aphid.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public class DoWhileExpression : ControlFlowExpression
    {
        public override AphidNodeType Type
        {
            get { return AphidNodeType.DoWhileExpression; }
        }

        public DoWhileExpression(AphidExpression condition, List<AphidExpression> body)
            : base(AphidTokenType.doKeyword, condition, body)
        {
        }
    }
}
