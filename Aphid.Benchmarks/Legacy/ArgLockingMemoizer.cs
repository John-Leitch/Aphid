using System;
using System.Collections.Generic;
using System.Threading;

namespace Components.Legacy
{
    public class ArgLockingMemoizer<TArg, TResult>
    {
        private Dictionary<TArg, TResult> _cache;

        private readonly LockTable<TArg> _locks = new LockTable<TArg>();

        public ArgLockingMemoizer() => _cache = new Dictionary<TArg, TResult>();

        public ArgLockingMemoizer(IEqualityComparer<TArg> comparer) => _cache = new Dictionary<TArg, TResult>(comparer);

        public TResult Call(Func<TArg, TResult> func, TArg arg)
        {
            lock (_locks[arg])
            {
                TResult val;

                lock (_cache)
                {
                    if (_cache.TryGetValue(arg, out val))
                    {
                        return val;
                    }
                }

                val = func(arg);

                lock (_cache)
                {
                    _cache.Add(arg, val);
                }

                return val;
            }
        }

        public void Clear()
        {
            _cache.Clear();
            _locks.Clear();
        }
    }
}