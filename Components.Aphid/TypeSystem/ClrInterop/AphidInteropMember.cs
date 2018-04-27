using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.TypeSystem
{
    public class AphidInteropMember : IAphidCallable
    {
        public AphidExpression Expression { get; private set; }

        public object Target { get; private set; }

        public MemberInfo[] Members { get; private set; }

        public AphidInteropMember(
            AphidExpression expression,
            object target,
            MemberInfo[] members)
        {
            Expression = expression;
            Target = target;
            Members = members;
        }
    }
}
