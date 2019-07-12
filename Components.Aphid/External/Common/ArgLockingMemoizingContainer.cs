using System;
using System.Collections.Generic;
using System.Threading;

namespace Components
{
    public class ArgLockingMemoizingContainer<TArg, TResult>
    {
        private readonly Dictionary<TArg, TResult> _cache;

        private readonly LockTable<TArg> _locks;

        private readonly ReaderWriterLockSlim _cacheLock = new ReaderWriterLockSlim();

        private readonly Func<TArg, TResult> _func;

        public ArgLockingMemoizingContainer(Func<TArg, TResult> func)
        {
            _cache = new Dictionary<TArg, TResult>();
            _locks = new LockTable<TArg>();
            _func = func;
        }

        public ArgLockingMemoizingContainer(
            IEqualityComparer<TArg> comparer,
            Func<TArg, TResult> func)
        {
            _cache = new Dictionary<TArg, TResult>(comparer);
            _locks = new LockTable<TArg>(comparer);
            _func = func;
        }

        public TResult Call(TArg arg)
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

                val = _func(arg);

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
    }
}
