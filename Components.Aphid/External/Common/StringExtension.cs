using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components
{
    public static class StringExtension
    {
        public static string Repeat(this string s, int Count) => new StringBuilder().Insert(0, s, Count).ToString();

        public static string Indent(this string s, string indent = "\t") => s.Insert(0, indent).Replace("\n", "\n" + indent);

        public static string SubstringAtIndexOf(this string s, string Value) => s.Substring(s.IndexOf(Value));

        public static string SubstringAtIndexOf(this string s, string Value, int Offset) => s.Substring(s.IndexOf(Value) + Offset);

        public static string SubstringAtIndexOf(this string s, char Value) => s.Substring(s.IndexOf(Value));

        public static string SubstringAtIndexOf(this string s, char Value, int Offset) => s.Substring(s.IndexOf(Value) + Offset);

        public static string SubstringAtLastIndexOf(this string s, string Value) => s.Substring(s.LastIndexOf(Value));

        public static string SubstringAtLastIndexOf(this string s, string Value, int Offset) => s.Substring(s.LastIndexOf(Value) + Offset);

        public static string SubstringAtLastIndexOf(this string s, char Value) => s.Substring(s.LastIndexOf(Value));

        public static string SubstringAtLastIndexOf(this string s, char Value, int Offset) => s.Substring(s.LastIndexOf(Value) + Offset);

        public static string RemoveAtIndexOf(this string s, string Value) => s.Remove(s.IndexOf(Value));

        public static string RemoveAtIndexOf(this string s, string Value, int Offset) => s.Remove(s.IndexOf(Value) + Offset);

        public static string RemoveAtIndexOf(this string s, char Value) => s.Remove(s.IndexOf(Value));

        public static string RemoveAtIndexOf(this string s, char Value, int Offset) => s.Remove(s.IndexOf(Value) + Offset);

        public static string RemoveAtLastIndexOf(this string s, string Value) => s.Remove(s.LastIndexOf(Value));

        public static string RemoveAtLastIndexOf(this string s, string Value, int Offset) => s.Remove(s.LastIndexOf(Value) + Offset);

        public static string RemoveAtLastIndexOf(this string s, char Value) => s.Remove(s.LastIndexOf(Value));

        public static string RemoveAtLastIndexOf(this string s, char Value, int Offset) => s.Remove(s.LastIndexOf(Value) + Offset);

        public static string Slice(this string s, int StartIndex, int EndIndex) => s.Substring(StartIndex, EndIndex - StartIndex);

        public static string[] Split(this string s, int Index) =>
            s.Length != Index ?
                new[] { s.Remove(Index), s.Substring(Index) } :
                new[] { s, string.Empty };

        public static string[] SplitLines(this string s, StringSplitOptions Options) => s.Split(new[] { "\r\n" }, Options);

        public static int LeastIndexOf(this string s, params char[] Chars) => Chars.Select(x => s.IndexOf(x)).OrderBy(x => x).First();

        private static readonly Encoding _encoding = Encoding.GetEncoding("iso-8859-1");

        public static byte[] GetBytes(this string s) => _encoding.GetBytes(s);

        public static string[] SplitLines(this string s) => SplitLines(s, StringSplitOptions.None);

        public static string Aggregate(this IEnumerable<string> s) => s.Aggregate((x, y) => x + y);

        public static string Aggregate(this IEnumerable<string> s, string Delimiter) => s.Aggregate((x, y) => x + Delimiter + y);

        public static string GetSurroundingLines(this string s, int Index,
            int LinesAbove, int LinesBelow)
        {
            var strings = s
                .Split(Index)
                .Select(x => x.SplitLines(StringSplitOptions.None))
                .ToArray();

            return strings[0].Skip(strings[0].Length - LinesAbove - 1).Aggregate("\r\n") +
                strings[1].Take(LinesBelow + 1).Aggregate("\r\n");
        }

        public static string GetLine(this string s, int Index) => s.GetSurroundingLines(Index, 0, 0);

        public static int GetLineNumber(this string s, int Index) => s.Split(Index)[0].SplitLines().Length - 1;

        public static int GetLineIndex(this string s, int lineNumber)
        {
            if (lineNumber == 0)
            {
                return 0;
            }

            var currentLine = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == '\n' && ++currentLine == lineNumber)
                {
                    return i + 1;
                }
            }

            return -1;
        }

        public static string NormalizeLines(this string s) => s
                .Replace("\r\n", "\n")
                .Replace('\r', '\n')
                .Replace("\n", "\r\n");

        public static string InsertLineNumbers(this string s, int startLine)
        {
            var sb = new StringBuilder(s);
            var line = startLine;
            string getLineStr() => line++.ToString().PadLeft(4, '0') + ": ";
            sb.Insert(0, getLineStr());

            for (var i = 0; i < sb.Length; i++)
            {
                if (sb[i] == '\n')
                {
                    sb.Insert(i + 1, getLineStr());
                }
            }

            return sb.ToString();
        }

        public static string InsertLineNumbers(this string s) => InsertLineNumbers(s, 1);

        public static int[] IndexesOf(this string s, string value)
        {
            var indexes = new List<int>();
            var i = -1;

            while ((i = s.IndexOf(value, i + 1)) != -1)
            {
                indexes.Add(i);
            }

            return indexes.ToArray();
        }
    }
}
