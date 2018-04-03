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

        public FieldInfo Field { get; private set; }

        public PropertyInfo Property { get; private set; }

        public Type NestedType { get; private set; }

        public AphidInteropReference(object obj, FieldInfo field)
        {
            ReferenceType = AphidInteropReferenceType.Field;
            Object = obj;
            Field = field;
        }

        public AphidInteropReference(object obj, PropertyInfo property)
        {
            ReferenceType = AphidInteropReferenceType.Property;
            Object = obj;
            Property = property;
        }

        public AphidInteropReference(Type nestedType)
        {
            ReferenceType = AphidInteropReferenceType.NestedType;
            NestedType = nestedType;
        }
    }
}
