using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public class SelectorComparer<TSource, TResult> : IEqualityComparer<TSource>
    {
        private readonly Func<TSource, TResult> _selector;

        public SelectorComparer(Func<TSource, TResult> selector)
        {
            _selector = selector;
        }

        public bool Equals(TSource x, TSource y)
        {
            return _selector(x).Equals(_selector(y));
        }

        public int GetHashCode(TSource obj)
        {
            return _selector(obj).GetHashCode();
        }
    }
}
