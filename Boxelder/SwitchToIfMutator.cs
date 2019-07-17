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
    public class SwitchToIfMutator : AphidMutator
    {
        private int _id = 0;

        private IdentifierExpression NextId() =>
            new IdentifierExpression(string.Format("_cwSwitchValue_{0:X4}", _id++));

        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            if (expression.Type != AphidExpressionType.SwitchExpression)
            {
                hasChanged = false;

                return null;
            }

            hasChanged = true;
            var switchExp = expression.ToSwitch();
            var id = NextId();
            
            var idDecl = new BinaryOperatorExpression(
                id,
                AphidTokenType.AssignmentOperator,
                switchExp.Expression);

            var cases = switchExp.Cases
                .Select(x => new
                {
                    Case = x,
                    Condition = CreateCaseCondition(x, id),
                });

            IfExpression rootIfExp = null, ifExp = null;

            foreach (var c in cases)
            {
                if (ifExp != null)
                {
                    var prev = ifExp;
                    ifExp = CreateIfExpression(c.Condition, c.Case.Body);
                    prev.ElseBody.Add(ifExp);
                }
                else
                {
                    rootIfExp = ifExp = CreateIfExpression(c.Condition, c.Case.Body);
                }
            }

            if (switchExp.DefaultCase != null)
            {
                ifExp.ElseBody.AddRange(switchExp.DefaultCase);
            }

            return new List<AphidExpression> { idDecl, rootIfExp };
        }

        private IfExpression CreateIfExpression(BinaryOperatorExpression condition, List<AphidExpression> body) =>
            new IfExpression(condition, body, new List<AphidExpression>());

        private BinaryOperatorExpression CreateCaseCondition(
            SwitchCase caseExp,
            IdentifierExpression valueId)
        {
            BinaryOperatorExpression exp = null;

            foreach (var c in caseExp.Cases.Select(x => CreateCaseEqualityExpression(valueId, x)))
            {
                if (exp != null)
                {
                    exp = new BinaryOperatorExpression(exp, AphidTokenType.OrOperator, c);
                }
                else
                {
                    exp = c;
                }
            }

            return exp;
        }

        private BinaryOperatorExpression CreateCaseEqualityExpression(
            IdentifierExpression valueId,
            AphidExpression caseExpression) =>
            new BinaryOperatorExpression(valueId, AphidTokenType.EqualityOperator, caseExpression);
    }
}
