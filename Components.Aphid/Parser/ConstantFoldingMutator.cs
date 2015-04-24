using Components.Aphid.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public class ConstantFoldingMutator : AphidMutator
    {
        private bool OperandsAre<T>(BinaryOperatorExpression binOp)
        {
            return binOp.LeftOperand.GetType() == typeof(T) &&
                binOp.RightOperand.GetType() == typeof(T);
        }

        private decimal GetNumber(AphidExpression exp)
        {
            return ((NumberExpression)exp).Value;
        }

        private string GetString(AphidExpression exp)
        {
            return ((StringExpression)exp).Value;
        }

        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            var binOp = expression as BinaryOperatorExpression;

            hasChanged = false;

            if (binOp == null)
            {
                return null;
            }

            hasChanged = true;

            if (OperandsAre<StringExpression>(binOp) &&
                binOp.Operator == AphidTokenType.AdditionOperator)
            {
                var left = GetString(binOp.LeftOperand);
                var right = GetString(binOp.RightOperand);

                return new List<AphidExpression> 
                { 
                    new StringExpression(
                        "'" + left.Substring(1, left.Length - 2).Replace("\\\"", "\"") + 
                        right.Substring(1, right.Length - 2).Replace("\\\"", "\"") + "'")
                };
            }
            else if (OperandsAre<NumberExpression>(binOp))
            {
                var left = GetNumber(binOp.LeftOperand);
                var right = GetNumber(binOp.RightOperand);

                switch (binOp.Operator)
                {
                    case AphidTokenType.AdditionOperator:
                        return new List<AphidExpression> { new NumberExpression(left + right) };

                    case AphidTokenType.MinusOperator:
                        return new List<AphidExpression> { new NumberExpression(left - right) };

                    default:
                        hasChanged = false;
                        break;
                }
            }
            else
            {
                hasChanged = false;
            }

            return null;
        }
    }
}
