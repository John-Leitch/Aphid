using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Interpreter
{
    public class AphidInteropMembers
    {
        public object Target { get; private set; }

        public MemberInfo[] Members { get; private set; }

        public AphidInteropMembers(object target, MemberInfo[] members)
        {
            Target = target;
            Members = members;
        }
    }
}
