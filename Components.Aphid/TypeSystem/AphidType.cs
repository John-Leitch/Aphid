using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.TypeSystem
{
    public static class AphidType
    {
        public const string Unknown = "unknown",
            String = "string",
            Number = "number",
            Boolean = "boolean",
            List = "list",
            Object = "object",
            Function = "function",
            InteropFunction = "interopFunction",
            PartialFunction = "partialFunction",
            FunctionComposition = "functionComposition",
            Null = "null";

        public static string GetName(object value)
        {
            Type t;

            return value != null ?
                AphidAlias.Resolve(t = value.GetType()) ?? t.FullName :
                Null;
        }

        public static string TypeToString(Type type) =>
            TypeToString(type, true, new StringBuilder());

        public static string TypeToString(Type type, bool fullName) =>
            TypeToString(type, fullName, new StringBuilder());

        public static string TypeToString(Type type, bool fullName, StringBuilder sb)
        {
            var name = fullName ? type.FullName : type.Name;
            var len = name.Length;

            if (type.IsGenericType)
            {
                var scanningForTick = true;
                var tickIndex = -1;

                for (var i = 0; i < len; i++)
                {
                    if (scanningForTick)
                    {
                        if (name[i] == '`')
                        {
                            tickIndex = i;
                            scanningForTick = false;
                        }
                    }
                    else
                    {
                        if (char.IsDigit(name[i]))
                        {
                            break;
                        }
                        else
                        {
                            scanningForTick = true;
                            tickIndex = -1;
                        }
                    }

                }

                if (tickIndex > -1)
                {
                    sb.AppendFormat("{0}[", name.Remove(tickIndex));
                }
                else
                {
                    sb.AppendFormat("{0}[", name);
                }

                var isFirst = true;

                foreach (var arg in type.GetGenericArguments())
                {
                    if (!isFirst)
                    {
                        sb.Append(", ");
                    }
                    else
                    {
                        isFirst = false;
                    }

                    TypeToString(arg, fullName, sb);
                }

                sb.Append(']');
            }
            else if (type.IsArray)
            {

                var elemType = type.GetElementType();
                TypeToString(elemType, fullName, sb);

                var rank = type.GetArrayRank();

                if (rank == 0)
                {
                    sb.Append("[]");
                }
                else
                {
                    sb.AppendFormat("[{0}]", new string(',', rank - 1));
                }
            }
            else
            {
                sb.Append(name);
            }

            return sb.ToString();
        }
    }
}
