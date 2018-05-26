using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.TypeSystem
{
    public class InteropTypeContextComparer : IEqualityComparer<InteropTypeContext>
    {
        public bool Equals(InteropTypeContext x, InteropTypeContext y)
        {
            if ((x.Imports == null && y.Imports != null) ||
                (x.Imports != null && y.Imports == null) ||
                (x.Path == null && y.Path != null) ||
                (x.Path != null && y.Path == null) ||
                (x.IsType != y.IsType))
            {
                return false;
            }
            else if (x.Imports != null)
            {
                if (x.Imports.Length == y.Imports.Length)
                //if (x.Imports.Length == y.Imports.Length ||
                //    (x.IsResolved && x.Imports.Length < y.Imports.Length))
                {
                    for (var i = 0; i < x.Imports.Length; i++)
                    {
                        if (x.Imports[i] != y.Imports[i])
                        {
                            return false;
                        }
                    }
                }
                else if (x.IsResolved && x.Imports.Length < y.Imports.Length)
                {
                    for (var i = 0; i < x.Imports.Length; i++)
                    {
                        if (x.Imports[i] != y.Imports[i])
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }

            if (x.Path != null)
            {
                if (x.Path.Length == y.Path.Length)
                {
                    for (var i = 0; i < x.Path.Length; i++)
                    {
                        if (x.Path[i] != y.Path[i])
                        {
                            return false;
                        }
                    }

                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public int GetHashCode(InteropTypeContext obj)
        {
            var x = 2;

            unchecked
            {
                for (var i = 0; i < obj.Imports.Length; i++)
                {
                    var t = obj.Imports[i].GetHashCode();

                    x *= t != 0 ? t : 8;

                    if (x == 0 || x == 1)
                    {
                        x = 9;
                    }
                }

                for (var i = 0; i < obj.Path.Length; i++)
                {
                    var t = obj.Path[i].GetHashCode();

                    x *= t != 0 ? t : 10;

                    if (x == 0 || x == 1)
                    {
                        x = 11;
                    }
                }

                x *= obj.IsType ? 7 : 9;
            }

            return x;
        }
    }
}
