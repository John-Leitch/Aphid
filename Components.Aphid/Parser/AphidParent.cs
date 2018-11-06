using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Parser
{
    public static class AphidParent
    {
        public static AphidExpression[] Flatten(AphidExpression[] expressions)
            => expressions
                .OfType<IParentNode>()
                .SelectMany(x => x.GetChildren())
                .ToArray();

        public static AphidExpression FirstFilename(AphidExpression expression)
            => FirstFilename(new[] { expression });

        public static AphidExpression FirstFilename(AphidExpression[] expressions)
            => First(expressions, x => x?.Context?.Filename != null);

        public static AphidExpression FirstCode(AphidExpression expression)
            => FirstCode(new[] { expression });

        public static AphidExpression FirstCode(AphidExpression[] expressions)
            => First(expressions, x => x?.Context?.Code != null);

        public static AphidExpression FirstRange(AphidExpression expression)
            => FirstRange(new[] { expression });

        public static AphidExpression FirstRange(AphidExpression[] expressions)
            => First(expressions, x => x?.Index >= 0 && x?.Length > 0);

        public static AphidExpression FirstNearComplete(AphidExpression expression)
            => FirstNearComplete(new[] { expression });

        public static AphidExpression FirstNearComplete(AphidExpression[] expressions)
            => First(
                expressions,
                x => x?.Index >= 0 &&
                    x?.Length > 0 &&
                    x?.Context?.Code != null);

        public static AphidExpression FirstComplete(AphidExpression expression)
            => FirstComplete(new[] { expression });

        public static AphidExpression FirstComplete(AphidExpression[] expressions)
            => First(
                expressions,
                x => x?.Index >= 0 &&
                    x?.Length > 0 &&
                    x?.Context?.Filename != null &&
                    x?.Context?.Code != null);

        public static AphidExpression First(
            AphidExpression[] expressions,
            Func<AphidExpression, bool> predicate)
        {
            do
            {
                var first = expressions.FirstOrDefault(predicate);

                if (first != null)
                {
                    return first;
                }
            } while((expressions = Flatten(expressions)).Length != 0);

            return null;
        }
    }
}
