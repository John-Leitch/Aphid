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

        public SelectorComparer(Func<TSource, TResult> selector) => _selector = selector;

        public bool Equals(TSource x, TSource y) => _selector(x).Equals(_selector(y));

        public int GetHashCode(TSource obj) => _selector(obj).GetHashCode();
    }

    public static class SelectorComparer
    {
        public static SelectorComparer<TSource, TResult> Create<TSource, TResult>(
            Func<TSource, TResult> selector) =>
            new SelectorComparer<TSource, TResult>(selector);
    }
}
