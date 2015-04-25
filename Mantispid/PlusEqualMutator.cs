using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantispid
{
    public class PlusEqualMutator : AphidMutator
    {
        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            BinaryOperatorExpression binOpExp;

            if (expression.Type != AphidExpressionType.BinaryOperatorExpression ||
                (binOpExp = expression.ToBinaryOperator()).Operator != AphidTokenType.PlusEqualOperator)
            {
                hasChanged = false;

                return null;
            }

            hasChanged = true;

            return new List<AphidExpression>
            {
                new CallExpression(
                    new BinaryOperatorExpression(
                        binOpExp.LeftOperand, 
                        AphidTokenType.MemberOperator,
                        new IdentifierExpression("Add")),
                    binOpExp.RightOperand)
            };
        }
    }
}
