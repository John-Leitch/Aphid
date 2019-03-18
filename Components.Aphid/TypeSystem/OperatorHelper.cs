using Components.Aphid.Interpreter;
using System;
using System.Linq;
using System.Text;

namespace Components.Aphid.TypeSystem
{
    public class OperatorHelper : AphidRuntimeComponent
    {
        public OperatorHelper(AphidInterpreter interpreter)
            : base(interpreter)
        {
        }

        public AphidObject Add(AphidObject x, AphidObject y)
        {
            if (x == null || y == null)
            {
                throw CreateOperationException("addition");
            }
            else if (x.Value is decimal dx && y.Value is decimal dy)
            {
                return AphidObject.Scalar(dx + dy);
            }
            else if ((x.Value is sbyte ||
                x.Value is short ||
                x.Value is int ||
                x.Value is long ||
                x.Value is byte ||
                x.Value is ushort ||
                x.Value is uint ||
                x.Value is ulong ||
                x.Value is float ||
                x.Value is double ||
                x.Value is decimal) &&
                (y.Value is sbyte ||
                y.Value is short ||
                y.Value is int ||
                y.Value is long ||
                y.Value is byte ||
                y.Value is ushort ||
                y.Value is uint ||
                y.Value is ulong ||
                y.Value is float ||
                y.Value is double ||
                y.Value is decimal))
            {
                return AphidObject.Scalar(Convert.ToDecimal(x.Value) + Convert.ToDecimal(y.Value));
            }
            else
            {
                return AphidObject.Scalar(Convert.ToString(x.Value) + Convert.ToString(y.Value));
            }
        }

        public AphidObject Mod(AphidObject x, AphidObject y)
        {
            if (x == null || y == null)
            {
                throw CreateOperationException("modulo");
            }

            return AphidObject.Scalar(Convert.ToDecimal(x.Value) % Convert.ToDecimal(y.Value));
        }

        public AphidObject BinaryOr(AphidObject x, AphidObject y)
        {
            Type t;

            if (x == null || y == null)
            {
                throw CreateOperationException("binary or");
            }
            else if (!(t = x.Value.GetType()).IsEnum)
            {
                return AphidObject.Scalar((decimal)((long)(decimal)x.Value | (long)(decimal)y.Value));
            }
            else
            {
                //var underlyingType = Enum.GetUnderlyingType(t);

                var o = Enum.ToObject(
                    t,
                    Convert.ToUInt64(x.Value) | Convert.ToUInt64(y.Value));

                return AphidObject.Scalar(o);
            }
        }

        public AphidObject BinaryAnd(AphidObject x, AphidObject y)
        {
            Type xType, yType, xBaseType, yBaseType;

            if (x == null || y == null || x.Value == null || y.Value == null)
            {
                throw CreateOperationException("binary and");
            }
            else if ((xType = x.Value.GetType()).IsEnum &&
                (yType = y.Value.GetType()).IsEnum)
            {
                if ((xBaseType = Enum.GetUnderlyingType(xType)) !=
                    (yBaseType = Enum.GetUnderlyingType(yType)))
                {
                    throw Interpreter.CreateRuntimeException(
                        "Enum type mismatch, cannot perform binary operations on " +
                            "enums with different underlying ytpes: {0} and {1}",
                        xBaseType.FullName,
                        yBaseType.FullName);
                }
                else if (xBaseType == typeof(byte))
                {
                    return AphidObject.Scalar(
                        Enum.ToObject(
                            xType,
                            (byte)x.Value & (byte)y.Value));
                }
                else if (xBaseType == typeof(ushort))
                {
                    return AphidObject.Scalar(
                        Enum.ToObject(
                            xType,
                            (ushort)x.Value & (ushort)y.Value));
                }
                else if (xBaseType == typeof(uint))
                {
                    return AphidObject.Scalar(
                        Enum.ToObject(
                            xType,
                            (uint)x.Value & (uint)y.Value));
                }
                else if (xBaseType == typeof(ulong))
                {
                    return AphidObject.Scalar(
                        Enum.ToObject(
                            xType,
                            (ulong)x.Value & (ulong)y.Value));
                }
                else if (xBaseType == typeof(sbyte))
                {
                    return AphidObject.Scalar(
                        Enum.ToObject(
                            xType,
                            (sbyte)x.Value & (sbyte)y.Value));
                }
                else if (xBaseType == typeof(short))
                {
                    return AphidObject.Scalar(
                        Enum.ToObject(
                            xType,
                            (short)x.Value & (short)y.Value));
                }
                else if (xBaseType == typeof(int))
                {
                    return AphidObject.Scalar(
                        Enum.ToObject(
                            xType,
                            (int)x.Value & (int)y.Value));
                }
                else if (xBaseType == typeof(long))
                {
                    return AphidObject.Scalar(
                        Enum.ToObject(
                            xType,
                            (long)x.Value & (long)y.Value));
                }
                else
                {
                    throw Interpreter.CreateRuntimeException(
                        "Unsupported underlying type: {0}",
                        xBaseType);
                }
            }
            else
            {
                // Todo: Perform proper type checking and conversion by
                // branching on both lhs and rhs type.
                return AphidObject.Scalar((decimal)((long)(decimal)x.Value & (long)(decimal)y.Value));
            }
        }

