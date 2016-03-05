using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.Aphid.Parser.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coywolf.Visitors
{
    public class LocalFinder : AphidVisitor
    {
        private List<IdentifierExpression> _locals;

        protected override void Visit(AphidExpression expression)
        {
            switch (expression.Type)
            {
                case AphidExpressionType.ForEachExpression:
                    var element = expression.ToForEach().Element;

                    if (element.Type == AphidExpressionType.IdentifierExpression)
                    {
                        _locals.Add(element.ToIdentifier());
                    }

                    break;

                case AphidExpressionType.BinaryOperatorExpression:
                    var binOpExp = expression.ToBinaryOperator();

                    if (binOpExp.Operator == AphidTokenType.AssignmentOperator &&
                        binOpExp.LeftOperand.Type == AphidExpressionType.IdentifierExpression)
                    {
                        _locals.Add(binOpExp.LeftOperand.ToIdentifier());
                    }

                    break;

                case AphidExpressionType.FunctionExpression:
                    IgnoreChildren();
                    break;
            }
        }

        public List<IdentifierExpression> Find(List<AphidExpression> body)
        {
            _locals = new List<IdentifierExpression>();
            Visit(body);

            return _locals;
        }
    }
}
