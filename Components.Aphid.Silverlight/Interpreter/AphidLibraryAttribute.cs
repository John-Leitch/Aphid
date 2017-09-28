using System;

namespace Components.Aphid.Interpreter
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AphidLibraryAttribute : Attribute
    {
        public string Name { get; set; }

        public AphidLibraryAttribute (string name)
        {
            Name = name;
        }
    }
}