        public AphidObject BinaryShiftLeft(AphidObject x, AphidObject y)
        {
            if (x == null || y == null)
            {
                throw CreateOperationException("binary shift left");
            }

            return AphidObject.Scalar((decimal)((int)(decimal)x.Value << (int)(decimal)y.Value));
        }

        public AphidObject BinaryShiftRight(AphidObject x, AphidObject y)
        {
            if (x == null || y == null)
            {
                throw CreateOperationException("binary shift right");
            }

            return AphidObject.Scalar((decimal)((int)(decimal)x.Value >> (int)(decimal)y.Value));
        }

        public AphidObject Xor(AphidObject x, AphidObject y)
        {
            if (x == null || y == null)
            {
                throw CreateOperationException("exclusive or");
            }

            return AphidObject.Scalar((decimal)((int)(decimal)x.Value ^ (int)(decimal)y.Value));
        }

        public AphidObject Subtract(AphidObject x, AphidObject y)
        {
            if (x == null || y == null)
            {
                throw CreateOperationException("subtraction");
            }

            return AphidObject.Scalar(Convert.ToDecimal(x.Value) - Convert.ToDecimal(y.Value));
        }

        private static AphidObject Repeat(string value, decimal count)
        {
            var sb = new StringBuilder();

            for (var i = 0; i < count; i++)
            {
                sb.Append(value);
            }

            return AphidObject.Scalar(sb.ToString());
        }

        public AphidObject Multiply(AphidObject x, AphidObject y)
        {
            if (x == null || y == null)
            {
                throw CreateOperationException("multiplication");
            }

            object val;

            if (x.Value is decimal && y.Value is decimal)
            {
                val = ((decimal)x.Value) * (decimal)y.Value;
            }
            else if (x.Value is string && y.Value is decimal)
            {
                return Repeat((string)x.Value, (decimal)y.Value);
            }
            else if (x.Value is decimal && y.Value is string)
            {
                return Repeat((string)y.Value, (decimal)x.Value);
            }
            else
            {
                // Todo: check if values are numeric and convert, otherwise
                // throw the following exception.
                // throw new AphidRuntimeException("Could not multiply type");

                return AphidObject.Scalar(Convert.ToDecimal(x.Value) * Convert.ToDecimal(y.Value));
            }

            return AphidObject.Scalar(val);
        }

        public AphidObject Divide(AphidObject x, AphidObject y)
        {
            if (x == null || y == null)
            {
                throw CreateOperationException("division");
            }

            return AphidObject.Scalar(Convert.ToDecimal(x.Value) / Convert.ToDecimal(y.Value));
        }

        public AphidObject Range(AphidObject x, AphidObject y)
        {
            if (x == null || y == null)
            {
                throw CreateOperationException("range");
            }

            return AphidObject
                .Scalar(
                    Enumerable
                        .Range(Convert.ToInt32(x.Value), Convert.ToInt32(y.Value))
                        .Select(Convert.ToDecimal));
        }

        public static bool EqualsCore(AphidObject x, AphidObject y)
        {
            if (x.Value != null)
            {
                return x.Value.Equals(y.Value);
            }

            return null == y.Value && x.Count == 0 && y.Count == 0;
        }

        public static AphidObject Equals(AphidObject x, AphidObject y) =>
            AphidObject.Scalar(EqualsCore(x, y));

        public static AphidObject NotEqual(AphidObject x, AphidObject y) =>
            AphidObject.Scalar(!EqualsCore(x, y));

