using System.Linq;
using System.Reflection;

namespace Components.External.ConsolePlus
{
    public class CliArgProperty
    {
        public PropertyInfo Property { get; }

        public CliArgAttribute Attribute { get; }

        public CliArgProperty(PropertyInfo property, CliArgAttribute attribute)
        {
            Property = property;
            Attribute = attribute;
        }

        public static CliArgProperty[] GetAll<TArgs>()
        {
            return typeof(TArgs)
                .GetProperties()
                .Select(x => new CliArgProperty(
                    x,
                    (CliArgAttribute)x
                        .GetCustomAttributes(typeof(CliArgAttribute), true)
                        .SingleOrDefault()))
                .Where(x => x.Attribute != null)
                .ToArray();
        }
    }
}
