using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components
{
    public static class StringEnumerableExtension
    {
        public static string Join(this IEnumerable<string> source, string delimiter) =>
            string.Join(delimiter, source);

        public static string Join(this IEnumerable<string> source) =>
            source.Join("");

        public static string JoinLines(this IEnumerable<string> source) =>
            source.Join("\r\n");
    }
}
