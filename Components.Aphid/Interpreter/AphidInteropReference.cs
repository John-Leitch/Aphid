using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Interpreter
{
    public class AphidInteropReference
    {
        public object Object { get; private set; }

        public FieldInfo Field { get; private set; }

        public PropertyInfo Property { get; private set; }

        public AphidInteropReference(object obj, FieldInfo field)
        {
            Object = obj;
            Field = field;
        }

        public AphidInteropReference(object obj, PropertyInfo property)
        {
            Object = obj;
            Property = property;
        }
    }
}
