using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.External.ConsolePlus
{
    public class CliArgProperty
    {
        public PropertyInfo Property { get; private set; }

        public CliArgAttribute Attribute { get; private set; }

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
