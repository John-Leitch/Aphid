using Components.Aphid.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Parser
{
    public class UnaryOperatorExpression : AphidExpression, IParentNode
    {
        public override AphidExpressionType Type
        {
            get { return AphidExpressionType.UnaryOperatorExpression; }
        }

        public AphidTokenType Operator { get; set; }

        public AphidExpression Operand { get; set; }

        public bool IsPostfix { get; set; }

        public UnaryOperatorExpression(AphidTokenType op, AphidExpression operand)
        {
            Operator = op;
            Operand = operand;
        }

        public UnaryOperatorExpression(AphidTokenType op, AphidExpression operand, bool isPostfix)
        {
            Operator = op;
            Operand = operand;
            IsPostfix = isPostfix;
        }

        public override string ToString ()
        {
            return IsPostfix ? 
                string.Format ("{0} {1}", Operand, Operator) :
                    string.Format ("{0} {1}", Operator, Operand);
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new[] { Operand };
        }
    }
}
