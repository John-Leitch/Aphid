using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Interpreter
{
    public partial class AphidInterpreter
    {
        private bool InterpretEqualityExpression(
            object left,
            Type leftType,
            object right,
            Type rightType)
        {
            if (leftType == typeof(System.SByte))
            {
                if (rightType == typeof(System.SByte))
                {
                    return (System.SByte)left == (System.SByte)right;
                }
                else if (rightType == typeof(System.Byte))
                {
                    return (System.SByte)left == (System.Byte)right;
                }
                else if (rightType == typeof(System.Int16))
                {
                    return (System.SByte)left == (System.Int16)right;
                }
                else if (rightType == typeof(System.UInt16))
                {
                    return (System.SByte)left == (System.UInt16)right;
                }
                else if (rightType == typeof(System.Int32))
                {
                    return (System.SByte)left == (System.Int32)right;
                }
                else if (rightType == typeof(System.UInt32))
                {
                    return (System.SByte)left == (System.UInt32)right;
                }
                else if (rightType == typeof(System.Int64))
                {
                    return (System.SByte)left == (System.Int64)right;
                }
                else if (rightType == typeof(System.UInt64))
                {
                    throw CreateRuntimeException(
                        "Cannot compare System.SByte to System.UInt64");
                }
                else if (rightType == typeof(System.Single))
                {
                    return (System.SByte)left == (System.Single)right;
                }
                else if (rightType == typeof(System.Double))
                {
                    return (System.SByte)left == (System.Double)right;
                }
                else if (rightType == typeof(System.Decimal))
                {
                    return (System.SByte)left == (System.Decimal)right;
                }
                else
                {
                    return left.Equals(right);
                }
            }
            else if (leftType == typeof(System.Byte))
            {
                if (rightType == typeof(System.SByte))
                {
                    return (System.Byte)left == (System.SByte)right;
                }
                else if (rightType == typeof(System.Byte))
                {
                    return (System.Byte)left == (System.Byte)right;
                }
                else if (rightType == typeof(System.Int16))
                {
                    return (System.Byte)left == (System.Int16)right;
                }
                else if (rightType == typeof(System.UInt16))
                {
                    return (System.Byte)left == (System.UInt16)right;
                }
                else if (rightType == typeof(System.Int32))
                {
                    return (System.Byte)left == (System.Int32)right;
                }
                else if (rightType == typeof(System.UInt32))
                {
                    return (System.Byte)left == (System.UInt32)right;
                }
                else if (rightType == typeof(System.Int64))
                {
                    return (System.Byte)left == (System.Int64)right;
                }
                else if (rightType == typeof(System.UInt64))
                {
                    return (System.Byte)left == (System.UInt64)right;
                }
                else if (rightType == typeof(System.Single))
                {
                    return (System.Byte)left == (System.Single)right;
                }
                else if (rightType == typeof(System.Double))
                {
                    return (System.Byte)left == (System.Double)right;
                }
                else if (rightType == typeof(System.Decimal))
                {
                    return (System.Byte)left == (System.Decimal)right;
                }
                else
                {
                    return left.Equals(right);
                }
            }
            else if (leftType == typeof(System.Int16))
            {
                if (rightType == typeof(System.SByte))
                {
                    return (System.Int16)left == (System.SByte)right;
                }
                else if (rightType == typeof(System.Byte))
                {
                    return (System.Int16)left == (System.Byte)right;
                }
                else if (rightType == typeof(System.Int16))
                {
                    return (System.Int16)left == (System.Int16)right;
                }
                else if (rightType == typeof(System.UInt16))
                {
                    return (System.Int16)left == (System.UInt16)right;
                }
                else if (rightType == typeof(System.Int32))
                {
                    return (System.Int16)left == (System.Int32)right;
                }
                else if (rightType == typeof(System.UInt32))
                {
                    return (System.Int16)left == (System.UInt32)right;
                }
                else if (rightType == typeof(System.Int64))
                {
                    return (System.Int16)left == (System.Int64)right;
                }
                else if (rightType == typeof(System.UInt64))
                {
                    throw CreateRuntimeException("Cannot compare System.Int16 to System.UInt64");
                }
                else if (rightType == typeof(System.Single))
                {
                    return (System.Int16)left == (System.Single)right;
                }
                else if (rightType == typeof(System.Double))
                {
                    return (System.Int16)left == (System.Double)right;
                }
                else if (rightType == typeof(System.Decimal))
                {
                    return (System.Int16)left == (System.Decimal)right;
                }
                else
                {
                    return left.Equals(right);
                }
            }
            else if (leftType == typeof(System.UInt16))
            {
                if (rightType == typeof(System.SByte))
                {
                    return (System.UInt16)left == (System.SByte)right;
                }
                else if (rightType == typeof(System.Byte))
                {
                    return (System.UInt16)left == (System.Byte)right;
                }
                else if (rightType == typeof(System.Int16))
                {
                    return (System.UInt16)left == (System.Int16)right;
                }
                else if (rightType == typeof(System.UInt16))
                {
                    return (System.UInt16)left == (System.UInt16)right;
                }
                else if (rightType == typeof(System.Int32))
                {
                    return (System.UInt16)left == (System.Int32)right;
                }
                else if (rightType == typeof(System.UInt32))
                {
                    return (System.UInt16)left == (System.UInt32)right;
                }
                else if (rightType == typeof(System.Int64))
                {
                    return (System.UInt16)left == (System.Int64)right;
                }
                else if (rightType == typeof(System.UInt64))
                {
                    return (System.UInt16)left == (System.UInt64)right;
                }
                else if (rightType == typeof(System.Single))
                {
                    return (System.UInt16)left == (System.Single)right;
                }
                else if (rightType == typeof(System.Double))
                {
                    return (System.UInt16)left == (System.Double)right;
                }
                else if (rightType == typeof(System.Decimal))
                {
                    return (System.UInt16)left == (System.Decimal)right;
                }
                else
                {
                    return left.Equals(right);
                }
            }
            else if (leftType == typeof(System.Int32))
            {
                if (rightType == typeof(System.SByte))
                {
                    return (System.Int32)left == (System.SByte)right;
                }
                else if (rightType == typeof(System.Byte))
                {
                    return (System.Int32)left == (System.Byte)right;
                }
                else if (rightType == typeof(System.Int16))
                {
                    return (System.Int32)left == (System.Int16)right;
                }
                else if (rightType == typeof(System.UInt16))
                {
                    return (System.Int32)left == (System.UInt16)right;
                }
                else if (rightType == typeof(System.Int32))
                {
                    return (System.Int32)left == (System.Int32)right;
                }
                else if (rightType == typeof(System.UInt32))
                {
                    return (System.Int32)left == (System.UInt32)right;
                }
                else if (rightType == typeof(System.Int64))
                {
                    return (System.Int32)left == (System.Int64)right;
                }
                else if (rightType == typeof(System.UInt64))
                {
                    throw CreateRuntimeException("Cannot compare System.Int32 to System.UInt64");
                }
                else if (rightType == typeof(System.Single))
                {
                    return (System.Int32)left == (System.Single)right;
                }
                else if (rightType == typeof(System.Double))
                {
                    return (System.Int32)left == (System.Double)right;
                }
                else if (rightType == typeof(System.Decimal))
                {
                    return (System.Int32)left == (System.Decimal)right;
                }
                else
                {
                    return left.Equals(right);
                }
            }
            else if (leftType == typeof(System.UInt32))
            {
                if (rightType == typeof(System.SByte))
                {
                    return (System.UInt32)left == (System.SByte)right;
                }
                else if (rightType == typeof(System.Byte))
                {
                    return (System.UInt32)left == (System.Byte)right;
                }
                else if (rightType == typeof(System.Int16))
                {
                    return (System.UInt32)left == (System.Int16)right;
                }
                else if (rightType == typeof(System.UInt16))
                {
                    return (System.UInt32)left == (System.UInt16)right;
                }
                else if (rightType == typeof(System.Int32))
                {
                    return (System.UInt32)left == (System.Int32)right;
                }
                else if (rightType == typeof(System.UInt32))
                {
                    return (System.UInt32)left == (System.UInt32)right;
                }
                else if (rightType == typeof(System.Int64))
                {
                    return (System.UInt32)left == (System.Int64)right;
                }
                else if (rightType == typeof(System.UInt64))
                {
                    return (System.UInt32)left == (System.UInt64)right;
                }
                else if (rightType == typeof(System.Single))
                {
                    return (System.UInt32)left == (System.Single)right;
                }
                else if (rightType == typeof(System.Double))
                {
                    return (System.UInt32)left == (System.Double)right;
                }
                else if (rightType == typeof(System.Decimal))
                {
                    return (System.UInt32)left == (System.Decimal)right;
                }
                else
                {
                    return left.Equals(right);
                }
            }
            else if (leftType == typeof(System.Int64))
            {
                if (rightType == typeof(System.SByte))
                {
                    return (System.Int64)left == (System.SByte)right;
                }
                else if (rightType == typeof(System.Byte))
                {
                    return (System.Int64)left == (System.Byte)right;
                }
                else if (rightType == typeof(System.Int16))
                {
                    return (System.Int64)left == (System.Int16)right;
                }
                else if (rightType == typeof(System.UInt16))
                {
                    return (System.Int64)left == (System.UInt16)right;
                }
                else if (rightType == typeof(System.Int32))
                {
                    return (System.Int64)left == (System.Int32)right;
                }
                else if (rightType == typeof(System.UInt32))
                {
                    return (System.Int64)left == (System.UInt32)right;
                }
                else if (rightType == typeof(System.Int64))
                {
                    return (System.Int64)left == (System.Int64)right;
                }
                else if (rightType == typeof(System.UInt64))
                {
                    throw CreateRuntimeException("Cannot compare System.Int64 to System.UInt64");
                }
                else if (rightType == typeof(System.Single))
                {
                    return (System.Int64)left == (System.Single)right;
                }
                else if (rightType == typeof(System.Double))
                {
                    return (System.Int64)left == (System.Double)right;
                }
                else if (rightType == typeof(System.Decimal))
                {
                    return (System.Int64)left == (System.Decimal)right;
                }
                else
                {
                    return left.Equals(right);
                }
            }
            else if (leftType == typeof(System.UInt64))
            {
                if (rightType == typeof(System.SByte))
                {
                    throw CreateRuntimeException("Cannot compare System.UInt64 to System.SByte");
                }
                else if (rightType == typeof(System.Byte))
                {
                    return (System.UInt64)left == (System.Byte)right;
                }
                else if (rightType == typeof(System.Int16))
                {
                    throw CreateRuntimeException("Cannot compare System.UInt64 to System.Int16");
                }
                else if (rightType == typeof(System.UInt16))
                {
                    return (System.UInt64)left == (System.UInt16)right;
                }
                else if (rightType == typeof(System.Int32))
                {
                    throw CreateRuntimeException("Cannot compare System.UInt64 to System.Int32");
                }
                else if (rightType == typeof(System.UInt32))
                {
                    return (System.UInt64)left == (System.UInt32)right;
                }
                else if (rightType == typeof(System.Int64))
                {
                    throw CreateRuntimeException("Cannot compare System.UInt64 to System.Int64");
                }
                else if (rightType == typeof(System.UInt64))
                {
                    return (System.UInt64)left == (System.UInt64)right;
                }
                else if (rightType == typeof(System.Single))
                {
                    return (System.UInt64)left == (System.Single)right;
                }
                else if (rightType == typeof(System.Double))
                {
                    return (System.UInt64)left == (System.Double)right;
                }
                else if (rightType == typeof(System.Decimal))
                {
                    return (System.UInt64)left == (System.Decimal)right;
                }
                else
                {
                    return left.Equals(right);
                }
            }
            else if (leftType == typeof(System.Single))
            {
                if (rightType == typeof(System.SByte))
                {
                    return (System.Single)left == (System.SByte)right;
                }
                else if (rightType == typeof(System.Byte))
                {
                    return (System.Single)left == (System.Byte)right;
                }
                else if (rightType == typeof(System.Int16))
                {
                    return (System.Single)left == (System.Int16)right;
                }
                else if (rightType == typeof(System.UInt16))
                {
                    return (System.Single)left == (System.UInt16)right;
                }
                else if (rightType == typeof(System.Int32))
                {
                    return (System.Single)left == (System.Int32)right;
                }
                else if (rightType == typeof(System.UInt32))
                {
                    return (System.Single)left == (System.UInt32)right;
                }
                else if (rightType == typeof(System.Int64))
                {
                    return (System.Single)left == (System.Int64)right;
                }
                else if (rightType == typeof(System.UInt64))
                {
                    return (System.Single)left == (System.UInt64)right;
                }
                else if (rightType == typeof(System.Single))
                {
                    return (System.Single)left == (System.Single)right;
                }
                else if (rightType == typeof(System.Double))
                {
                    return (System.Single)left == (System.Double)right;
                }
                else if (rightType == typeof(System.Decimal))
                {
                    throw CreateRuntimeException("Cannot compare System.Single to System.Decimal");
                }
                else
                {
                    return left.Equals(right);
                }
            }
            else if (leftType == typeof(System.Double))
            {
                if (rightType == typeof(System.SByte))
                {
                    return (System.Double)left == (System.SByte)right;
                }
                else if (rightType == typeof(System.Byte))
                {
                    return (System.Double)left == (System.Byte)right;
                }
                else if (rightType == typeof(System.Int16))
                {
                    return (System.Double)left == (System.Int16)right;
                }
                else if (rightType == typeof(System.UInt16))
                {
                    return (System.Double)left == (System.UInt16)right;
                }
                else if (rightType == typeof(System.Int32))
                {
                    return (System.Double)left == (System.Int32)right;
                }
                else if (rightType == typeof(System.UInt32))
                {
                    return (System.Double)left == (System.UInt32)right;
                }
                else if (rightType == typeof(System.Int64))
                {
                    return (System.Double)left == (System.Int64)right;
                }
                else if (rightType == typeof(System.UInt64))
                {
                    return (System.Double)left == (System.UInt64)right;
                }
                else if (rightType == typeof(System.Single))
                {
                    return (System.Double)left == (System.Single)right;
                }
                else if (rightType == typeof(System.Double))
                {
                    return (System.Double)left == (System.Double)right;
                }
                else if (rightType == typeof(System.Decimal))
                {
                    throw CreateRuntimeException("Cannot compare System.Double to System.Decimal");
                }
                else
                {
                    return left.Equals(right);
                }
            }
            else if (leftType == typeof(System.Decimal))
            {
                if (rightType == typeof(System.SByte))
                {
                    return (System.Decimal)left == (System.SByte)right;
                }
                else if (rightType == typeof(System.Byte))
                {
                    return (System.Decimal)left == (System.Byte)right;
                }
                else if (rightType == typeof(System.Int16))
                {
                    return (System.Decimal)left == (System.Int16)right;
                }
                else if (rightType == typeof(System.UInt16))
                {
                    return (System.Decimal)left == (System.UInt16)right;
                }
                else if (rightType == typeof(System.Int32))
                {
                    return (System.Decimal)left == (System.Int32)right;
                }
                else if (rightType == typeof(System.UInt32))
                {
                    return (System.Decimal)left == (System.UInt32)right;
                }
                else if (rightType == typeof(System.Int64))
                {
                    return (System.Decimal)left == (System.Int64)right;
                }
                else if (rightType == typeof(System.UInt64))
                {
                    return (System.Decimal)left == (System.UInt64)right;
                }
                else if (rightType == typeof(System.Single))
                {
                    throw CreateRuntimeException("Cannot compare System.Decimal to System.Single");
                }
                else if (rightType == typeof(System.Double))
                {
                    throw CreateRuntimeException("Cannot compare System.Decimal to System.Double");
                }
                else if (rightType == typeof(System.Decimal))
                {
                    return (System.Decimal)left == (System.Decimal)right;
                }
                else
                {
                    return left.Equals(right);
                }
            }
            else if (leftType == typeof(char) && rightType == typeof(string))
            {
                var str = (string)right;

                return str.Length == 1 && (char)left == str[0];
            }
            else if (leftType == typeof(string) && rightType == typeof(char))
            {
                var str = (string)left;

                return str.Length == 1 && str[0] == (char)right;
            }
            else if (left == null)
            {
                return right == null;
            }
            else if (right == null)
            {
                return left == null;
            }
            else
            {
                return left.Equals(right);
            }
        }
    }
}
