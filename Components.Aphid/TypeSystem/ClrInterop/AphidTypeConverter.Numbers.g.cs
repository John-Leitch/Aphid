using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.TypeSystem
{
    public partial class AphidTypeConverter
    {
        private static readonly Type[] _numberTypes = new[]
        {
            typeof(byte),
            typeof(ushort),
            typeof(uint),
            typeof(ulong),
            typeof(sbyte),
            typeof(short),
            typeof(int),
            typeof(long),
            typeof(float),
            typeof(double)
        };

        public static bool CanConvertOrBoxDecimal(decimal value, Type targetType)
        {
            return targetType == typeof(object) || CanConvertDecimal(value, targetType);
        }

        public static bool CanConvertDecimal(decimal value, Type targetType)
        {
            return IsNumber(targetType) && CanDecimalFit(value, targetType);
        }

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

        //public static bool CanConvertOrBoxSByte(decimal value, Type targetType)
        //{
        //    return targetType == typeof(object) || CanConvertDecimal(value, targetType);
        //}

        //public static bool CanConvertOrBoxShort(decimal value, Type targetType)
        //{
        //    return targetType == typeof(object) || CanConvertDecimal(value, targetType);
        //}

        //public static bool CanConvertOrBoxInt(decimal value, Type targetType)
        //{
        //    return targetType == typeof(object) || CanConvertDecimal(value, targetType);
        //}

        //public static bool CanConvertOrBoxLong(decimal value, Type targetType)
        //{
        //    return targetType == typeof(object) || CanConvertDecimal(value, targetType);
        //}

        //public static bool CanConvertOrBoxByte(decimal value, Type targetType)
        //{
        //    return targetType == typeof(object) || CanConvertDecimal(value, targetType);
        //}

        //public static bool CanConvertOrBoxUShort(decimal value, Type targetType)
        //{
        //    return targetType == typeof(object) || CanConvertDecimal(value, targetType);
        //}

        //public static bool CanConvertOrBoxUInt(decimal value, Type targetType)
        //{
        //    return targetType == typeof(object) || CanConvertDecimal(value, targetType);
        //}

        //public static bool CanConvertOrBoxULong(decimal value, Type targetType)
        //{
        //    return targetType == typeof(object) || CanConvertDecimal(value, targetType);
        //}

        //public static bool CanConvertOrBoxFloat(decimal value, Type targetType)
        //{
        //    return targetType == typeof(object) || CanConvertDecimal(value, targetType);
        //}

        //public static bool CanConvertOrBoxDouble(decimal value, Type targetType)
        //{
        //    return targetType == typeof(object) || CanConvertDecimal(value, targetType);
        //}

        
    }
}
