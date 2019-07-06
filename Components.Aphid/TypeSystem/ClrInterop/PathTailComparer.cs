#define TYPE_CACHE_NULL
using System.Collections.Generic;

namespace Components.Aphid.TypeSystem
{
    public class PathTailComparer : IEqualityComparer<string[]>
    {
        public bool Equals(string[] x, string[] y)
        {
            //Cli.WriteLine($"Comparing ~Cyan~{string.Join(".", x)}~R~ to ~Cyan~{string.Join(".", y)}~R~");

            if (x.Length < y.Length)
            {
                var off = y.Length - x.Length;

                for (var i = x.Length - 1; i >= 0; i--)
                {
                    if (x[i] != y[i + off])
                    {
                        return false;
                    }
                }
            }
            else if (y.Length < x.Length)
            {
                var off = x.Length - y.Length;

                for (var i = y.Length - 1; i >= 0; i--)
                {
                    if (y[i] != x[i + off])
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (var i = x.Length - 1; i >= 0; i--)
                {
                    if (x[i] != y[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public int GetHashCode(string[] obj) =>
            obj.Length > 0 ? obj[obj.Length - 1].GetHashCode() : 0xbad;
    }
}
