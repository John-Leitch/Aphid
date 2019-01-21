using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.TypeSystem
{
    public class AphidInteropPartialFunction : IAphidCallable
    {
        public AphidInteropMember Member { get; }

        public object[] Applied { get; }

        public AphidInteropPartialFunction(AphidInteropMember member, object[] applied)
        {
            Member = member;
            Applied = applied;
        }
    }
}
