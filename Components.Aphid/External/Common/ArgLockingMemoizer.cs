using System;
using System.Collections.Generic;
using System.Threading;

namespace Components
{
    public class ArgLockingMemoizer<TArg, TResult>
    {
        private readonly Dictionary<TArg, TResult> _cache;

        private readonly LockTable<TArg> _locks;

        private readonly ReaderWriterLockSlim _cacheLock = new ReaderWriterLockSlim();

        public ArgLockingMemoizer()
        {
            _cache = new Dictionary<TArg, TResult>();
            _locks = new LockTable<TArg>();
        }

        public ArgLockingMemoizer(IEqualityComparer<TArg> comparer)
        {
            _cache = new Dictionary<TArg, TResult>(comparer);
            _locks = new LockTable<TArg>(comparer);
        }

        public TResult Call(Func<TArg, TResult> func, TArg arg)
        {
            lock (_locks[arg])
            {
                TResult val;

                try
                {
                    _cacheLock.EnterReadLock();

                    if (_cache.TryGetValue(arg, out val))
                    {
                        return val;
                    }
                }
                finally
                {
                    _cacheLock.ExitReadLock();
                }

                val = func(arg);

                try
                {
                    _cacheLock.EnterWriteLock();
                    _cache.Add(arg, val);
                }
                finally
                {
                    _cacheLock.ExitWriteLock();
                }

                return val;
            }
        }

        public void Clear()
        {
            _cache.Clear();
            _locks.Clear();
        }

        public void Remove(TArg arg)
        {
            lock (_locks[arg])
            {
                _cache.Remove(arg);
            }
        }
    }
}
