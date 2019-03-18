using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Components
{
    public sealed class LockTable<TKey>
    {
        private readonly ConcurrentDictionary<TKey, object> _locks;

        public LockTable() =>
            _locks = new ConcurrentDictionary<TKey, object>();

        public LockTable(IEqualityComparer<TKey> comparer) =>
            _locks = new ConcurrentDictionary<TKey, object>(comparer);

        public object this[TKey key] => _locks.GetOrAdd(key, x => new object());

        public void Clear() => _locks.Clear();
    }
}
