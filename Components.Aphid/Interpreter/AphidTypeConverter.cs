using Components.External;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Interpreter
{
    public class AphidConversionInfo
    {
        public bool CanConvert { get; private set; }

        public Type[] GenericArguments { get; private set; }

        public AphidConversionInfo(bool canConvert, Type[] genericArguments)
        {
            CanConvert = canConvert;
            GenericArguments = genericArguments;
        }
    }

    public static class AphidTypeConverter
    {
        private static readonly Type[] _decimalTargetTypes = new[]
        {
            typeof(object),
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

        public static object[] Convert(AphidInteropMethodArg[] args)
        {
            return args.Select(Convert).ToArray();
        }

        public static object Convert(AphidInteropMethodArg arg)
        {
            return Convert(arg.TargetType, arg.Argument);
        }

        public static AphidConversionInfo CanConvert(object value, Type targetType)
        {
            var t = value.GetType();
            var genericArguments = new List<Type>();

            var canConvert =
                t == targetType ? true :
                value is decimal ? CanConvertDecimal(targetType) :
                t.IsDerivedFromOrImplements(targetType, genericArguments) ? true :
                false;

            return new AphidConversionInfo(canConvert, genericArguments.ToArray());
                
        }

        public static bool CanConvertDecimal(Type targetType)
        {
            return _decimalTargetTypes.Contains(targetType);
        }

        public static object Convert(Type targetType, object value)
        {
            var t = value.GetType();

            if (t == targetType ||
                t.IsDerivedFromOrImplements(targetType, new List<Type>()))
            {
                return value;
            }
            else if (t == typeof(decimal))
            {
                return Convert(targetType, (decimal)value);
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public static object Convert(Type targetType, decimal value)
        {
            if (targetType == typeof(byte))
            {
                return ToByte(value);
            }
            else if (targetType == typeof(ushort))
            {
                return ToUInt16(value);
            }
            else if (targetType == typeof(uint))
            {
                return ToUInt32(value);
            }
            else if (targetType == typeof(ulong))
            {
                return ToUInt64(value);
            }
            else if (targetType == typeof(short))
            {
                return ToInt16(value);
            }
            else if (targetType == typeof(int))
            {
                return ToInt32(value);
            }
            else if (targetType == typeof(long))
            {
                return ToInt64(value);
            }
            else if (targetType == typeof(float))
            {
                return ToFloat(value);
            }
            else if (targetType == typeof(double))
            {
                return ToFloat(value);
            }
            else if (targetType == typeof(decimal))
            {
                return value;
            }
            else
            {
                throw new NotImplementedException();
            }
        }

        public static byte ToByte(decimal value)
        {
            return (byte)value;
        }

        public static ushort ToUInt16(decimal value)
        {
            return (ushort)value;
        }

        public static uint ToUInt32(decimal value)
        {
            return (uint)value;
        }

        public static ulong ToUInt64(decimal value)
        {
            return (ulong)value;
        }

        public static sbyte ToSByte(decimal value)
        {
            return (sbyte)value;
        }

        public static short ToInt16(decimal value)
        {
            return (short)value;
        }

        public static int ToInt32(decimal value)
        {
            return (int)value;
        }

        public static long ToInt64(decimal value)
        {
            return (long)value;
        }

        public static float ToFloat(decimal value)
        {
            return (float)value;
        }

        public static double ToDouble(decimal value)
        {
            return (double)value;
        }
    }
}
