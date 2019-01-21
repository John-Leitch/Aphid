using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.External
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

        public static bool IsDerivedFrom<TBaseType>(this Type type) => type.IsDerivedFrom(typeof(TBaseType));

        private static bool ShouldDeconstructTypes(Type type)
        {
            return
                !type.IsConstructedGenericType ||
                type.GetGenericArguments().All(x => x.IsGenericParameter);
        }

        private static Type[] GetComparableType(Type sourceType, Type targetType, List<Type> genericArguments)
        {
            var deconstruct =
                sourceType.IsConstructedGenericType &&
                targetType.IsGenericType &&
                (ShouldDeconstructTypes(sourceType) || ShouldDeconstructTypes(targetType));

            if (!deconstruct)
            {
                return new[] { sourceType, targetType };
            }
            else
            {
                if (!sourceType.ContainsGenericParameters)
                {
                    if (genericArguments.Count > 0)
                    {
                        throw new NotImplementedException();
                    }

                    Type targetStripped = targetType.GetGenericTypeDefinition(),
                        sourceStripped = sourceType.GetGenericTypeDefinition();

                    var tmpSource = sourceType;

                    if (targetStripped.IsInterface &&
                        (tmpSource = Array.Find(sourceType
                            .GetInterfaces(), x =>
                                x.IsGenericType &&
                                x.GetGenericTypeDefinition() == targetStripped)) != null)
                    {
                        sourceType = tmpSource;
                    }
                    else
                    {
                        tmpSource = sourceType;
                        //throw new NotImplementedException();
                        while (true)
                        {
                            sourceStripped = sourceType.GetGenericTypeDefinition();

                            if (targetStripped == sourceStripped)
                            {
                                break;
                            }
                            else if ((sourceType = sourceType.BaseType) == null)
                            {
                                sourceType = tmpSource;
                                break;
                            }
                        }
                    }

                    genericArguments.AddRange(sourceType.GetGenericArguments().ToArray());
                }

                return new[] { StripGenericArguments(sourceType), StripGenericArguments(targetType) };
            }
        }

        private static Type StripGenericArguments(Type type)
        {
            while (type.IsConstructedGenericType && type.GetGenericArguments().Length > 0)
            {
                type = type.GetGenericTypeDefinition();
            }

            return type;
        }

        public static bool Implements(this Type type, Type interfaceType, List<Type> genericArguments)
        {
            if (!interfaceType.IsInterface)
            {
                throw new ArgumentException("interfaceType is not an interface.");
            }

            var c = GetComparableType(type, interfaceType, genericArguments);

            type = c[0];
            interfaceType = c[1];

            if (type == interfaceType)
            {
                return true;
            }

            var interfaces = type.GetInterfaces();

            foreach (var parentInterface in interfaces)
            {
                if (parentInterface == interfaceType)
                {
                    genericArguments = null;

                    return true;
                }
                else
                {
                    if (parentInterface.Implements(interfaceType, genericArguments))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool IsDerivedFromOrImplements(this Type type, Type baseType) => type.IsDerivedFromOrImplements(baseType, new List<Type>());

        public static bool IsDerivedFromOrImplements(this Type type, Type baseType, List<Type> genericArguments) => baseType.IsInterface ? type.Implements(baseType, genericArguments) : type.IsDerivedFrom(baseType);

        public static bool IsDerivedFromOrImplements<TBaseType>(this Type type, List<Type> genericArguments) => type.IsDerivedFromOrImplements(typeof(TBaseType), genericArguments);
    }
}
