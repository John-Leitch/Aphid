using System.Linq;

namespace Components.External.ConsolePlus
{
    public static class CommandString
    {
        public static string Create(string[] parts) => string.Join(" ", parts.Select(Escape));

        private static string Escape(string part) => part.Contains(' ') || part.Contains('\t') || part.Contains('"') ?
                string.Format("\"{0}\"", part.Replace("\"", "\"\"")) :
                part;
    }
}
