using System.Reflection;

namespace Components.Aphid.TypeSystem
{
    public class AphidPropertyInfo
    {
        public string Name { get; set; }

        public PropertyInfo Property { get; set; }

        public AphidPropertyInfo(string name, PropertyInfo property)
        {
            Name = name;
            Property = property;
        }
    }
}
