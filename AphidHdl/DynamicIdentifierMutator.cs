using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AphidHdl
{
    public class DynamicIdentifierMutator : AphidMutator
    {
        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            hasChanged = false;

            if (expression.Type != AphidExpressionType.BinaryOperatorExpression)
            {
                return null;
            }

            var binOp = (BinaryOperatorExpression)expression;

            if (binOp.LeftOperand.Type != AphidExpressionType.ThisExpression)
            {
                return null;
            }

            hasChanged = true;

            if (binOp.RightOperand.Type != AphidExpressionType.DynamicMemberExpression)
            {
                throw new NotImplementedException();
            }

            var exp = (DynamicMemberExpression)binOp.RightOperand;
            var numMutator = new NumberToStringMutator();
            exp = numMutator.Mutate(new List<AphidExpression> { exp }).Cast<DynamicMemberExpression>().Single();
            var constMutator = new ConstantFoldingMutator();
            exp = constMutator.Mutate(new List<AphidExpression> { exp }).Cast<DynamicMemberExpression>().Single();

            if (exp.MemberExpression.Type != AphidExpressionType.StringExpression)
            {
                throw new NotImplementedException();
            }

            var strExp = (StringExpression)exp.MemberExpression;
            var str = StringParser.Parse(strExp.Value);

            return new List<AphidExpression> { new IdentifierExpression(str) };
        }
    }
}
