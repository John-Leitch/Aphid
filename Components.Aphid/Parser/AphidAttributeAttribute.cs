using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public class AphidAttributeAttribute : Attribute
    {
        public string Name { get; private set; }

        public AphidAttributeAttribute(string name)
            : this()
        {
            Name = name;
        }

        public AphidAttributeAttribute()
        {
        }
    }
}
