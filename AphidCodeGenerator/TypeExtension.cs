using System;
using System.Linq;

namespace AphidCodeGenerator
{
    public static class TypeExtension
    {
        public static bool IsDerivedFrom(this Type type, Type baseType)
        {
            if (type.BaseType != null && type.BaseType == baseType)
            {
                return true;
            }
            else if (type.BaseType != null)
            {
                return type.BaseType.IsDerivedFrom(baseType);
            }
            else
            {
                return false;
            }
        }

        public static bool IsDerivedFrom<TBaseType>(this Type type)
        {
            return type.IsDerivedFrom(typeof(TBaseType));
        }

        public static bool Implements(this Type type, Type interfaceType)
        {
            if (!interfaceType.IsInterface)
            {
                throw new ArgumentException("interfaceType is not an interface.");
            }

            return type.GetInterfaces().Any(x => x == interfaceType);
        }

        public static bool Implements<TInterface>(this Type type)
        {
            return type.Implements(typeof(TInterface));
        }

        public static bool IsDerivedFromOrImplements(this Type type, Type baseType)
        {
            return baseType.IsInterface ? type.Implements(baseType) : type.IsDerivedFrom(baseType);
        }

        public static bool IsDerivedFromOrImplements<TBaseType>(this Type type)
        {
            return type.IsDerivedFromOrImplements(typeof(TBaseType));
        }
    }
}
