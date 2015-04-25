using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantispid
{
    public class CallIdentifierMutator : AphidMutator
    {
        private string[] _parseFunctions;

        private bool _skip = false;

        public CallIdentifierMutator(string[] parseFunctions)
        {
            _parseFunctions = parseFunctions;
        }

        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            hasChanged = false;

            CallExpression call;
            IdentifierExpression id;

            // Todo: handle member access e.g. decimal.Parse
            if (expression.Type == AphidExpressionType.CallExpression &&
                (call = expression.ToCall()).FunctionExpression.Type == AphidExpressionType.IdentifierExpression &&
                _parseFunctions.Contains(call.FunctionExpression.ToIdentifier().Identifier))
            {
                _skip = true;
            }
            //else if (expression.Type == AphidNodeType.BinaryOperatorExpression &&
            //    (binOp = expression.ToBinaryOperator()).LeftOperand.Type == AphidNodeType.IdentifierExpression &&
            //    _parseFunctions.Contains(binOp.LeftOperand.ToIdentifier().Identifier))
            //{
            //    _skip = true;
            //}
            else if (expression.Type == AphidExpressionType.IdentifierExpression &&
                _parseFunctions.Contains((id = expression.ToIdentifier()).Identifier))
            {
                if (_skip)
                {
                    _skip = false;
                }
                else
                {
                    hasChanged = true;

                    return new List<AphidExpression> { new CallExpression(id) };
                }
            }

            return null;
        }
    }
}
