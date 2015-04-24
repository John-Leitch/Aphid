using System;

namespace Components.Aphid.Interpreter
{
    [AttributeUsage(AttributeTargets.Method)]
    public class AphidInteropFunctionAttribute : Attribute
    {
        public string Name { get; set; }

        public bool PassInterpreter { get; set; }

        public bool UnwrapParameters { get; set; }

        public AphidInteropFunctionAttribute (string name)
        {
            UnwrapParameters = true;
            Name = name;
        }        
    }
}

