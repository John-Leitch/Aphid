using Components.Aphid.Lexer;
using System.Collections.Generic;

namespace Components.Aphid.Parser
{
    public class ConstantFoldingMutator : AphidMutator
    {
        private static bool OperandsAre(BinaryOperatorExpression binOp, AphidExpressionType type) =>
            binOp.LeftOperand.Type == type && binOp.RightOperand.Type == type;

        private static decimal GetNumber(AphidExpression exp) => ((NumberExpression)exp).Value;

        private static string GetString(AphidExpression exp) => ((StringExpression)exp).Value;

        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            if (expression.Type != AphidExpressionType.BinaryOperatorExpression)
            {
                hasChanged = false;

                return null;
            }

            var binOp = (BinaryOperatorExpression)expression;            

            if (OperandsAre(binOp, AphidExpressionType.StringExpression) &&
                binOp.Operator == AphidTokenType.AdditionOperator)
            {
                hasChanged = true;
                var left = GetString(binOp.LeftOperand);
                var right = GetString(binOp.RightOperand);

                return new List<AphidExpression> 
                { 
                    new StringExpression(
                        "'" + left.Substring(1, left.Length - 2).Replace("\\\"", "\"") + 
                        right.Substring(1, right.Length - 2).Replace("\\\"", "\"") + "'")
                };
            }
            else if (OperandsAre(binOp, AphidExpressionType.NumberExpression))
            {
                var left = GetNumber(binOp.LeftOperand);
                var right = GetNumber(binOp.RightOperand);

                switch (binOp.Operator)
                {
                    case AphidTokenType.AdditionOperator:
                        hasChanged = true;

                        return new List<AphidExpression>
                        {
                            new NumberExpression(left + right)
                        };

                    case AphidTokenType.MinusOperator:
                        hasChanged = true;

                        return new List<AphidExpression>
                        {
                            new NumberExpression(left - right)
                        };

                    case AphidTokenType.MultiplicationOperator:
                        hasChanged = true;

                        return new List<AphidExpression>
                        {
                            new NumberExpression(left * right)
                        };

                    case AphidTokenType.DivisionOperator:
                        if (right != 0)
                        {
                            hasChanged = true;

                            return new List<AphidExpression>
                            {
                                new NumberExpression(left / right)
                            };
                        }
                        hasChanged = false;

                        return null;

                    default:
                        hasChanged = false;

                        return null;
                }
            }
            else
            {
                hasChanged = false;

                return null;
            }
        }
    }
}
