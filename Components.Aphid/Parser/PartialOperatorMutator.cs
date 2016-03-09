using Components.Aphid.Lexer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Parser
{
    public class PartialOperatorMutator : AphidMutator
    {
        private int _id = 0;

        private IdentifierExpression GetNextId()
        {
            return new IdentifierExpression(string.Format("___p_op_{0}", _id++));
        }

        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            if (expression.Type != AphidExpressionType.PartialOperatorExpression)
            {
                hasChanged = false;

                return null;
            }

            hasChanged = true;
            var partialOpExp = (PartialOperatorExpression)expression;
            var id = GetNextId();
            
            return new List<AphidExpression>
            {
                new FunctionExpression(
                    new List<AphidExpression> { id },
                    new List<AphidExpression>
                    {
                        new UnaryOperatorExpression(
                            AphidTokenType.retKeyword,
                            new BinaryOperatorExpression(
                                id,
                                partialOpExp.Operator,
                                partialOpExp.Operand))
                    })
            };
        }
    }
}
