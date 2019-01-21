using Components.External.ConsolePlus;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
    }
}
