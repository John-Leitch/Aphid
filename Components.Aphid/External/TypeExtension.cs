using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
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

        private static bool ShouldDeconstructTypes(Type type)
        {
            return
                !type.IsConstructedGenericType || 
                type.GetGenericArguments().All(x => x.IsGenericParameter);
        }

        private static Type[] GetComparableType(Type type, Type otherType, out Type[] genericArguments)
        {
            var deconstruct = 
                type.IsConstructedGenericType &&
                otherType.IsGenericType &&
                (ShouldDeconstructTypes(type) || ShouldDeconstructTypes(otherType));

            if (!deconstruct)
            {
                genericArguments = null;

                return new[] { type, otherType };
            }
            else
            {
                genericArguments = type.GetGenericArguments();

                return new[] { type.GetGenericTypeDefinition(), otherType.GetGenericTypeDefinition() };
            }
        }

        public static bool Implements(this Type type, Type interfaceType, out Type[] genericArguments)
        {
            if (!interfaceType.IsInterface)
            {
                throw new ArgumentException("interfaceType is not an interface.");
            }

            var c = GetComparableType(type, interfaceType, out genericArguments);

            type = c[0];
            interfaceType = c[1];

            if (type == interfaceType)
            {
                return true;
            }

            var interfaces = type.GetInterfaces();

            foreach (var parentInterface in type.GetInterfaces())
            {
                if (parentInterface == interfaceType)
                {
                    genericArguments = null;

                    return true;
                }
                else
                {
                    if (parentInterface.Implements(interfaceType, out genericArguments))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool IsDerivedFromOrImplements(this Type type, Type baseType, out Type[] genericArguments)
        {
            genericArguments = null;

            return baseType.IsInterface ? type.Implements(baseType, out genericArguments) : type.IsDerivedFrom(baseType);
        }

        public static bool IsDerivedFromOrImplements<TBaseType>(this Type type, out Type[] genericArguments)
        {
            return type.IsDerivedFromOrImplements(typeof(TBaseType), out genericArguments);
        }
    }
}
