using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Components
{
    public class ReferenceEqualityComparer<T> : IEqualityComparer<T>
    {
        public bool Equals(T x, T y) => ReferenceEquals(x, y);

        public int GetHashCode(T obj) => RuntimeHelpers.GetHashCode(obj);
    }
}