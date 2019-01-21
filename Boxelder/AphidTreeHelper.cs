using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxelder
{
    public static class AphidTreeHelper
    {
        private static Stack<AphidExpression> _expressions = new Stack<AphidExpression>();

        public static AphidExpression[] FirstOrDefaultPath(
            List<AphidExpression> ast,
            Func<AphidExpression, bool> predicate)
        {
            return ast
                .Select(x => FirstOrDefaultPath(x, predicate))
                .FirstOrDefault(x => x != null);
        }

        public static AphidExpression[] FirstOrDefaultPath(
            AphidExpression expression,
            Func<AphidExpression, bool> predicate)
        {
            IParentNode parent;
            _expressions.Push(expression);

            try
            {
                if (predicate(expression))
                {
                    return _expressions.ToArray();
                }
                else if ((parent = expression as IParentNode) != null)
                {
                    return parent
                        .GetChildren()
                        .Select(x => FirstOrDefaultPath(x, predicate))
                        .FirstOrDefault(x => x != null);
                }
                else
                {
                    return null;
                }
            }
            finally
            {
                _expressions.Pop();
            }
        }
    }
}
