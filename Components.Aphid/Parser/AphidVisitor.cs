using System.Collections.Generic;

namespace Components.Aphid.Parser
{
    public abstract class AphidVisitor
    {
        private bool _ignoreChildren = false;

        public Stack<AphidExpression> Ancestors { get; private set; }

        protected void IgnoreChildren() => _ignoreChildren = true;

        public void VisitExpression(AphidExpression node) => Visit(new List<AphidExpression> { node });

        public void Visit(List<AphidExpression> ast)
        {
            Ancestors = new Stack<AphidExpression>();
            BeginVisit(ast);

            foreach (var exp in ast)
            {
                BeginVisitNode(exp);
                Ancestors.Push(exp);
                VisitNode(exp);
                Ancestors.Pop();
                EndVisitNode(exp);
            }

            EndVisit(ast);
        }

        protected virtual void BeginVisit(List<AphidExpression> ast)
        {
        }

        protected virtual void EndVisit(List<AphidExpression> ast)
        {
        }

        private void VisitNode(AphidExpression expression)
        {
            if (expression == null)
            {
                return;
            }

            Visit(expression);

            if (!_ignoreChildren)
            {
                if (!(expression is IParentNode parent))
                {
                    return;
                }

                foreach (var n in GetChildren(parent))
                {
                    BeginVisitNode(n);
                    Ancestors.Push(n);
                    VisitNode(n);
                    Ancestors.Pop();
                    EndVisitNode(n);
                }
            }
            else
            {
                _ignoreChildren = false;
            }
        }

        protected virtual void BeginVisitNode(AphidExpression expression)
        {
        }

        protected virtual void EndVisitNode(AphidExpression expression)
        {
        }

        protected abstract void Visit(AphidExpression expression);

        protected virtual IEnumerable<AphidExpression> GetChildren(IParentNode parent) => parent.GetChildren();
    }
}
