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
    public class LambdaPositionMutator : AphidMutator
    {
        private Dictionary<string, FunctionExpression> _insertions = new Dictionary<string, FunctionExpression>();

        private List<FunctionExpression> _rootFunctions = new List<FunctionExpression>();

        private List<AphidExpression> _ast;

        private int _varId = 0;

        protected override void BeginRecursiveMutationPass(List<AphidExpression> ast)
        {
            _ast = ast;
        }

        protected override void EndRecursiveMutationPass(List<AphidExpression> ast)
        {
            foreach (var nvp in _insertions)
            {
                var decl = new BinaryOperatorExpression(
                    new IdentifierExpression(nvp.Key),
                    AphidTokenType.AssignmentOperator,
                    nvp.Value);

                var label = AphidTreeHelper.FirstOrDefaultPath(
                    ast,
                    x =>
                        x?.Type == AphidExpressionType.IdentifierExpression &&
                        x.ToIdentifier().Identifier == nvp.Key);

                var parent = GetEligibleMethodContainer(label, out var before);
                List<AphidExpression> body;

                if (parent != null)
                {
                    switch (parent.Type)
                    {
                        case AphidExpressionType.FunctionExpression:
                            body = parent.ToFunction().Body;
                            break;

                        default:
                            throw new NotImplementedException();
                    }

                    body.Insert(body.IndexOf(before), decl);
                }
                else
                {
                    ast.Insert(0, decl);
                }
            }

            _insertions.Clear();
        }

        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            hasChanged = false;

            var parent = expression as IParentNode;

            if (IsStatement &&
                expression.Type == AphidExpressionType.BinaryOperatorExpression &&
                expression.ToBinaryOperator().LeftOperand.Type == AphidExpressionType.IdentifierExpression &&
                expression.ToBinaryOperator().RightOperand.Type == AphidExpressionType.FunctionExpression)
            {
                _rootFunctions.Add(expression.ToBinaryOperator().RightOperand.ToFunction());

                return null;
            }
            else if (expression.Type == AphidExpressionType.FunctionExpression &&
                !_rootFunctions.Contains(expression.ToFunction()))
            {
                var parents = AphidTreeHelper.FirstOrDefaultPath(_ast, x => x == expression);

                if (parents.Length >= 3 &&
                    parents.Skip(1).First().Type == AphidExpressionType.BinaryOperatorExpression &&
                    parents.Skip(2).First().Type == AphidExpressionType.ObjectExpression)
                {
                    return null;
                }

                var eligible = GetEligibleMethodContainer(parents, out var after);

                if (eligible != null)
                {
                    var id = QueueInsertion(expression.ToFunction(), eligible, after);
                    hasChanged = true;

                    return new List<AphidExpression> { id };
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
            else
            {
                return null;
            }
        }

        private AphidExpression GetEligibleMethodContainer(AphidExpression[] parents, out AphidExpression before)
        {
            before = null;

            foreach (var exp in parents)
            {
                switch (exp.Type)
                {
                    case AphidExpressionType.FunctionExpression:
                        return exp;
                }

                before = exp;
            }

            before = null;

            return null;
        }

        private IdentifierExpression QueueInsertion(FunctionExpression function, AphidExpression parent, AphidExpression after)
        {
            var id = new IdentifierExpression(NextVarId());
            _insertions.Add(id.Identifier, function);

            return id;
        }

        private string NextVarId()
        {
            return string.Format("var_func_{0:X8}", _varId++);
        }
    }
}
