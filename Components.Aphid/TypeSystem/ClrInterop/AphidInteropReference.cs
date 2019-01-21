using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.TypeSystem
{
    public class AphidInteropReference
    {
        public bool IsStatic => Object == null;

        public AphidInteropReferenceType ReferenceType { get; }

        public object Object { get; }

        public string Name { get; }

        public FieldInfo Field { get; }

        public PropertyInfo Property { get; }

        public Type NestedType { get; }

        public AphidInteropReference(object obj, FieldInfo field)
            : this(obj, field.Name)
        {
            ReferenceType = AphidInteropReferenceType.Field;
            Object = obj;
            Field = field;
            Name = field.Name;
        }

        public AphidInteropReference(object obj, PropertyInfo property)
            : this(obj, property.Name)
        {
            ReferenceType = AphidInteropReferenceType.Property;
            Property = property;
        }

        public AphidInteropReference(Type nestedType)
            : this(nestedType.Name)
        {
            ReferenceType = AphidInteropReferenceType.NestedType;
            NestedType = nestedType;
        }

        private AphidInteropReference(object obj, string name)
            : this(name) => Object = obj;

        private AphidInteropReference(string name) => Name = name;
    }
}