        private AphidOperationException CreateOperationException(string op) =>
            new AphidOperationException(
                Interpreter,
                Interpreter.CurrentScope,
                Interpreter.CurrentStatement,
                Interpreter.CurrentExpression,
                op);

        //public bool Equals(object left, object right) => Equals(Interpreter, left, right);

        public static bool Equals(AphidInterpreter instance, object left, object right)
        {
            switch (left)
            {
                case System.SByte l:
                {
                    switch (right)
                    {
                        case System.SByte r:
                        {
                            return l == r;
                        }
                        case System.Byte r:
                        {
                            return l == r;
                        }
                        case System.Int16 r:
                        {
                            return l == r;
                        }
                        case System.UInt16 r:
                        {
                            return l == r;
                        }
                        case System.Int32 r:
                        {
                            return l == r;
                        }
                        case System.UInt32 r:
                        {
                            return l == r;
                        }
                        case System.Int64 r:
                        {
                            return l == r;
                        }
                        case System.UInt64 r:
                        {
                            throw instance.CreateRuntimeException(
                                "Cannot compare System.SByte to System.UInt64");
                        }
                        case System.Single r:
                        {
                            return l == r;
                        }
                        case System.Double r:
                        {
                            return l == r;
                        }
                        case System.Decimal r:
                        {
                            return l == r;
                        }
                        default:
                        {
                            return left.Equals(right);
                        }
                    }
                }

                case System.Byte l:
                {
                    switch (right)
                    {
                        case System.SByte r:
                        {
                            return l == r;
                        }
                        case System.Byte r:
                        {
                            return l == r;
                        }
                        case System.Int16 r:
                        {
                            return l == r;
                        }
                        case System.UInt16 r:
                        {
                            return l == r;
                        }
                        case System.Int32 r:
                        {
                            return l == r;
                        }
                        case System.UInt32 r:
                        {
                            return l == r;
                        }
                        case System.Int64 r:
                        {
                            return l == r;
                        }
                        case System.UInt64 r:
                        {
                            return l == r;
                        }
                        case System.Single r:
                        {
                            return l == r;
                        }
                        case System.Double r:
                        {
                            return l == r;
                        }
                        case System.Decimal r:
                        {
                            return l == r;
                        }
                        default:
                        {
                            return left.Equals(right);
                        }
                    }
                }

                case System.Int16 l:
                {
                    switch (right)
                    {
                        case System.SByte r:
                        {
                            return l == r;
                        }
                        case System.Byte r:
                        {
                            return l == r;
                        }
                        case System.Int16 r:
                        {
                            return l == r;
                        }
                        case System.UInt16 r:
                        {
                            return l == r;
                        }
                        case System.Int32 r:
                        {
                            return l == r;
                        }
                        case System.UInt32 r:
                        {
                            return l == r;
                        }
                        case System.Int64 r:
                        {
                            return l == r;
                        }
                        case System.UInt64 r:
                        {
                            throw instance.CreateRuntimeException("Cannot compare System.Int16 to System.UInt64");
                        }
                        case System.Single r:
                        {
                            return l == r;
                        }
                        case System.Double r:
                        {
                            return l == r;
                        }
                        case System.Decimal r:
                        {
                            return l == r;
                        }
                        default:
                        {
                            return left.Equals(right);
                        }
                    }
                }

                case System.UInt16 l:
                {
                    switch (right)
                    {
                        case System.SByte r:
                        {
                            return l == r;
                        }
                        case System.Byte r:
                        {
                            return l == r;
                        }
                        case System.Int16 r:
                        {
                            return l == r;
                        }
                        case System.UInt16 r:
                        {
                            return l == r;
                        }
                        case System.Int32 r:
                        {
                            return l == r;
                        }
                        case System.UInt32 r:
                        {
                            return l == r;
                        }
                        case System.Int64 r:
                        {
                            return l == r;
                        }
                        case System.UInt64 r:
                        {
                            return l == r;
                        }
                        case System.Single r:
                        {
                            return l == r;
                        }
                        case System.Double r:
                        {
                            return l == r;
                        }
                        case System.Decimal r:
                        {
                            return l == r;
                        }
                        default:
                        {
                            return left.Equals(right);
                        }
                    }
                }

                case System.Int32 l:
                {
                    switch (right)
                    {
                        case System.SByte r:
                        {
                            return l == r;
                        }
                        case System.Byte r:
                        {
                            return l == r;
                        }
                        case System.Int16 r:
                        {
                            return l == r;
                        }
                        case System.UInt16 r:
                        {
                            return l == r;
                        }
                        case System.Int32 r:
                        {
                            return l == r;
                        }
                        case System.UInt32 r:
                        {
                            return l == r;
                        }
                        case System.Int64 r:
                        {
                            return l == r;
                        }
                        case System.UInt64 r:
                        {
                            throw instance.CreateRuntimeException("Cannot compare System.Int32 to System.UInt64");
                        }
                        case System.Single r:
                        {
                            return l == r;
                        }
                        case System.Double r:
                        {
                            return l == r;
                        }
                        case System.Decimal r:
                        {
                            return l == r;
                        }

                        default:
                            return left.Equals(right);
                    }

                    //case System.SByte r:
                    //{
                    //    return l == r;
                    //}
                    //case System.Byte r:
                    //{
                    //    return l == r;
                    //}
                    //case System.Int16 r:
                    //{
                    //    return l == r;
                    //}
                    //case System.UInt16 r:
                    //{
                    //    return l == r;
                    //}
                    //case System.Int32 r:
                    //{
                    //    return l == r;
                    //}
                    //case System.UInt32 r:
                    //{
                    //    return l == r;
                    //}
                    //case System.Int64 r:
                    //{
                    //    return l == r;
                    //}
                    //case System.UInt64 r:
                    //{
                    //    throw instance.CreateRuntimeException("Cannot compare System.Int32 to System.UInt64");
                    //}
                    //case System.Single r:
                    //{
                    //    return l == r;
                    //}
                    //case System.Double r:
                    //{
                    //    return l == r;
                    //}
                    //case System.Decimal r:
                    //{
                    //    return l == r;
                    //}
                    //else
                    //{
                    //    return left.Equals(right);
                    //}
                }

                case System.UInt32 l:
                {
                    switch (right)
                    {
                        case System.SByte r:
                        {
                            return l == r;
                        }
                        case System.Byte r:
                        {
                            return l == r;
                        }
                        case System.Int16 r:
                        {
                            return l == r;
                        }
                        case System.UInt16 r:
                        {
                            return l == r;
                        }
                        case System.Int32 r:
                        {
                            return l == r;
                        }
                        case System.UInt32 r:
                        {
                            return l == r;
                        }
                        case System.Int64 r:
                        {
                            return l == r;
                        }
                        case System.UInt64 r:
                        {
                            return l == r;
                        }
                        case System.Single r:
                        {
                            return l == r;
                        }
                        case System.Double r:
                        {
                            return l == r;
                        }
                        case System.Decimal r:
                        {
                            return l == r;
                        }
                        default:
                        {
                            return left.Equals(right);
                        }
                    }
                }

                case System.Int64 l:
                {
                    switch (right)
                    {
                        case System.SByte r:
                        {
                            return l == r;
                        }
                        case System.Byte r:
                        {
                            return l == r;
                        }
                        case System.Int16 r:
                        {
                            return l == r;
                        }
                        case System.UInt16 r:
                        {
                            return l == r;
                        }
                        case System.Int32 r:
                        {
                            return l == r;
                        }
                        case System.UInt32 r:
                        {
                            return l == r;
                        }
                        case System.Int64 r:
                        {
                            return l == r;
                        }
                        case System.UInt64 r:
                        {
                            throw instance.CreateRuntimeException("Cannot compare System.Int64 to System.UInt64");
                        }
                        case System.Single r:
                        {
                            return l == r;
                        }
                        case System.Double r:
                        {
                            return l == r;
                        }
                        case System.Decimal r:
                        {
                            return l == r;
                        }
                        default:
                        {
                            return left.Equals(right);
                        }
                    }
                }

                case System.UInt64 l:
                {
                    switch (right)
                    {
                        case System.SByte r:
                        {
                            throw instance.CreateRuntimeException("Cannot compare System.UInt64 to System.SByte");
                        }
                        case System.Byte r:
                        {
                            return l == r;
                        }
                        case System.Int16 r:
                        {
                            throw instance.CreateRuntimeException("Cannot compare System.UInt64 to System.Int16");
                        }
                        case System.UInt16 r:
                        {
                            return l == r;
                        }
                        case System.Int32 r:
                        {
                            throw instance.CreateRuntimeException("Cannot compare System.UInt64 to System.Int32");
                        }
                        case System.UInt32 r:
                        {
                            return l == r;
                        }
                        case System.Int64 r:
                        {
                            throw instance.CreateRuntimeException("Cannot compare System.UInt64 to System.Int64");
                        }
                        case System.UInt64 r:
                        {
                            return l == r;
                        }
                        case System.Single r:
                        {
                            return l == r;
                        }
                        case System.Double r:
                        {
                            return l == r;
                        }
                        case System.Decimal r:
                        {
                            return l == r;
                        }
                        default:
                        {
                            return left.Equals(right);
                        }
                    }
                }

                case System.Single l:
                {
                    switch (right)
                    {
                        case System.SByte r:
                        {
                            return l == r;
                        }
                        case System.Byte r:
                        {
                            return l == r;
                        }
                        case System.Int16 r:
                        {
                            return l == r;
                        }
                        case System.UInt16 r:
                        {
                            return l == r;
                        }
                        case System.Int32 r:
                        {
                            return l == r;
                        }
                        case System.UInt32 r:
                        {
                            return l == r;
                        }
                        case System.Int64 r:
                        {
                            return l == r;
                        }
                        case System.UInt64 r:
                        {
                            return l == r;
                        }
                        case System.Single r:
                        {
                            return l == r;
                        }
                        case System.Double r:
                        {
                            return l == r;
                        }
                        case System.Decimal r:
                        {
                            throw instance.CreateRuntimeException("Cannot compare System.Single to System.Decimal");
                        }
                        default:
                        {
                            return left.Equals(right);
                        }
                    }
                }

                case System.Double l:
                {
                    switch (right)
                    {
                        case System.SByte r:
                        {
                            return l == r;
                        }
                        case System.Byte r:
                        {
                            return l == r;
                        }
                        case System.Int16 r:
                        {
                            return l == r;
                        }
                        case System.UInt16 r:
                        {
                            return l == r;
                        }
                        case System.Int32 r:
                        {
                            return l == r;
                        }
                        case System.UInt32 r:
                        {
                            return l == r;
                        }
                        case System.Int64 r:
                        {
                            return l == r;
                        }
                        case System.UInt64 r:
                        {
                            return l == r;
                        }
                        case System.Single r:
                        {
                            return l == r;
                        }
                        case System.Double r:
                        {
                            return l == r;
                        }
                        case System.Decimal r:
                        {
                            throw instance.CreateRuntimeException("Cannot compare System.Double to System.Decimal");
                        }
                        default:
                        {
                            return left.Equals(right);
                        }
                    }
                }

                case System.Decimal l:
                {
                    switch (right)
                    {
                        case System.SByte r:
                        {
                            return l == r;
                        }
                        case System.Byte r:
                        {
                            return l == r;
                        }
                        case System.Int16 r:
                        {
                            return l == r;
                        }
                        case System.UInt16 r:
                        {
                            return l == r;
                        }
                        case System.Int32 r:
                        {
                            return l == r;
                        }
                        case System.UInt32 r:
                        {
                            return l == r;
                        }
                        case System.Int64 r:
                        {
                            return l == r;
                        }
                        case System.UInt64 r:
                        {
                            return l == r;
                        }
                        case System.Single r:
                        {
                            throw instance.CreateRuntimeException("Cannot compare System.Decimal to System.Single");
                        }
                        case System.Double r:
                        {
                            throw instance.CreateRuntimeException("Cannot compare System.Decimal to System.Double");
                        }
                        case System.Decimal r:
                        {
                            return l == r;
                        }
                        default:
                        {
                            return left.Equals(right);
                        }
                    }
                }

                case string l:
                {
                    switch (right)
                    {
                        case string r:
                            return r == l;

                        case char r:
                            return l.Length == 1 && r == l[0];

                        case null:
                            return false;

                        default:
                            return left.Equals(right);
                    }
                }

                case char l:
                {
                    switch (right)
                    {
                        case char r:
                            return r == l;

                        case string r:
                            return r.Length == 1 && l == r[0];

                        case null:
                            return false;

                        default:
                            return left.Equals(right);
                    }
                }                

                case null:
                {
                    return right == null;
                }

                default:
                {
                    return right != null && left.Equals(right);
                }
            }
        }
    }
}
