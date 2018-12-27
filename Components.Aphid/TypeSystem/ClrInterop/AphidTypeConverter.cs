using Components.Aphid.Interpreter;
using Components.External;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using static System.Convert;

namespace Components.Aphid.TypeSystem
{
    public partial class AphidTypeConverter : AphidRuntimeComponent
    {
        public AphidTypeConverter(AphidInterpreter interpreter)
            : base(interpreter)
        {
        }

        public object[] Convert(AphidInteropMethodArg[] args, Type[] genericArguments)
        {
            var converted = new object[args.Length];

            for (var i = 0; i < args.Length; i++)
            {
                converted[i] = Convert(args[i], genericArguments);
            }

            return converted;
        }

        public object Convert(AphidInteropMethodArg arg, Type[] genericArguments)
        {
            return arg.ImplicitConversionOperator != null ?
                    Convert(arg.ImplicitConversionOperator, arg.Argument) :
                arg.ExplicitConversionOperator != null ?
                    Convert(arg.ExplicitConversionOperator, arg.Argument) :
                arg.IsValueTypeEnumerable &&
                    genericArguments.Length >= 1 &&
                    !genericArguments[0].IsValueType ?
                    BoxValueTypeEnumerable((IEnumerable)arg.Argument) :
                Convert(arg.TargetType, arg.Argument, genericArguments);
        }

        public IEnumerable<object> BoxValueTypeEnumerable(IEnumerable valueTypeSource)
        {
            return valueTypeSource.Cast<object>();
        }

        public object Convert(MethodBase opMethod, object argument)
        {
            // Todo: possible optimization via delegate memoization.
            return opMethod.Invoke(null, new[] { argument });
        }

        public AphidConversionInfo CanConvert(
            AphidInteropMethodArg interopArg,
            MethodBase method,
            object val,
            Type target)
        {
            Type valType;

            if (val == null)
            {
                return new AphidConversionInfo(
                    interopArg,
                    !target.IsPrimitive && !target.IsEnum,
                    new Type[0]);
            }
            else if ((valType = val.GetType()) == typeof(AphidFunction) &&
                target.IsDerivedFrom(typeof(Delegate)))
            {
                var isGeneric = target.IsGenericType;

                if (isGeneric)
                {
                    var targetGenericArgs = target.GetGenericArguments();
                    var valGenericArgs = valType.GetGenericArguments();

                    if (targetGenericArgs.Length > 0 && valGenericArgs.Length == 0)
                    {
                        for (var i = 0; i < targetGenericArgs.Length; i++)
                        {
                            if (targetGenericArgs[i].IsGenericParameter)
                            {
                                targetGenericArgs[i] = typeof(object);
                            }
                        }

                        return new AphidConversionInfo(
                            interopArg,
                            true,
                            targetGenericArgs);
                    }

                    throw this.Interpreter.CreateRuntimeException(
                        "Converting from generic delegate {0} to {1} not yet supported.",
                        valType,
                        target);
                }
                else
                {
                    return new AphidConversionInfo(interopArg, true, new Type[0]);
                }
            }
            else
            {
                var genericArguments = new List<Type>();

                var canConvert =
                    valType == target ? true :
                    interopArg.ImplicitConversionOperator != null ? true :
                    valType == typeof(decimal) ? CanConvertOrBoxDecimal((decimal)val, target) :
                    //valType == typeof(sbyte) ? CanConvertOrBoxSByte((decimal)val, target) :
                    //valType == typeof(short) ? CanConvertOrBoxShort((decimal)val, target) :
                    //valType == typeof(int) ? CanConvertOrBoxInt((decimal)val, target) :
                    //valType == typeof(long) ? CanConvertOrBoxLong((decimal)val, target) :
                    //valType == typeof(byte) ? CanConvertOrBoxByte((decimal)val, target) :
                    //valType == typeof(ushort) ? CanConvertOrBoxUShort((decimal)val, target) :
                    //valType == typeof(uint) ? CanConvertOrBoxUInt((decimal)val, target) :
                    //valType == typeof(ulong) ? CanConvertOrBoxULong((decimal)val, target) :
                    //valType == typeof(float) ? CanConvertOrBoxFloat((decimal)val, target) :
                    //valType == typeof(double) ? CanConvertOrBoxDouble((decimal)val, target) :
                    valType == typeof(string) &&
                        (target == typeof(char[]) ||
                        (target == typeof(char) && ((string)val).Length == 1)) ? true :
                    valType.IsDerivedFromOrImplements(target, genericArguments) ? true :
                    target.IsArray ? CanConvertArray(val, valType, target) :
                    interopArg.ExplicitConversionOperator != null ? true :
                    target == typeof(string) ? true :
                    false;

                return new AphidConversionInfo(
                    interopArg,
                    canConvert,
                    genericArguments.ToArray());
            }
        }

        public static bool IsNumber(Type targetType)
        {
            return
                targetType == typeof(byte) ||
                targetType == typeof(ushort) ||
                targetType == typeof(uint) ||
                targetType == typeof(ulong) ||
                targetType == typeof(sbyte) ||
                targetType == typeof(short) ||
                targetType == typeof(int) ||
                targetType == typeof(long) ||
                targetType == typeof(float) ||
                targetType == typeof(double);
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

        public object Convert(Type targetType, object srcValue, Type[] genericArguments)
        {
            Type srcType;
            var targetGenerics = new List<Type>();

            if (srcValue == null)
            {
                return null;
            }
            else if (targetType.IsDerivedFrom<Delegate>())
            {
                return Interpreter.FunctionConverter.Convert(
                    targetType,
                    srcValue,
                    genericArguments);
            }
            else if ((srcType = srcValue.GetType()) == targetType ||
                srcType.IsDerivedFromOrImplements(targetType, targetGenerics))
            {
                return srcValue;
            }
            else if (srcType == typeof(decimal))
            {
                return Convert(targetType, (decimal)srcValue);
            }
            else if (targetType == typeof(decimal))
            {
                return ChangeType(srcValue, typeof(decimal));
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
            else if (targetType == typeof(string))
            {
                return srcValue.ToString();
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
            else if (targetType == typeof(string))
            {
                return value.ToString();
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
