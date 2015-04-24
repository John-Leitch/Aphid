using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Components.Aphid.Parser
{
    public class CallExpression : AphidExpression, IParentNode
    {
        public override AphidNodeType Type
        {
            get { return AphidNodeType.CallExpression; }
        }

        public AphidExpression FunctionExpression { get; set; }

        public IEnumerable<AphidExpression> Args { get; set; }

        public CallExpression(AphidExpression functionExpression, IEnumerable<AphidExpression> args)
        {
            FunctionExpression = functionExpression;
            Args = args;
        }

        public CallExpression(AphidExpression functionExpression)
            : this (functionExpression, new AphidExpression[0])
        {
            
        }

        public CallExpression(AphidExpression functionExpression, AphidExpression expression)
            : this(functionExpression, new[] { expression })
        {
        }

        public override string ToString()
        {
            return string.Format("{0}({1})", FunctionExpression, Args.Select(x => x.ToString()).DefaultIfEmpty().Aggregate((x, y) => x + ", " + y));
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new[] { FunctionExpression }.Concat(Args);
        }
    }
}
