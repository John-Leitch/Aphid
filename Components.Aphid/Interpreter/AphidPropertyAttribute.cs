using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Interpreter
{
    [AttributeUsage(AttributeTargets.Property)]
    public class AphidPropertyAttribute : Attribute
    {
        public string Name { get; set; }

        public AphidPropertyAttribute()
        {
        }

        public AphidPropertyAttribute(string name)
            : base()
        {
            Name = name;
        }
    }
}
