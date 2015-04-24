using System;
using System.Collections.Generic;

namespace Components.Aphid.Parser
{
    public class DynamicMemberExpression : AphidExpression, IParentNode
    {
        public override AphidNodeType Type
        {
            get { return AphidNodeType.DynamicMemberExpression; }
        }

        public AphidExpression MemberExpression { get; set; }

        public DynamicMemberExpression ()
        {
        }

        public DynamicMemberExpression (AphidExpression memberExpression)
        {
            MemberExpression = memberExpression;
        }

        public IEnumerable<AphidExpression> GetChildren()
        {
            return new[] { MemberExpression };
        }
    }
}

