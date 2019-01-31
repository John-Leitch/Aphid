using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components
{
    public static class SelectorComparer
    {
        public static SelectorComparer<TSource, TResult> Create<TSource, TResult>(
            Func<TSource, TResult> selector) =>
            new SelectorComparer<TSource, TResult>(selector);
    }
}
