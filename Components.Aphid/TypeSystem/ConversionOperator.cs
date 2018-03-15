using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.TypeSystem
{
    public static class ConversionOperator
    {
        public static MethodInfo GetImplicitOperator(Type valueType, Type targetType)
        {
            return GetConversionOperator(valueType, targetType, isImplicit: true);
        }

        public static MethodInfo GetExplicitOperator(Type valueType, Type targetType)
        {
            return GetConversionOperator(valueType, targetType, isImplicit: false);
        }

        public static MethodInfo GetConversionOperator(
            Type valueType,
            Type targetType,
            bool isImplicit)
        {
            return valueType.GetMethod(
                isImplicit ? "op_Implicit" : "op_Explicit",
                new[] { targetType });
        }
    }
}
