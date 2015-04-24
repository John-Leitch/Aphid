using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantispid
{
    public class RuleTypeTable : Dictionary<string, RuleStruct>
    {
        public void Add(RuleStruct type)
        {
            Add(type.Name, type);
        }
    }
}
