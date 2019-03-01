using Components.Aphid.Interpreter;
using Components.Aphid.TypeSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Components.Aphid.Library
{
    [AphidLibrary("standard")]
    public static class StandardLibrary
    {
        public static Encoding Encoding = Encoding.GetEncoding("iso-8859-1");

        [AphidInteropFunction("extendType", PassInterpreter = true, UnwrapParameters = false)]
        public static void Extend(AphidInterpreter interpreter, AphidObject type, AphidObject extensions) =>
            interpreter.TypeExtender.Extend((string)type.Value, extensions, null, null);

        [AphidInteropFunction("serialize", UnwrapParameters = false, PassInterpreter = true)]
        public static AphidObject Serialize(AphidInterpreter interpreter, AphidObject obj) =>
            AphidObject.Scalar(interpreter.Serializer.Serialize(obj));

        [AphidInteropFunction("deserialize", UnwrapParameters = false, PassInterpreter = true)]
        public static AphidObject Deserialize(AphidInterpreter interpreter, AphidObject obj) =>
            interpreter.Serializer.Deserialize((string)obj.Value);

        [AphidInteropFunction("ascii.getBytes")]
        public static List<AphidObject> GetBytes(string value) =>
            Encoding.GetBytes(value).Select(x => AphidObject.Scalar((decimal)x)).ToList();

        [AphidInteropFunction("ascii.getString")]
        public static string GetBytes(List<AphidObject> bytes) =>
            Encoding.GetString(bytes.Select(x => (byte)(decimal)x.Value).ToArray());

        [AphidInteropFunction("eval", PassInterpreter = true)]
        private static object Eval(AphidInterpreter interpreter, string code)
        {
            interpreter.EnterScope();

            try
            {
                interpreter.Interpret(code);

                return interpreter.GetReturnValue();
            }
            finally
            {
                interpreter.LeaveScope();
            }
        }

        [AphidInteropFunction("type")]
        public static string GetObjectType(object obj)
        {
            switch (obj.GetType().Name)
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
        private static void Print(AphidInterpreter interpreter, object message) =>
            interpreter.WriteOut(message != null ?
                message.ToString() + Environment.NewLine :
                Environment.NewLine);

        [AphidInteropFunction("printf", PassInterpreter = true)]
        private static void PrintFormatted(
            AphidInterpreter interpreter,
            string format,
            params object[] args) => interpreter.WriteOut(string.Format(format + Environment.NewLine, args));

        [AphidInteropFunction("sprintf")]
        private static string SPrintF(string format, params object[] args) =>
            string.Format(format, args);

        [AphidInteropFunction("input")]
        private static string ReadLine() => Console.ReadLine();

        [AphidInteropFunction("num", PassInterpreter = true)]
        public static decimal CovertToNumber(AphidInterpreter interpreter, object obj)
        {
            if (obj is string str)
            {
                return decimal.Parse(str);
            }

            throw interpreter.CreateRuntimeException(
                "Could not parse number: {0}",
                obj);
        }

        [AphidInteropFunction("str")]
        private static string ConvertToString(object obj) => Convert.ToString(obj);

        [AphidInteropFunction("asc")]
        private static decimal ConvertToCharCode(object obj)
        {
            if (obj is string str)
            {
                if (str.Length != 0)
                {
                    throw new InvalidOperationException();
                }

                return (decimal)str[0];
            }

            throw new InvalidOperationException();
        }

        [AphidInteropFunction("chr")]
        private static string ConvertToCharCode(decimal obj) => ((char)obj).ToString();

        [AphidInteropFunction("hexb")]
        private static string ConvertToHexByteString(object value)
        {
            if (value is decimal dec)
            {
                return ConvertToHexByteString(dec);
            }
            else if (value is string s)
            {
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

        private static string ConvertToHexByteString(decimal value) =>
            Convert.ToString((byte)value, 16).PadLeft(2, '0');

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
        private static List<AphidObject> Range(decimal start, decimal count) => Enumerable
            .Range((int)start, (int)count)
            .Select(x => AphidObject.Scalar((decimal)x))
            .ToList();

        [AphidInteropFunction("__list.add", UnwrapParameters = false)]
        private static void ListAdd(AphidObject list, AphidObject value) =>
            ((List<AphidObject>)list.Value).Add(value);

        [AphidInteropFunction("__list.contains")]
        private static bool ListContains(List<AphidObject> list, object value) =>
            list.Any(x => x.Value.Equals(value));

        [AphidInteropFunction("__list.insert", UnwrapParameters = false)]
        private static void ListAdd(AphidObject list, AphidObject index, AphidObject value) =>
            ((List<AphidObject>)list.Value).Insert((int)(decimal)index.Value, value);

        [AphidInteropFunction("__list.count")]
        private static decimal ListCount(List<AphidObject> list) => (decimal)list.Count;

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
        private static List<AphidObject> ListOrderBy(AphidInterpreter interpreter, AphidObject items, AphidObject keySelector) =>
            ListOrder(interpreter, items, keySelector, Enumerable.OrderBy);

        [AphidInteropFunction("__list.orderByDescending", PassInterpreter = true, UnwrapParameters = false)]
        private static List<AphidObject> ListOrderByDescending(
            AphidInterpreter interpreter,
            AphidObject items,
            AphidObject keySelector) => ListOrder(interpreter, items, keySelector, Enumerable.OrderByDescending);

        [AphidInteropFunction("__string.length")]
        private static decimal StringLength(string str) =>
            (decimal)str.Length;

        [AphidInteropFunction("__string.getChars")]
        private static List<AphidObject> StringGetChars(string str) =>
            str.Select(x => AphidObject.Scalar(x.ToString())).ToList();

        [AphidInteropFunction("__string.remove")]
        private static string StringGetChars(string str, decimal index) =>
            str.Remove((int)index);

        [AphidInteropFunction("__string.substring", UnwrapParameters = false)]
        private static string StringSubstring(AphidObject str, AphidObject index, AphidObject length)
        {
            var str2 = (string)str.Value;
            return length == null || length.Value == null ? 
                str2.Substring((int)(decimal)index.Value) :
                str2.Substring((int)(decimal)index.Value, (int)(decimal)length.Value);
        }

        [AphidInteropFunction("__string.startsWith")]
        private static bool StringStartsWith(string str, string value) => str.StartsWith(value);

        [AphidInteropFunction("__string.endsWith")]
        private static bool StringEndsWith(string str, string value) => str.EndsWith(value);

        [AphidInteropFunction("__string.trim")]
        private static string StringTrim(string str) => str.Trim();

        [AphidInteropFunction("__string.split", PassInterpreter = true)]
        private static List<AphidObject> StringSplit(AphidInterpreter interpreter, string str, object separator)
        {
            string[] s;

            if (separator is string separatorString)
            {
                s = new[] { separatorString };
            }
            else if (separator is List<AphidObject> separatorList)
            {
                s = separatorList.Select(x => x.GetString()).ToArray();
            }
            else
            {
                throw interpreter.CreateRuntimeException(
                    "Invalid string split separator: {0}",
                    separator);
            }

            return str
                .Split(s, StringSplitOptions.None)
                .Select(AphidObject.Scalar)
                .ToList();
        }

        [AphidInteropFunction("__string.contains")]
        private static bool StringContains(string str, string str2) => 
            _ignoreCase ? str.Contains(str2) : str.ToUpper().Contains(str2.ToUpper());

        [AphidInteropFunction("__string.isMatch")]
        private static bool StringIsMatch(string str, string pattern) =>
            Regex.IsMatch(str, pattern);

        [AphidInteropFunction("__string.lower")]
        private static string StringLower(string str) => str.ToLower();

        [AphidInteropFunction("__string.replace")]
        private static string StringReplace(string str, string oldValue, string newValue) =>
            str.Replace(oldValue, newValue);

        private static bool _ignoreCase;

        [AphidInteropFunction("__string.ignoreCase")]
        private static void StringIgnoreCase(bool ignoreCase) => _ignoreCase = ignoreCase;

        [AphidInteropFunction("keys", UnwrapParameters = false)]
        public static List<AphidObject> Keys(AphidObject obj) =>
            obj.Select(x => AphidObject.Scalar(x.Key)).ToList();

        [AphidInteropFunction("setValue", PassInterpreter = true, UnwrapParameters = false)]
        public static void SetValue(AphidInterpreter interpreter, AphidObject dst, object src) => 
            dst.Value = ValueHelper.Unwrap(src);
    }
}

