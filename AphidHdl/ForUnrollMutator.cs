using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AphidHdl
{
    public class ForUnrollMutator : AphidMutator
    {
        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            hasChanged = false;

            if (expression.Type != AphidExpressionType.ForExpression)
            {
                return null;
            }

            hasChanged = true;

            var forExp = (ForExpression)expression;

            if (forExp.Initialization.Type != AphidExpressionType.BinaryOperatorExpression)
            {
                throw new InvalidOperationException();
            }

            var initExp = (BinaryOperatorExpression)forExp.Initialization;

            if (initExp.Operator != AphidTokenType.AssignmentOperator ||
                initExp.LeftOperand.Type != AphidExpressionType.IdentifierExpression ||
                initExp.RightOperand.Type != AphidExpressionType.NumberExpression)
            {
                throw new InvalidOperationException();
            }

            var id = ((IdentifierExpression)initExp.LeftOperand).Identifier;
            var interpreter = new AphidInterpreter();
            interpreter.Interpret(new List<AphidExpression> { initExp });

            var key = "$condition_" + Guid.NewGuid().ToString().Replace('-', '_');

            interpreter.Interpret(
                new List<AphidExpression>
                {
                    new IdentifierExpression(
                        key,
                        new List<IdentifierExpression> 
                        {
                            new IdentifierExpression(AphidName.Var)
                        })
                });

            var condition = new BinaryOperatorExpression(
                new IdentifierExpression(key).WithPositionFrom(forExp.Condition),
                AphidTokenType.AssignmentOperator,
                forExp.Condition)
                    .WithPositionFrom(forExp.Condition);
                
            bool conditionResult;
            var unrolled = new List<AphidExpression>();

            while (true)
            {
                interpreter.Interpret(new List<AphidExpression> { condition });
                conditionResult = (bool)interpreter.CurrentScope[key].Value;

                if (!conditionResult)
                {
                    break;
                }

                var value = (decimal)interpreter.CurrentScope[id].Value;
                
                var replaceMutator = new ReplacementMutator(
                    x =>
                        x.Type == AphidExpressionType.IdentifierExpression &&
                        ((IdentifierExpression)x).Identifier == id,
                    x => new List<AphidExpression> { new NumberExpression(value) });

                unrolled.AddRange(replaceMutator.MutateRecursively(forExp.Body));
                
                interpreter.Interpret(new List<AphidExpression> { forExp.Afterthought });
            }

            return unrolled;
        }
    }
}
