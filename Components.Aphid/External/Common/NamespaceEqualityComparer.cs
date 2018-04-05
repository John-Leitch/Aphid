using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public class NamespaceEqualityComparer : IEqualityComparer<List<string>>
    {
        public bool Equals(List<string> x, List<string> y)
        {
            if (x == null)
            {
                return y == null;
            }
            else if (y == null)
            {
                return x == null;
            }
            if (x.Count != y.Count)
            {
                return false;
            }
            else
            {
                for (var i = 0; i < x.Count; i++)
                {
                    if (x[i] != y[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public int GetHashCode(List<string> obj)
        {
            var x = 2;

            unchecked
            {
                for (var i = 0; i < obj.Count; i++)
                {
                    var t = obj[i].GetHashCode();

                    x *= t != 0 ? t : 8;

                    if (x == 0 || x == 1)
                    {
                        x = 9;
                    }
                }
            }

            return x;
        }
    }
}
