using System.Reflection;

namespace Components.Aphid.Interpreter
{
    public class AphidPropertyValuePair
    {
        public PropertyInfo Property { get; set; }

        public AphidObject Value { get; set; }

        public AphidPropertyValuePair(PropertyInfo property, AphidObject value)
        {
            Property = property;
            Value = value;
        }
    }
}
