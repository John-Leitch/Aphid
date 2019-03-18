using System;
using System.Collections.Generic;
using System.Threading;

namespace Components
{
    public class DirectArgLockingMemoizer<TArg, TResult>
    {
        private readonly Dictionary<TArg, TResult> _cache;

        private readonly ReaderWriterLockSlim _cacheLock = new ReaderWriterLockSlim();

        public DirectArgLockingMemoizer() => _cache = new Dictionary<TArg, TResult>();

        public DirectArgLockingMemoizer(IEqualityComparer<TArg> comparer) => _cache = new Dictionary<TArg, TResult>(comparer);

        public TResult Call(Func<TArg, TResult> func, TArg arg)
        {
            lock (arg)
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

        public void Clear() => _cache.Clear();
    }
}
