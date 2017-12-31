using Components.Aphid.Interpreter;
using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Components.Aphid.Library
{
    [AphidLibraryAttribute("standard")]
    public class StandardLibrary
    {
        public static Encoding Encoding = Encoding.GetEncoding("iso-8859-1");

        private static AphidSerializer _serializer = new AphidSerializer() { IgnoreFunctions = true };

        [AphidInteropFunction("extendType", PassInterpreter = true, UnwrapParameters = false)]
        public static void Extend(AphidInterpreter interpreter, AphidObject type, AphidObject extensions)
        {
            var typeStr = (string)type.Value;

            TypeExtender.Extend(interpreter, (string)type.Value, extensions);
        }

        [AphidInteropFunction("serialize", UnwrapParameters = false)]
        public static AphidObject Serialize(AphidObject obj)
        {
            return new AphidObject(_serializer.Serialize(obj));
        }

        [AphidInteropFunction("deserialize", UnwrapParameters = false)]
        public static AphidObject Deserialize(AphidObject obj)
        {
            return _serializer.Deserialize((string)obj.Value);
        }

        [AphidInteropFunction("ascii.getBytes")]
        public static List<AphidObject> GetBytes(string value)
        {
            return Encoding.GetBytes(value).Select(x => new AphidObject((decimal)x)).ToList();
        }

        [AphidInteropFunction("ascii.getString")]
        public static string GetBytes(List<AphidObject> bytes)
        {
            return Encoding.GetString(bytes.Select(x => (byte)(decimal)x.Value).ToArray());
        }

        [AphidInteropFunction("eval", PassInterpreter = true)]
        private static object Eval(AphidInterpreter interpreter, string code)
        {
            interpreter.EnterChildScope();
            interpreter.Interpret(code);
            var retVal = interpreter.GetReturnValue();
            interpreter.LeaveChildScope();
            return retVal;
        }

        [AphidInteropFunction("type")]
        public static string GetObjectType(object obj)
        {
            var n = obj.GetType().Name;
            
            switch (n)
            {
                case "List`1":
                    return "list";
                case "Decimal":
                    return "number";
                case "String":
                    return "string";
                default:
                    return "Unknown";
            }
        }

        [AphidInteropFunction("print", PassInterpreter = true)]
        private static void Print(AphidInterpreter interpreter, object message)
        {
            interpreter.WriteOut(message != null ?
                message.ToString() + Environment.NewLine :
                Environment.NewLine);
        }

        [AphidInteropFunction("printf", PassInterpreter = true)]
        private static void PrintFormatted(
            AphidInterpreter interpreter, 
            string format, 
            params object[] args)
        {
            var s = string.Format(format + Environment.NewLine, args);
            interpreter.WriteOut(s);
        }

        [AphidInteropFunction("sprintf")]
        private static string SPrintF(string format, params object[] args)
        {
            return string.Format(format, args);
        }

        [AphidInteropFunction("input")]
        private static string ReadLine()
        {
            return Console.ReadLine();
        }

        [AphidInteropFunction("num")]
        public static decimal CovertToNumber(object obj)
        {
            if (obj is string)
            {
                return decimal.Parse((string)obj);
            }
            else
            {
                throw new AphidRuntimeException("Could not parse number \"{0}\".", obj);
            }
        }

        [AphidInteropFunction("str")]
        private static string ConvertToString(object obj)
        {
            return Convert.ToString(obj);
        }

        [AphidInteropFunction("asc")]
        private static decimal ConvertToCharCode(object obj)
        {
            if (obj is string)
            {
                var str = (obj as string);

                if (str.Length != 0)
                {
                    throw new InvalidOperationException();
                }

                return (decimal)str[0];
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        [AphidInteropFunction("chr")]
        private static string ConvertToCharCode(decimal obj)
        {
            return ((char)obj).ToString();
        }

        [AphidInteropFunction("hexb")]
        private static string ConvertToHexByteString(object value)
        {
            if (value is decimal)
            {
                return ConvertToHexByteString((decimal)value);
            }
            else if (value is string)
            {
                var s = value as string;

                if (s.Length != 1)
                {
                    throw new InvalidOperationException();
                }

                return Convert.ToString(s[0], 16).PadLeft(2, '0');
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        private static string ConvertToHexByteString(decimal value)
        {
            return Convert.ToString((byte)value, 16).PadLeft(2, '0');
        }

        private static Random _random = new Random();

        [AphidInteropFunction("randInt")]
        public static decimal RandomInt(decimal minValue, decimal maxValue)
        {
            lock (_random)
            {
                return (decimal)_random.Next((int)minValue, (int)maxValue);
            }
        }

        [AphidInteropFunction("range")]
        private static List<AphidObject> Range(decimal start, decimal count)
        {
            return Enumerable
                .Range((int)start, (int)count)
                .Select(x => new AphidObject((decimal)x))
                .ToList();
        }

        [AphidInteropFunction("__list.add", UnwrapParameters = false)]
        private static void ListAdd(AphidObject list, AphidObject value)
        {
            ((List<AphidObject>)list.Value).Add(value);
        }

        [AphidInteropFunction("__list.contains")]
        private static bool ListContains(List<AphidObject> list, object value)
        {
            var s = list.Any(x => x.Value.Equals(value));
            return s;
        }

        [AphidInteropFunction("__list.insert", UnwrapParameters = false)]
        private static void ListAdd(AphidObject list, AphidObject index, AphidObject value)
        {
            ((List<AphidObject>)list.Value).Insert((int)(decimal)index.Value, value);
        }

        [AphidInteropFunction("__list.count")]
        private static decimal ListCount(List<AphidObject> list)
        {
            return (decimal)list.Count;
        }

        private static List<AphidObject> ListOrder(
            AphidInterpreter interpreter, 
            AphidObject items, 
            AphidObject keySelector,
            Func<IEnumerable<AphidObject>, Func<AphidObject, object>, IOrderedEnumerable<AphidObject>> action)
        {
            var list = (List<AphidObject>)items.Value;
            var func = (AphidFunction)keySelector.Value;

            return action(list, x => interpreter.CallFunction(func, x).Value).ToList();
        }

        [AphidInteropFunction("__list.orderBy", PassInterpreter = true, UnwrapParameters = false)]
        private static List<AphidObject> ListOrderBy(AphidInterpreter interpreter, AphidObject items, AphidObject keySelector)
        {
            return ListOrder(interpreter, items, keySelector, Enumerable.OrderBy);            
        }

        [AphidInteropFunction("__list.orderByDescending", PassInterpreter = true, UnwrapParameters = false)]
        private static List<AphidObject> ListOrderByDescending(AphidInterpreter interpreter, AphidObject items, AphidObject keySelector)
        {
            return ListOrder(interpreter, items, keySelector, Enumerable.OrderByDescending);
        }

        [AphidInteropFunction("__string.length")]
        private static decimal StringLength(string str)
        {
            return (decimal)str.Length;
        }

        [AphidInteropFunction("__string.getChars")]
        private static List<AphidObject> StringGetChars(string str)
        {
            return str.Select(x => new AphidObject(x.ToString())).ToList();
        }

        [AphidInteropFunction("__string.remove")]
        private static string StringGetChars(string str, decimal index)
        {
            return str.Remove((int)index);
        }

        [AphidInteropFunction("__string.substring", UnwrapParameters = false)]
        private static string StringSubstring(AphidObject str, AphidObject index, AphidObject length)
        {
            var str2 = (string)str.Value;
            return length == null || length.Value == null ? 
                str2.Substring((int)(decimal)index.Value) :
                str2.Substring((int)(decimal)index.Value, (int)(decimal)length.Value);
        }

        [AphidInteropFunction("__string.startsWith")]
        private static bool StringStartsWith(string str, string value)
        {
            return str.StartsWith(value);
        }

        [AphidInteropFunction("__string.endsWith")]
        private static bool StringEndsWith(string str, string value)
        {
            return str.EndsWith(value);
        }

        [AphidInteropFunction("__string.trim")]
        private static string StringTrim(string str)
        {
            return str.Trim();
        }        

        [AphidInteropFunction("__string.split")]
        private static List<AphidObject> StringSplit(string str, object separator)
        {
            string[] s;
            string separatorString;
            List<AphidObject> separatorList;

            if ((separatorString = separator as string) != null)
            {
                s = new[] { separatorString };
            }
            else if ((separatorList = separator as List<AphidObject>) != null)
            {
                s = separatorList.Select(x => x.GetString()).ToArray();
            }
            else
            {
                throw new AphidRuntimeException("Invalid string split separator: {0}", separator);
            }

            return str
                .Split(s, StringSplitOptions.None)
                .Select(x => new AphidObject(x))
                .ToList();
        }

        [AphidInteropFunction("__string.contains")]
        private static bool StringContains(string str, string str2)
        {
            return !_ignoreCase ? str.Contains(str2) : str.ToUpper().Contains(str2.ToUpper());
        }

        [AphidInteropFunction("__string.isMatch")]
        private static bool StringIsMatch(string str, string pattern)
        {
            return Regex.IsMatch(str, pattern);
        }

        [AphidInteropFunction("__string.lower")]
        private static string StringLower(string str)
        {
            return str.ToLower();
        }

        [AphidInteropFunction("__string.replace")]
        private static string StringReplace(string str, string oldValue, string newValue)
        {
            return str.Replace(oldValue, newValue);
        }

        private static bool _ignoreCase = false;

        [AphidInteropFunction("string.ignoreCase")]
        private static void StringIgnoreCase(bool ignoreCase)
        {
            _ignoreCase = ignoreCase;
        }

        [AphidInteropFunction("keys", UnwrapParameters = false)]
        public static List<AphidObject> Keys(AphidObject obj)
        {
            return obj.Select(x => new AphidObject(x.Key)).ToList();
        }
    }
}

