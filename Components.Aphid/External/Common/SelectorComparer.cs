using System;

namespace Components
{
    public static class SelectorComparer
    {
        public static SelectorComparer<TSource, TResult> Create<TSource, TResult>(
            Func<TSource, TResult> selector) =>
            new SelectorComparer<TSource, TResult>(selector);
    }
}
