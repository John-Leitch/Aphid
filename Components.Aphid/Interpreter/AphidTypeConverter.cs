using Components.External;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

    public class AphidTypeConverter : AphidInterpreterComponent
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

        public AphidTypeConverter(AphidInterpreter interpreter)
            : base(interpreter)
        {
        }
            

        public object[] Convert(AphidInteropMethodArg[] args)
        {
            return args.Select(Convert).ToArray();
        }

        public object Convert(AphidInteropMethodArg arg)
        {
            return Convert(arg.TargetType, arg.Argument);
        }

        public AphidConversionInfo CanConvert(
            MethodBase method,
            object value,
            Type targetType)
        {
            Type valueType;

            if (value == null)
            {
                return new AphidConversionInfo(
                    !targetType.IsPrimitive && !targetType.IsEnum,
                    new Type[0]);
            }
            else if ((valueType = value.GetType()) == typeof(AphidFunction) &&
                targetType.IsDerivedFrom(typeof(Delegate)))
            {
                return new AphidConversionInfo(true, new Type[0]);
            }
            else
            {
                var genericArguments = new List<Type>();

                var canConvert =
                    valueType == targetType ? true :
                    valueType == typeof(decimal) ? CanConvertOrBoxDecimal((decimal)value, targetType) :
                    valueType == typeof(string) && targetType == typeof(char) && ((string)value).Length == 1 ? true :
                    valueType.IsDerivedFromOrImplements(targetType, genericArguments) ? true :
                    targetType.IsArray ? CanConvertArray(value, valueType, targetType) :
                    false;

                return new AphidConversionInfo(canConvert, genericArguments.ToArray());
            }
        }

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

        public static bool IsNumber(Type targetType)
        {
            return _numberTypes.Contains(targetType);
        }

        public bool CanConvertArray(object value, Type valueType, Type targetType)
        {
            if (valueType == targetType)
            {
                return true;
            }

            //if (valueType == typeof(string) && targetType != typeof(char[]))
            //{
            //    return false;
            //}
            //else if (valueType.IsArray && targetType == typeof(string[]))
            //{
            //    return true;
            //}

            var valueCollection = value as IEnumerable;

            if (valueCollection == null)
            {
                return false;
            }

            var valueArray = valueCollection.OfType<object>().ToArray();

            if (valueArray.Length == 0)
            {
                return true;
            }

            var valueElementTypes = valueArray.Select(x => x.GetType()).Distinct().ToArray();
            var targetElementType = targetType.GetElementType();

            if (valueElementTypes.Length == 1)
            {
                var t = valueElementTypes[0];

                return t == targetElementType || t.IsDerivedFromOrImplements(targetElementType);
            }

            return false;
        }

        public object Convert(Type targetType, object srcValue)
        {
            Type srcType;

            if (srcValue == null)
            {
                return null;
            }
            else if (targetType.IsDerivedFrom<Delegate>())
            {
                return Interpreter.FunctionConverter.Convert(targetType, srcValue);
            }
            else if ((srcType = srcValue.GetType()) == targetType ||
                srcType.IsDerivedFromOrImplements(targetType, new List<Type>()))
            {
                return srcValue;
            }
            else if (srcType == typeof(decimal))
            {
                return Convert(targetType, (decimal)srcValue);
            }
            else if (srcType.IsArray)
            {
                return ConvertArray(targetType, srcType, (Array)srcValue);
            }
            else if (srcType == typeof(string))
            {
                var s = ((string)srcValue);

                if (targetType == typeof(char))
                {
                    if (s.Length != 1)
                    {
                        throw Interpreter.CreateRuntimeException(
                            "Cannot convert string '{0}' to char due to length.",
                            s);
                    }

                    return s[0];

                }
                else if (targetType == typeof(char[]))
                {
                    return s.ToCharArray();
                }
                else
                {
                    throw GetConversionError(srcValue, srcType, targetType);
                }
            }
            else
            {
                throw GetConversionError(srcValue, srcType, targetType);
            }
        }

        public object Convert(Type targetType, decimal value)
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

        public object ConvertArray(Type targetType, Type srcArrayType, Array srcArray)
        {
            if (targetType == srcArrayType)
            {
                return srcArrayType;
            }
            else if (targetType != typeof(string[]))
            {
                var dst = Array.CreateInstance(targetType.GetElementType(), srcArray.Length);
                srcArray.CopyTo(dst, 0);

                return dst;
            }
            else
            {
                var s = new string[srcArray.Length];

                for (var i = 0; i < s.Length; i++)
                {
                    s[i] = srcArray.GetValue(i).ToString();
                }

                return s;
            }
        }

        public byte ToByte(decimal value)
        {
            return (byte)value;
        }

        public ushort ToUInt16(decimal value)
        {
            return (ushort)value;
        }

        public uint ToUInt32(decimal value)
        {
            return (uint)value;
        }

        public ulong ToUInt64(decimal value)
        {
            return (ulong)value;
        }

        public sbyte ToSByte(decimal value)
        {
            return (sbyte)value;
        }

        public short ToInt16(decimal value)
        {
            return (short)value;
        }

        public int ToInt32(decimal value)
        {
            return (int)value;
        }

        public long ToInt64(decimal value)
        {
            return (long)value;
        }

        public float ToFloat(decimal value)
        {
            return (float)value;
        }

        public double ToDouble(decimal value)
        {
            return (double)value;
        }

        private AphidRuntimeException GetConversionError(object value, Type valueType, Type targetType)
        {
            return Interpreter.CreateRuntimeException(
                "Cannot convert '{0}' from type {1} to {2}.",
                value,
                valueType,
                targetType);
        }
    }
}
