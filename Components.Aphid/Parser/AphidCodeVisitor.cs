using System.Collections.Generic;
using System.Linq;

namespace Components.Aphid.Parser
{
    public class AphidCodeVisitor : AphidVisitor
    {
        //private string _code;

        //private string _filename;

        //public AphidCodeVisitor(string code)
        //    : this(code, null)
        //{
        //}

        //public AphidCodeVisitor(string code, string filename)
        //{
        //    _code = code;
        //    _filename = filename;
        //}

        protected override void EndVisit(List<AphidExpression> ast)
        {
            AphidExpression prev = null, next = ast.Count > 1 ? ast[1] : null;

            for (var i = 0; i < ast.Count; i++)
            {
                var node = ast[i];

                if (node.Index == -1)
                {
                    if (prev == null)
                    {
                        if (node.Code == null)
                        {
                            node.Code = next.Code;
                        }

                        if (node.Filename == null && next.Filename != null)
                        {
                            node.Filename = next.Filename;
                        }

                        node.Index = 0;
                        node.Length = next.Index;
                    }
                    else if (next == null)
                    {
                        if (node.Code == null)
                        {
                            node.Code = prev.Code;
                        }

                        if (node.Filename == null && prev.Filename != null)
                        {
                            node.Filename = prev.Filename;
                        }

                        node.Index = prev.Index + prev.Length;
                        node.Length = node.Code.Length - node.Index;
                    }
                    else
                    {
                        if (node.Code == null)
                        {
                            node.Code = prev.Code;
                        }

                        if (node.Filename == null && prev.Filename != null)
                        {
                            node.Filename = prev.Filename;
                        }

                        node.Index = prev.Index + prev.Length;
                        node.Length = next.Index - node.Index;
                    }
                }

                prev = ast[i];
                next = i + 2 < ast.Count ? ast[i + 2] : null;
            }

            base.EndVisit(ast);
        }

        protected override void Visit(AphidExpression expression)
        {
            //if (_filename != null && expression.Filename == null)
            //{
            //    expression.Filename = _filename;
            //}

            if (expression.Index == -1 && Ancestors.Count > 1)
            {
                var a = Ancestors.ToArray()[1];

                if (a.Index == -1)
                {
                    return;
                }

                //var a = Ancestors.FirstOrDefault(x => x.Index != -1);

                IParentNode parent;

                if (a != null)
                {
                    expression.Index = a.Index;
                    expression.Length = a.Length;
                }
                else if ((parent = expression as IParentNode) != null)
                {
                    var children = parent.GetChildren();

                    if (children.Any())
                    {
                        expression.Index = children.First().Index;

                        expression.Length = children
                            .Where(x => x != null)
                            .GroupBy(x => x.Index)
                            .Select(x => x.OrderByDescending(y => y.Length).First())
                            .Sum(x => x.Length);
                    }
                }
            }

            //expression.Code = _code;
        }
    }
}
