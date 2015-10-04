using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public class ExpressionFinder : AphidMutator
    {
        private List<AphidExpression> _expressions = new List<AphidExpression>();

        private AphidExpressionType _type;

        protected override List<AphidExpression> MutateCore(AphidExpression expression, out bool hasChanged)
        {
            hasChanged = false;

            if (expression.Type == _type)
            {
                _expressions.Add(expression);
            }

            return null;
        }

        public AphidExpression[] Find(AphidExpressionType type, List<AphidExpression> ast)
        {
            _type = type;
            MutateRecursively(ast);
            Reset();
            return _expressions.ToArray();
        }
    }
}
