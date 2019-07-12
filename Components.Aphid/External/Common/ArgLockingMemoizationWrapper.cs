using System.Collections.Generic;
using System.Threading;

namespace Components
{
    public abstract class ArgLockingMemoizationWrapper<TArg, TResult>
    {
        private readonly Dictionary<TArg, TResult> _cache;

        private readonly LockTable<TArg> _locks;

        private readonly ReaderWriterLockSlim _cacheLock = new ReaderWriterLockSlim();

        public ArgLockingMemoizationWrapper()
        {
            _cache = new Dictionary<TArg, TResult>();
            _locks = new LockTable<TArg>();
        }

        protected abstract IEqualityComparer<TArg> GetComparer();

        protected abstract TResult CallCore(TArg arg);

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

                val = CallCore(arg);

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
    }
}
