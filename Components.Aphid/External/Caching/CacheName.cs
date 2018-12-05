using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Caching
{
    public static class CacheName
    {
        private static readonly (string, string)[] _replacements = new[]
            {
                ':',
                '\\',
                '/',
            }
            .Select(x => (x.ToString(), string.Format("${0:x2}", (byte)x)))
            .Prepend(("$", "$$"))
            .ToArray();

        public static string Sanitize(string filename)
        {
            var sanitized = Path.GetFullPath(filename);

            for (var i = 0; i < _replacements.Length; i++)
            {
                var r = _replacements[i];
                sanitized = sanitized.Replace(r.Item1, r.Item2);
            }

            return sanitized.ToLower();
        }

        public static string Normalize(string filename) =>
            Path.GetFullPath(filename.Replace('/', '\\')).ToLower();
    }
}
