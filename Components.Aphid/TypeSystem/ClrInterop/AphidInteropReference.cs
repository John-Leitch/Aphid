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
        public bool IsStatic
        {
            get { return Object == null; }
        }

        public AphidInteropReferenceType ReferenceType { get; private set; }

        public object Object { get; private set; }

        public string Name { get; private set; }

        public FieldInfo Field { get; private set; }

        public PropertyInfo Property { get; private set; }

        public Type NestedType { get; private set; }

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
            : this(name)
        {
            Object = obj;
        }

        private AphidInteropReference(string name)
        {
            Name = name;
        }
    }
}
