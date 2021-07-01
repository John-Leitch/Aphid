using System;
using System.Collections.Generic;

namespace Components
{
    public static class EnumerableMember
    {
        public static EnumerableMember<TSource, TMember> Create<TSource, TMember>(
            IEnumerable<TSource> source,
            Func<TSource, TMember> selector) =>
                new(source, selector);
    }
}
