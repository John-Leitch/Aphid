using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Serialization
{
    public class AphidObjectReferenceVisitor : AphidVisitor
    {
        private ObjectExpression _object;

        private ArrayExpression _array;

        private BinaryOperatorExpression _member;

        private Stack<AphidExpression> _currentPath;

        private List<BinaryOperatorExpression> _refAssignments;

        public IEnumerable<BinaryOperatorExpression> FindReferenceAssignments(List<AphidExpression> ast)
        {
            Visit(ast);

            return _refAssignments.ToArray();
        }

        protected override void Visit(AphidExpression expression)
        {
            if (_member != null && _member == expression && IsRef(_member.RightOperand))
            {
                AddMemberReference(expression);
            }
        }

        private void AddMemberReference(AphidExpression expression)
        {
            AphidExpression lhs = null;

            foreach (var x in _currentPath.Reverse())
            {
                if (lhs != null)
                {
                    lhs = new BinaryOperatorExpression(lhs, AphidTokenType.MemberOperator, x)
                        .WithPositionFrom(x);
                }
                else
                {
                    lhs = x;
                }
            }

            _refAssignments.Add(
                new BinaryOperatorExpression(
                    lhs,
                    AphidTokenType.AssignmentOperator,
                    _member.RightOperand));


            var i = _object.Pairs.IndexOf(_member);
            _object.Pairs.RemoveAt(i);

            _object.Pairs.Insert(
                i,
                new BinaryOperatorExpression(
                    _member.LeftOperand,
                    _member.Operator,
                    AphidParser.Parse("null").First()));
        }

        protected override void BeginVisit(List<AphidExpression> ast)
        {
            _currentPath = new Stack<AphidExpression>(
                new[] { new IdentifierExpression(AphidSerializer.Root) });

            _refAssignments = new List<BinaryOperatorExpression>();
        }

        protected override void BeginVisitNode(AphidExpression expression)
        {
            if (IsMember(expression))
            {
                _object = Ancestors.Peek().ToObject();
                _member = expression.ToBinaryOperator();
                _currentPath.Push(_member.LeftOperand);
            }
            else if (IsArray(expression))
            {
                _array = expression.ToArray();
            }
        }

        protected override void EndVisitNode(AphidExpression expression)
        {
            if (IsMember(expression))
            {
                _currentPath.Pop();
                _member = null;
                _object = null;
            }
            else if (IsArray(expression))
            {
                _array = null;
            }
        }

        private bool IsMember(AphidExpression expression) =>
            expression != null &&
            expression.Type == AphidExpressionType.BinaryOperatorExpression &&
            Ancestors.Count >= 1 &&
            Ancestors.Peek().Type == AphidExpressionType.ObjectExpression;

        private static bool IsArray(AphidExpression expression) => expression != null && expression.Type == AphidExpressionType.ArrayExpression;

        private static bool IsRef(AphidExpression expression) =>
            expression.Type == AphidExpressionType.IdentifierExpression ||
            expression.Type == AphidExpressionType.BinaryOperatorExpression;
    }
}
