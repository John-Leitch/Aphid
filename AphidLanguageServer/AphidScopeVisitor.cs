using Components.Aphid.Interpreter;
using Components.Aphid.Parser;
using System.Collections.Generic;

namespace AphidLanguageServer
{
    public class AphidScopeVisitor : AphidVisitor
    {
        private AphidInterpreter _interpreter;

        private List<AphidExpression> _interpret;

        public AphidScopeVisitor(AphidInterpreter interpreter) => _interpreter = interpreter;

        protected override void Visit(AphidExpression expression)
        {
            if (expression.Type == AphidExpressionType.UsingExpression)
            {
                _interpret.Add(expression);
            }
            else if (expression.Type == AphidExpressionType.IdentifierExpression)
            {
                _interpret.Add(new IdentifierExpression(
                    ((IdentifierExpression)expression).Identifier,
                    new List<IdentifierExpression> { new IdentifierExpression("var") }));
            }
        }

        protected override void BeginVisit(List<AphidExpression> ast) => _interpret = new List<AphidExpression>();

        protected override void EndVisit(List<AphidExpression> ast)
        {
            _interpreter.CurrentScope.Clear();
            _interpreter.Interpret(_interpret);
        }
    }
}
