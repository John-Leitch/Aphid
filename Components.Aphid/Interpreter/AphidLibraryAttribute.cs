using System;

namespace Components.Aphid.Interpreter
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class AphidLibraryAttribute : Attribute
    {
        public string Name { get; set; }

        public AphidLibraryAttribute (string name)
        {
            Name = name;
        }
    }
}

