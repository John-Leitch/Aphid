using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.External
{
    public static class StringTree
    {
        public static string Create<TNode>(
            TNode root,
            Func<TNode, string> dumpNode,
            Func<TNode, IEnumerable<TNode>> getChildren)
        {
            var sb = new StringBuilder();
            Create(root, dumpNode, getChildren, sb, 0, new int[] { }, true);

            return sb.ToString();
        }

        public static void Create<TNode>(
            TNode node,
            Func<TNode, string> dumpNode,
            Func<TNode, IEnumerable<TNode>> getChildren,
            StringBuilder sb,
            int indentation,
            int[] siblingDepths,
            bool lastChild)
        {
            for (int i = 0; i < indentation; i++)
            {
                sb.Append(
                    lastChild && i == indentation - 1 ? "└" :
                    siblingDepths.Any() && siblingDepths.Last() == i && i == indentation - 1 ? "├" :
                    siblingDepths.Any() && siblingDepths.Contains(i) ? "│" :
                    " ");
            }

            sb.AppendLine(dumpNode(node));
            var children = getChildren(node);

            foreach (var child in children)
            {
                var lc = child.Equals(children.Last());

                Create(
                    child,
                    dumpNode,
                    getChildren,
                    sb,
                    indentation + 1,
                    !lc ?
                        siblingDepths
                            .Concat(new[] { indentation })
                            .ToArray() :
                        siblingDepths,
                    lc);
            }
        }
    }
}
