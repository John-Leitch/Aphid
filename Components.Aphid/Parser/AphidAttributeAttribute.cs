using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Method | AttributeTargets.Field)]
    public sealed class AphidAttributeAttribute : Attribute
    {
        public string Name { get; }

        public AphidAttributeAttribute(string name)
            : this() => Name = name;

        public AphidAttributeAttribute()
        {
        }
    }
}
