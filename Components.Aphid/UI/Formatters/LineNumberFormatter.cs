using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.UI.Formatters
{
    public static class LineNumberFormatter
    {
        public static string Format(int index) =>
            string.Format("[~White~{0:x2}~R~] ", index);

        public static string PrefixIndex(int index, string value) =>
            string.Format("[~White~{0:x2}~R~] {1}", index, value);
    }
}
