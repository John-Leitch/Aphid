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
                (x.PathHashSet == null && y.PathHashSet != null) ||
                (x.PathHashSet != null && y.PathHashSet == null) ||
                (x.IsType != y.IsType))
            {
                return false;
            }
            else if (x.Imports != null)
            {
                if (!x.IsResolved || !y.Imports.IsSubsetOf(x.Imports))
                {
                    return false;
                }
            }

            if (x.PathHashSet != null)
            {
                return x.PathHashSet.SequenceEqual(y.PathHashSet);
            }
            else
            {
                return true;
            }
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
                return ~x;
            }
            else
            {
                return x;
            }
        }
    }
}
