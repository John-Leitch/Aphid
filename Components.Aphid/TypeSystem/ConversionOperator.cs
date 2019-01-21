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
        public static MethodInfo GetImplicitOperator(Type valueType, Type targetType) =>
            GetConversionOperator(valueType, targetType, isImplicit: true);

        public static MethodInfo GetExplicitOperator(Type valueType, Type targetType) =>
            GetConversionOperator(valueType, targetType, isImplicit: false);

        public static MethodInfo GetConversionOperator(Type valueType, Type targetType, bool isImplicit)
        {
            if (isImplicit)
            {
                return valueType.GetMethod("op_Implicit", new[] { targetType });
            }
            else
            {
                return valueType.GetMethod("op_Explicit", new[] { targetType });
            }
        }
    }
}
