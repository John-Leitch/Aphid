using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxelder
{
    public class UnaryExpressionMutator : AphidMutator
    {
        private Dictionary<AphidTokenType, AphidTokenType> _operatorTable = new Dictionary<AphidTokenType,AphidTokenType>
        {
            { AphidTokenType.IncrementOperator, AphidTokenType.AdditionOperator },
            { AphidTokenType.DecrementOperator, AphidTokenType.MinusOperator },            
        };

        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            hasChanged = false;
            
            if (expression.Type != AphidExpressionType.UnaryOperatorExpression)
            {
                return null;
            }
            
            var unOpExp = expression.ToUnaryOperator();

            if (!unOpExp.IsPostfix)
            {
                return null;
            }


            if (!_operatorTable.TryGetValue(unOpExp.Operator, out var op))
            {
                return null;
            }

            hasChanged = true;

            return new List<AphidExpression>
            {
                new BinaryOperatorExpression(
                    unOpExp.Operand, 
                    AphidTokenType.AssignmentOperator,
                    new BinaryOperatorExpression(
                        unOpExp.Operand,
                        op,
                        new NumberExpression(1)))
            };
        }
    }
}
