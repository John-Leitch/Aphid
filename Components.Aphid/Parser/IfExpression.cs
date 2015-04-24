using System;
using System.Linq;
using System.Collections.Generic;
using Components.Aphid.Lexer;

namespace Components.Aphid.Parser
{
    public class IfExpression : ControlFlowExpression, IParentNode
    {
        public override AphidNodeType Type
        {
            get { return AphidNodeType.IfExpression; }
        }

        public List<AphidExpression> ElseBody { get; set; }

        public IfExpression(AphidExpression condition, List<AphidExpression> body, List<AphidExpression> elseBody)
            : base(AphidTokenType.ifKeyword, condition, body)
        {
            ElseBody = elseBody;
        }

        public override IEnumerable<AphidExpression> GetChildren()
        {
            return base.GetChildren().Concat(ElseBody);
        }        
    }
}

