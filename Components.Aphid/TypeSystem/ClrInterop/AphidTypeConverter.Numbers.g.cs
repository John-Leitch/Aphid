using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.TypeSystem
{
    public partial class AphidTypeConverter
    {
        public static bool CanConvertOrBoxDecimal(decimal value, Type targetType) =>
            targetType == typeof(object) || CanConvertDecimal(value, targetType);

        public static bool CanConvertDecimal(decimal value, Type targetType) =>
            IsNumber(targetType) && CanDecimalFit(value, targetType);

        public static bool CanDecimalFit(decimal value, Type targetType)
        {
            if (targetType == typeof(byte))
            {
                return byte.MinValue <= value && value <= byte.MaxValue;
            }
            else if (targetType == typeof(ushort))
            {
                return ushort.MinValue <= value && value <= ushort.MaxValue;
            }
            else if (targetType == typeof(uint))
            {
                return uint.MinValue <= value && value <= uint.MaxValue;
            }
            else if (targetType == typeof(ulong))
            {
                return ulong.MinValue <= value && value <= ulong.MaxValue;
            }
            else if (targetType == typeof(sbyte))
            {
                return sbyte.MinValue <= value && value <= sbyte.MaxValue;
            }
            else if (targetType == typeof(short))
            {
                return short.MinValue <= value && value <= short.MaxValue;
            }
            else if (targetType == typeof(int))
            {
                return int.MinValue <= value && value <= int.MaxValue;
            }
            else if (targetType == typeof(long))
            {
                return long.MinValue <= value && value <= long.MaxValue;
            }
            else if (targetType == typeof(float) || targetType == typeof(double))
            {
                return true;
            }
            else
            {
                throw new NotImplementedException("Unknown number type: " + targetType);
            }
        }
    }
}
