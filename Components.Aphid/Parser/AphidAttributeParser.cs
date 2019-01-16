using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Parser
{
    public static class AphidAttributeParser
    {
        public static TAttributes Parse<TAttributes>(IdentifierExpression identifierExpression)
            where TAttributes : new()
        {
            var attributes = Parse<TAttributes>(identifierExpression, out var unparsed);

            if (unparsed.Any())
            {
                throw new InvalidOperationException();
            }

            return attributes;
        }

        public static TAttributes Parse<TAttributes>(IdentifierExpression identifierExpression, out string[] unparsed)
            where TAttributes : new()
        {
            var unparsedList = new List<string>();

            var properties = typeof(TAttributes)
                .GetProperties()
                .Select(x => new
                {
                    Property = x,
                    Attribute = x
                        .GetCustomAttributes(typeof(AphidAttributeAttribute), true)
                        .OfType<AphidAttributeAttribute>()
                        .SingleOrDefault(),
                })
                .Where(x => x.Attribute != null)
                .ToList();

            var idAttrs = identifierExpression.Attributes.Select(x => x.Identifier).ToArray();
            var attrObj = new TAttributes();

            foreach (var idAttr in idAttrs)
            {
                var property = properties.SingleOrDefault(x => x.Attribute.Name == idAttr);

                if (property != null)
                {
                    if (property.Property.PropertyType != typeof(bool))
                    {
                        throw new InvalidOperationException();
                    }

                    property.Property.SetValue(attrObj, true, null);
                }
                else
                {
                    property = properties.SingleOrDefault(x => x.Attribute.Name == null);

                    if (property != null)
                    {
                        if (property.Property.PropertyType != typeof(string))
                        {
                            throw new InvalidOperationException();
                        }

                        property.Property.SetValue(attrObj, idAttr, null);
                    }
                    else
                    {
                        unparsedList.Add(idAttr);
                        //throw new InvalidOperationException();
                    }
                }

                properties.Remove(property);
            }

            unparsed = unparsedList.ToArray();

            return attrObj;
        }
    }
}
