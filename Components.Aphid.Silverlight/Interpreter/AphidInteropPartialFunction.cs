using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Interpreter
{
    public class AphidInteropPartialFunction
    {
        public AphidInteropMember Member { get; private set; }

        public object[] Applied { get; private set; }

        public AphidInteropPartialFunction(AphidInteropMember member, object[] applied)
        {
            Member = member;
            Applied = applied;
        }
    }
}
