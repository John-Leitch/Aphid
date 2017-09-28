using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Interpreter
{
    public static class OperatorHelper
    {
        public static AphidObject Add(AphidObject x, AphidObject y)
        {
            if (x == null || y == null)
            {
                throw new AphidOperationException("addition");
            }
            else if (x.Value is decimal && y.Value is decimal)
            {
                return new AphidObject((decimal)x.Value + (decimal)y.Value);
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
                return new AphidObject(Convert.ToDecimal(x.Value) + Convert.ToDecimal(y.Value));
            }            
            else
            {
                return new AphidObject(Convert.ToString(x.Value) + Convert.ToString(y.Value));
            }
        }

        public static AphidObject Mod(AphidObject x, AphidObject y)
        {
            if (x == null || y == null)
            {
                throw new AphidOperationException("modulo");
            }
            else
            {
                return new AphidObject(Convert.ToDecimal(x.Value) % Convert.ToDecimal(y.Value));
            }
        }

        public static AphidObject BinaryOr(AphidObject x, AphidObject y)
        {
            if (x == null || y == null)
            {
                throw new AphidOperationException("binary or");
            }
            else
            {
                return new AphidObject((decimal)((long)(decimal)x.Value | (long)(decimal)y.Value));
            }
        }

        public static AphidObject BinaryAnd(AphidObject x, AphidObject y)
        {
            if (x == null || y == null)
            {
                throw new AphidOperationException("binary and");
            }
            else
            {
                return new AphidObject((decimal)((long)(decimal)x.Value & (long)(decimal)y.Value));
            }
        }

        public static AphidObject BinaryShiftLeft(AphidObject x, AphidObject y)
        {
            if (x == null || y == null)
            {
                throw new AphidOperationException("binary shift left");
            }
            else
            {
                return new AphidObject((decimal)((int)(decimal)x.Value << (int)(decimal)y.Value));
            }
        }

        public static AphidObject BinaryShiftRight(AphidObject x, AphidObject y)
        {
            if (x == null || y == null)
            {
                throw new AphidOperationException("binary shift right");
            }
            else
            {
                return new AphidObject((decimal)((int)(decimal)x.Value >> (int)(decimal)y.Value));
            }
        }

        public static AphidObject Xor(AphidObject x, AphidObject y)
        {
            if (x == null || y == null)
            {
                throw new AphidOperationException("exclusive or");
            }
            else
            {
                return new AphidObject((decimal)((int)(decimal)x.Value ^ (int)(decimal)y.Value));
            }
        }

        public static AphidObject Subtract(AphidObject x, AphidObject y)
        {
            if (x == null || y == null)
            {
                throw new AphidOperationException("subtraction");
            }
            else
            {
                return new AphidObject(Convert.ToDecimal(x.Value) - Convert.ToDecimal(y.Value));
            }
        }

        private static AphidObject Repeat(string value, decimal count)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                sb.Append(value);
            }

            return new AphidObject(sb.ToString());  
        }

        public static AphidObject Multiply(AphidObject x, AphidObject y)
        {
            if (x == null || y == null)
            {
                throw new AphidOperationException("multiplication");
            }
            else
            {
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

                    return new AphidObject(Convert.ToDecimal(x.Value) * Convert.ToDecimal(y.Value));                    
                }

                return new AphidObject(val);
            }
        }

        public static AphidObject Divide(AphidObject x, AphidObject y)
        {
            if (x == null || y == null)
            {
                throw new AphidOperationException("division");
            }
            else
            {
                return new AphidObject(Convert.ToDecimal(x.Value) / Convert.ToDecimal(y.Value));
            }
        }

        public static AphidObject Range(AphidObject x, AphidObject y)
        {
            if (x == null || y == null)
            {
                throw new AphidOperationException("range");
            }
            else
            {
                var r = new AphidObject(
                    Enumerable
                        .Range(Convert.ToInt32(x.Value), Convert.ToInt32(y.Value))
                        .Select(z => new AphidObject((decimal)z))
                        .ToList());
                
                return r;
            }
        }

        public static bool EqualsCore(AphidObject x, AphidObject y)
        {
            return x.Value != null ?
                x.Value.Equals(y.Value) :
                (null == y.Value && x.Count == 0 && y.Count == 0);
        }

        public static AphidObject Equals(AphidObject x, AphidObject y)
        {
            return new AphidObject(EqualsCore(x, y));
        }

        public static AphidObject NotEqual(AphidObject x, AphidObject y)
        {
            return new AphidObject(!EqualsCore(x, y));
        }
    }
}
