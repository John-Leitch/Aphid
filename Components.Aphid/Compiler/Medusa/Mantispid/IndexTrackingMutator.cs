using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using System.Collections.Generic;
using System.Linq;

namespace Mantispid
{
    public class IndexTrackingMutator : AphidMutator
    {
        private readonly string[] _nonListRules;

        private readonly List<AphidExpression> _mutated = new List<AphidExpression>();

        private int _indexNumber;

        public IndexTrackingMutator(string[] nonListRules) => _nonListRules = nonListRules;

        private string GetNextIndexName() => $"index{_indexNumber++:X4}";

        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            BinaryOperatorExpression binOpExp;

            if (_mutated.Contains(expression) ||
                expression.Type != AphidExpressionType.BinaryOperatorExpression ||
                (binOpExp = expression.ToBinaryOperator()).Operator != AphidTokenType.AssignmentOperator ||
                binOpExp.LeftOperand.Type != AphidExpressionType.IdentifierExpression ||
                binOpExp.RightOperand.Type != AphidExpressionType.CallExpression ||
                binOpExp.RightOperand.ToCall().FunctionExpression.Type != AphidExpressionType.IdentifierExpression ||
                !_nonListRules.Contains(binOpExp.RightOperand.ToCall().FunctionExpression.ToIdentifier().Identifier))
            {
                hasChanged = false;
                return null;
            }

            _mutated.Add(expression);
            var indexName = GetNextIndexName();

            var indexId = new IdentifierExpression("Index");

            var currentTokenIndex = new BinaryOperatorExpression(
                new IdentifierExpression("_currentToken"),
                AphidTokenType.MemberOperator,
                indexId);

            var lastIndexId = new IdentifierExpression(indexName);

            var indexAssign = new BinaryOperatorExpression(
                lastIndexId,
                AphidTokenType.AssignmentOperator,
                currentTokenIndex);

            var nodeIndex = new BinaryOperatorExpression(
                binOpExp.LeftOperand,
                AphidTokenType.MemberOperator,
                indexId);

            var condition = new BinaryOperatorExpression(
                nodeIndex,
                AphidTokenType.LessThanOperator,
                new NumberExpression(0));

            var nodeIndexAssign = new BinaryOperatorExpression(
                nodeIndex,
                AphidTokenType.AssignmentOperator,
                lastIndexId);

            var nodeLengthAssign = new BinaryOperatorExpression(
                new BinaryOperatorExpression(
                    binOpExp.LeftOperand,
                    AphidTokenType.MemberOperator,
                    new IdentifierExpression("Length")),
                AphidTokenType.AssignmentOperator,
                new BinaryOperatorExpression(
                    currentTokenIndex,
                    AphidTokenType.MinusOperator,
                    lastIndexId));

            var ifStmt = new IfExpression(
                condition,
                new List<AphidExpression> { nodeIndexAssign, nodeLengthAssign },
                new List<AphidExpression>());

            hasChanged = true;

            return new List<AphidExpression> { indexAssign, expression, ifStmt };
        }
    }
}
