using System;
using System.Reflection;

namespace Components.Aphid.TypeSystem
{
    public static class ConversionOperator
    {
        public static MethodInfo GetImplicitOperator(Type valueType, Type targetType) =>
            GetConversionOperator(valueType, targetType, isImplicit: true);

        public static MethodInfo GetExplicitOperator(Type valueType, Type targetType) =>
            GetConversionOperator(valueType, targetType, isImplicit: false);

        public static MethodInfo GetConversionOperator(Type valueType, Type targetType, bool isImplicit) => isImplicit
                ? valueType.GetMethod("op_Implicit", new[] { targetType })
                : valueType.GetMethod("op_Explicit", new[] { targetType });
    }
}
