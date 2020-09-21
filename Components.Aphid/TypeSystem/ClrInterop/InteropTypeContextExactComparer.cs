using System.Collections.Generic;
using System.Threading;

namespace Components.Aphid.TypeSystem
{
    public class InteropTypeContextExactComparer : IEqualityComparer<InteropTypeContext>
    {
        public bool Equals(InteropTypeContext x, InteropTypeContext y)
        {
            ReaderWriterLockSlim lock1 = x.ImportsLock, lock2 = y.ImportsLock;
            if (lock1 == lock2)
            {
                lock1.EnterReadLock();

                try
                {
                    if ((x.Imports == null && y.Imports != null) ||
                        (x.Imports != null && y.Imports == null) ||
                        (x.Path == null && y.Path != null) ||
                        (x.Path != null && y.Path == null) ||
                        (x.IsType != y.IsType))
                    {
                        return false;
                    }
                    else if (x.Imports != null &&
                        x.Imports != y.Imports &&
                        !y.Imports.SetEquals(x.Imports))
                    {
                        return false;
                    }
                    else if (x.Path == null)
                    {
                        return true;
                    }
                    else if (x.Path.Length != y.Path.Length)
                    {
                        return false;
                    }

                    var len = x.Path.Length;

                    for (var i = 0; i < len; i++)
                    {
                        if (x.Path[i] != y.Path[i])
                        {
                            return false;
                        }
                    }

                    return true;
                }
                finally
                {
                    lock1.ExitReadLock();
                }
            }
            else
            {
                lock1.EnterReadLock();
                lock2.EnterReadLock();

                try
                {
                    if ((x.Imports == null && y.Imports != null) ||
                        (x.Imports != null && y.Imports == null) ||
                        (x.Path == null && y.Path != null) ||
                        (x.Path != null && y.Path == null) ||
                        (x.IsType != y.IsType))
                    {
                        return false;
                    }
                    else if (x.Imports != null &&
                        x.Imports != y.Imports &&
                        !y.Imports.SetEquals(x.Imports))
                    {
                        return false;
                    }
                    else if (x.Path == null)
                    {
                        return true;
                    }
                    else if (x.Path.Length != y.Path.Length)
                    {
                        return false;
                    }

                    var len = x.Path.Length;

                    for (var i = 0; i < len; i++)
                    {
                        if (x.Path[i] != y.Path[i])
                        {
                            return false;
                        }
                    }

                    return true;
                }
                finally
                {
                    lock2.ExitReadLock();
                    lock1.ExitReadLock();
                }
            }
        }

        public int GetHashCode(InteropTypeContext obj)
        {
            var x = 0;

            for (var i = 0; i < obj.Path.Length; i++)
            {
                x ^= obj.Path[i].GetHashCode();
            }

            return obj.IsType ? x & ~0x1 : x | 0x1;
        }
    }
}
