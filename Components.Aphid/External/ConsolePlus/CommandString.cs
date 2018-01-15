using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.External.ConsolePlus
{
    public static class CommandString
    {
        public static string Create(string[] parts)
        {
            return string.Join(" ", parts.Select(Escape));
        }

        private static string Escape(string part)
        {
            return part.Contains(' ') || part.Contains('\t') || part.Contains('"') ?
                string.Format("\"{0}\"", part.Replace("\"", "\"\"")) :
                part;
        }
    }
}
