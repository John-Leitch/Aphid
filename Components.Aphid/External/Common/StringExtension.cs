using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Components
{
    public static class StringExtension
    {
        public static string Repeat(this string s, int Count)
        {
            return new StringBuilder().Insert(0, s, Count).ToString();
        }

        public static string Indent(this string s, string indent = "\t")
        {
            return s.Insert(0, indent).Replace("\n", "\n" + indent);
        }

        public static string SubstringAtIndexOf(this string s, string Value)
        {
            return s.Substring(s.IndexOf(Value));
        }

        public static string SubstringAtIndexOf(this string s, string Value, int Offset)
        {
            return s.Substring(s.IndexOf(Value) + Offset);
        }

        public static string SubstringAtIndexOf(this string s, char Value)
        {
            return s.Substring(s.IndexOf(Value));
        }

        public static string SubstringAtIndexOf(this string s, char Value, int Offset)
        {
            return s.Substring(s.IndexOf(Value) + Offset);
        }

        public static string SubstringAtLastIndexOf(this string s, string Value)
        {
            return s.Substring(s.LastIndexOf(Value));
        }

        public static string SubstringAtLastIndexOf(this string s, string Value, int Offset)
        {
            return s.Substring(s.LastIndexOf(Value) + Offset);
        }

        public static string SubstringAtLastIndexOf(this string s, char Value)
        {
            return s.Substring(s.LastIndexOf(Value));
        }

        public static string SubstringAtLastIndexOf(this string s, char Value, int Offset)
        {
            return s.Substring(s.LastIndexOf(Value) + Offset);
        }

        public static string RemoveAtIndexOf(this string s, string Value)
        {
            return s.Remove(s.IndexOf(Value));
        }

        public static string RemoveAtIndexOf(this string s, string Value, int Offset)
        {
            return s.Remove(s.IndexOf(Value) + Offset);
        }

        public static string RemoveAtIndexOf(this string s, char Value)
        {
            return s.Remove(s.IndexOf(Value));
        }

        public static string RemoveAtIndexOf(this string s, char Value, int Offset)
        {
            return s.Remove(s.IndexOf(Value) + Offset);
        }

        public static string RemoveAtLastIndexOf(this string s, string Value)
        {
            return s.Remove(s.LastIndexOf(Value));
        }

        public static string RemoveAtLastIndexOf(this string s, string Value, int Offset)
        {
            return s.Remove(s.LastIndexOf(Value) + Offset);
        }

        public static string RemoveAtLastIndexOf(this string s, char Value)
        {
            return s.Remove(s.LastIndexOf(Value));
        }

        public static string RemoveAtLastIndexOf(this string s, char Value, int Offset)
        {
            return s.Remove(s.LastIndexOf(Value) + Offset);
        }

        public static string Slice(this string s, int StartIndex, int EndIndex)
        {
            return s.Substring(StartIndex, EndIndex - StartIndex);
        }

        public static string[] Split(this string s, int Index)
        {
            return new[] { s.Remove(Index), s.Substring(Index) };
        }

        public static string[] SplitLines(this string s, StringSplitOptions Options)
        {
            return s.Split(new[] { "\r\n" }, Options);
        }

        public static int LeastIndexOf(this string s, params char[] Chars)
        {
            return Chars.Select(x => s.IndexOf(x)).OrderBy(x => x).First();
        }

        private static Encoding _encoding = Encoding.GetEncoding("iso-8859-1");

        public static byte[] GetBytes(this string s)
        {
            return _encoding.GetBytes(s);
        }

        public static string[] SplitLines(this string s)
        {
            return SplitLines(s, StringSplitOptions.None);
        }

        public static string Aggregate(this IEnumerable<string> s)
        {
            return s.Aggregate((x, y) => x + y);
        }

        public static string Aggregate(this IEnumerable<string> s, string Delimiter)
        {
            return s.Aggregate((x, y) => x + Delimiter + y);
        }

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

        public static string GetLine(this string s, int Index)
        {
            return s.GetSurroundingLines(Index, 0, 0);
        }

        public static int GetLineNumber(this string s, int Index)
        {
            return s.Split(Index)[0].SplitLines().Length - 1;
        }

        public static int GetLineIndex(this string s, int lineNumber)
        {
            if (lineNumber == 0)
            {
                return 0;
            }

            var currentLine = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '\n')
                {
                    if (++currentLine == lineNumber)
                    {
                        return i + 1;
                    }
                }
            }

            return -1;
        }

        public static string NormalizeLines(this string s)
        {
            return s
                .Replace("\r\n", "\n")
                .Replace('\r', '\n')
                .Replace("\n", "\r\n");            
        }

        public static string InsertLineNumbers(this string s, int startLine)
        {
            var sb = new StringBuilder(s);
            int line = startLine;
            string getLineStr() => (line++.ToString().PadLeft(4, '0') + ": ");
            sb.Insert(0, getLineStr());

            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == '\n')
                {
                    sb.Insert(i + 1, getLineStr());
                }
            }

            return sb.ToString();
        }

        public static string InsertLineNumbers(this string s)
        {
            return InsertLineNumbers(s, 1);
        }

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
