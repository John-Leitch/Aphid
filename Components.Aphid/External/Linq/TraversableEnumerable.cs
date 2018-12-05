using System;
using System.Collections.Generic;

namespace Components
{
    public static class TraversableEnumerable
    {
        public static EnumerableMember<TSource, TChild> Member<TSource, TChild>(
            this IEnumerable<TSource> source,
            Func<TSource, TChild> selector) =>
                EnumerableMember.Create(source, selector);

        public static EnumerableMember<TSource, TSource> Element<TSource>(
            this IEnumerable<TSource> source) =>
                EnumerableMember.Create(source, x => x);
    }
}
