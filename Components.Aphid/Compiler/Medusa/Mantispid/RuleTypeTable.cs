using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Mantispid
{
    [Serializable]
    public class RuleTypeTable : Dictionary<string, RuleStruct>
    {
        protected RuleTypeTable(SerializationInfo info, StreamingContext context) :
            base(info, context)
        {
        }

        public RuleTypeTable()
        {
        }

        public void Add(RuleStruct type) => Add(type.Name, type);
    }
}
