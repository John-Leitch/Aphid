using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.TypeSystem
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class AphidPropertyAttribute : Attribute
    {
        public string Name { get; internal set; }

        public AphidPropertyAttribute()
        {
        }

        public AphidPropertyAttribute(string name)
            : base() => Name = name;
    }
}
