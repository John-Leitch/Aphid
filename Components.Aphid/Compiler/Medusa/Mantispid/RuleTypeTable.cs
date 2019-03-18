using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

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
