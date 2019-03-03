using System;
using System.Collections.Generic;

namespace Components.ObjectDatabase
{
    public interface IDatabaseContext<TElement> : IDatabaseContext
    {
        void Create(TElement element);

        IEnumerable<TElement> ReadUnsafe();

        void Update(TElement element);

        int Count();

        Dictionary<TIndex, List<int>> Index<TIndex>(Func<TElement, TIndex> selector);
    }
}
