﻿using Components.Aphid.Lexer;
using System.Collections.Generic;

namespace Components.Aphid.Parser
{
    public class PartialOperatorMutator : AphidMutator
    {
        private int _id;

        private IdentifierExpression GetNextId() =>
            new($"___p_op_{_id++.ToString()}");

        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            if (expression.Type != AphidExpressionType.PartialOperatorExpression)
            {
                hasChanged = false;

                return null;
            }

            hasChanged = true;
            var partialOpExp = (PartialOperatorExpression)expression;
            var id = GetNextId().WithPositionFrom(expression);

            return new List<AphidExpression>
            {
                new FunctionExpression(
                    new List<AphidExpression> { id },
                    new List<AphidExpression>
                    {
                        new UnaryOperatorExpression(
                            AphidTokenType.retKeyword,
                            new BinaryOperatorExpression(id,
                                partialOpExp.Operator,
                                partialOpExp.Operand)
                                .WithPositionFrom(expression))
                            .WithPositionFrom(expression)
                    })
            };
        }
    }
}
