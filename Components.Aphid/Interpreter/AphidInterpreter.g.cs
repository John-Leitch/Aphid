using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Interpreter
{
    public partial class AphidInterpreter
    {
        private bool InterpretEqualityExpression(object left, object right)
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
                            throw CreateRuntimeException(
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
                            throw CreateRuntimeException("Cannot compare System.Int16 to System.UInt64");
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
                            throw CreateRuntimeException("Cannot compare System.Int32 to System.UInt64");
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
                    //    throw CreateRuntimeException("Cannot compare System.Int32 to System.UInt64");
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
                            throw CreateRuntimeException("Cannot compare System.Int64 to System.UInt64");
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
                            throw CreateRuntimeException("Cannot compare System.UInt64 to System.SByte");
                        }
                        case System.Byte r:
                        {
                            return l == r;
                        }
                        case System.Int16 r:
                        {
                            throw CreateRuntimeException("Cannot compare System.UInt64 to System.Int16");
                        }
                        case System.UInt16 r:
                        {
                            return l == r;
                        }
                        case System.Int32 r:
                        {
                            throw CreateRuntimeException("Cannot compare System.UInt64 to System.Int32");
                        }
                        case System.UInt32 r:
                        {
                            return l == r;
                        }
                        case System.Int64 r:
                        {
                            throw CreateRuntimeException("Cannot compare System.UInt64 to System.Int64");
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
                            throw CreateRuntimeException("Cannot compare System.Single to System.Decimal");
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
                            throw CreateRuntimeException("Cannot compare System.Double to System.Decimal");
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
                            throw CreateRuntimeException("Cannot compare System.Decimal to System.Single");
                        }
                        case System.Double r:
                        {
                            throw CreateRuntimeException("Cannot compare System.Decimal to System.Double");
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
