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
                if (x.IsResolved && !y.Imports.IsSubsetOf(x.Imports))
                {
                    return false;
                }
                else if (!x.IsResolved && !y.Imports.SetEquals(x.Imports))
                {
                    return false;
                }
            }

            if (x.Path != null)
            {
                if (x.Path.Length != y.Path.Length)
                {
                    return false;
                }

                for (var i = 0; i < x.Path.Length; i++)
                {
                    if (x.Path[i] != y.Path[i])
                    {
                        return false;
                    }
                }

                return true;
            }

            return true;
        }

        public int GetHashCode(InteropTypeContext obj)
        {
            var x = 0;

            for (var i = 0; i < obj.Path.Length; i++)
            {
                x ^= obj.Path[i].GetHashCode();
            }

            if (obj.IsType)
            {
                return x & ~0x1;
            }

            return x | 0x1;
        }
    }
}
