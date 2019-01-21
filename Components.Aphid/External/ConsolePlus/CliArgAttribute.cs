using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.External.ConsolePlus
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class CliArgAttribute : Attribute
    {
        public string[] Names { get; internal set; }

        public bool IsRequired { get; set; }

        public bool IsInputFile { get; set; }

        public string ValueName { get; set; }

        public string Description { get; set; }

        public int Position { get; set; }

        public CliArgAttribute(params string[] names)
        {
            Names = names;
            IsRequired = false;
        }
    }
}
