using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid
{
    public static class CacheName
    {
        private static readonly ArgLockingMemoizer<string, string> _sanitizeMemoizer =
            new ArgLockingMemoizer<string, string>(StringComparer.OrdinalIgnoreCase);

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
            string SanitizeCore(string innerFilename)
            {
                for (var i = 0; i < _replacements.Length; i++)
                {
                    var r = _replacements[i];
                    innerFilename = innerFilename.Replace(r.Item1, r.Item2);
                }

                return innerFilename.ToLower();
            }

            if (Path.IsPathRooted(filename))
            {
                return _sanitizeMemoizer.Call(SanitizeCore, filename);
            }

            return _sanitizeMemoizer.Call(SanitizeCore, Path.GetFullPath(filename));
        }

        public static string Normalize(string filename)
        {
            if (Path.IsPathRooted(filename))
            {
                return filename.Replace('/', '\\').ToLower();
            }

            return Path.GetFullPath(filename.Replace('/', '\\')).ToLower();
        }
    }
}
