using Components.Aphid.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public class TernaryOperatorExpression : AphidExpression, IParentNode
    {
        public override AphidExpressionType Type
        {
            get { return AphidExpressionType.TernaryOperatorExpression; }
        }

        public AphidTokenType Operator { get; set; }

        public AphidExpression FirstOperand { get; set; }

        public AphidExpression SecondOperand { get; set; }

        public AphidExpression ThirdOperand { get; set; }

        public TernaryOperatorExpression(
            AphidTokenType op,
            AphidExpression firstOperand,
            AphidExpression secondOperand,
            AphidExpression thirdOperand)
        {
            Operator = op;
            FirstOperand = firstOperand;
            SecondOperand = secondOperand;
            ThirdOperand = thirdOperand;
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new[] { FirstOperand, SecondOperand, ThirdOperand };
        }
    }
}
