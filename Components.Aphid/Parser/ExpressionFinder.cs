using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public class ExpressionFinder : AphidVisitor
    {
        private bool _ignoreMatchChildren;

        private Func<AphidExpression, bool> _predicate;

        private List<AphidExpression> _results;

        protected override void Visit(AphidExpression expression)
        {
            if (_predicate(expression))
            {
                _results.Add(expression);

                if (_ignoreMatchChildren)
                {
                    IgnoreChildren();
                }
            }
        }

        public List<AphidExpression> Find(
            List<AphidExpression> source,
            AphidExpressionType expressionType,
            bool ignoreMatchChildren = false) => Find(source, x => x.Type == expressionType);

        public List<AphidExpression> Find(
            List<AphidExpression> source,
            Func<AphidExpression, bool> predicate,
            bool ignoreMatchChildren = false)
        {
            _results = new List<AphidExpression>();
            _predicate = predicate;
            _ignoreMatchChildren = ignoreMatchChildren;
            Visit(source.ToList());

            return _results;
        }
    }
}
