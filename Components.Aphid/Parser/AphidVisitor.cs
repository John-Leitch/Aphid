using System.Collections.Generic;

namespace Components.Aphid.Parser
{
    public abstract class AphidVisitor
    {
        private bool _ignoreChildren = false;

        protected void IgnoreChildren()
        {
            _ignoreChildren = true;
        }

        public void Visit(List<AphidExpression> ast)
        {
            foreach (var exp in ast)
            {
                VisitNode(exp);
            }
        }

        private void VisitNode(AphidExpression expression)
        {
            Visit(expression);

            if (!_ignoreChildren)
            {
                var parent = expression as IParentNode;

                if (parent == null)
                {
                    return;
                }

                foreach (var n in GetChildren(parent))
                {
                    VisitNode(n);
                }
            }
            else
            {
                _ignoreChildren = false;
            }
        }

        protected abstract void Visit(AphidExpression expression);

        protected virtual IEnumerable<AphidExpression> GetChildren(IParentNode parent)
        {
            return parent.GetChildren();
        }
    }
}
