using System.Collections.Generic;

namespace Components
{
    public class NamespaceEqualityComparer : IEqualityComparer<HashSet<string>>
    {
        public bool Equals(HashSet<string> x, HashSet<string> y)
        {
            if (x == null)
            {
                return y == null;
            }
            else if (y == null)
            {
                return x == null;
            }
            return x.Count != y.Count ? false : x.SetEquals(y);
        }

        public int GetHashCode(HashSet<string> obj)
        {
            var x = 0;

            foreach (var h in obj)
            {
                x ^= h.GetHashCode();
            }

            return x;
        }
    }
}
