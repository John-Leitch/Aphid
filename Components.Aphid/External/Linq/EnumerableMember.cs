using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Components
{
    public static class EnumerableMember
    {
        public static EnumerableMember<TSource, TMember> Create<TSource, TMember>(
            IEnumerable<TSource> source,
            Func<TSource, TMember> selector) =>
                new EnumerableMember<TSource, TMember>(source, selector);
    }
}
