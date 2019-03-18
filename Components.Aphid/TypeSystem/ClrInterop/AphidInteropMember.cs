using Components.Aphid.Parser;
using System.Reflection;

namespace Components.Aphid.TypeSystem
{
    public class AphidInteropMember : IAphidCallable
    {
        public AphidExpression Expression { get; }

        public object Target { get; }

        public MemberInfo[] Members { get; }

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
