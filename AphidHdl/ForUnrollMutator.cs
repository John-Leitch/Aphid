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

            if (expression.Type != AphidNodeType.ForExpression)
            {
                return null;
            }

            hasChanged = true;

            var forExp = (ForExpression)expression;

            if (forExp.Initialization.Type != AphidNodeType.BinaryOperatorExpression)
            {
                throw new InvalidOperationException();
            }

            var initExp = (BinaryOperatorExpression)forExp.Initialization;

            if (initExp.Operator != AphidTokenType.AssignmentOperator ||
                initExp.LeftOperand.Type != AphidNodeType.IdentifierExpression ||
                initExp.RightOperand.Type != AphidNodeType.NumberExpression)
            {
                throw new InvalidOperationException();
            }

            var id = ((IdentifierExpression)initExp.LeftOperand).Identifier;
            var interpreter = new AphidInterpreter();
            interpreter.Interpret(new List<AphidExpression> { initExp });

            var key = "$condition";

            var condition = new BinaryOperatorExpression(
                new IdentifierExpression(key),
                AphidTokenType.AssignmentOperator,
                forExp.Condition);
                
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
                        x.Type == AphidNodeType.IdentifierExpression &&
                        ((IdentifierExpression)x).Identifier == id,
                    x => new List<AphidExpression> { new NumberExpression(value) });

                unrolled.AddRange(replaceMutator.MutateRecursively(forExp.Body));
                interpreter.Interpret(new List<AphidExpression> { forExp.Afterthought });
            }

            return unrolled;
        }
    }
}
