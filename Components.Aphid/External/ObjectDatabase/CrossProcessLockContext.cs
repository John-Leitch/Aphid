using System;
using System.Collections.Generic;
using System.IO;

namespace Components
{
    public sealed class CrossProcessLockContext : IDisposable
    {
        public const string DefaultLockName = "Global";

        private readonly Dictionary<string, CrossProcessLock> _locks = new Dictionary<string, CrossProcessLock>();

        public void AcquireLock() => AcquireLock(DefaultLockName);

        public void AcquireLock(string key)
        {
            CrossProcessLock l;
            bool lockExists;

            lock (_locks)
            {
                if (!(lockExists = _locks.TryGetValue(key, out l)))
                {
                    _locks.Add(key, l = CreateLock(key));
                }
            }

            if (lockExists)
            {
                l.Handle.WaitOne();
            }
        }

        public void ReleaseLock() => ReleaseLock(DefaultLockName);

        public void ReleaseLock(string key)
        {
            CrossProcessLock l;

            lock (_locks)
            {
                if (!_locks.TryGetValue(key, out l))
                {
                    throw new InvalidOperationException(
                        string.Format("No lock with key '{0}' exists.", key));
                }
            }

            l.Handle.Set();
        }

        public static CrossProcessLock CreateLock(string key) => CreateLock(key, false);

        public static CrossProcessLock CreateLock(string key, bool initialState) =>
            new CrossProcessLock(
                "SnowFlea_" + key.Replace(Path.DirectorySeparatorChar, '$'),
                initialState);

        public void Dispose()
        {
            lock (_locks)
            {
                foreach (var kvp in _locks)
                {
                    kvp.Value.Dispose();
                }

                _locks.Clear();
            }
        }
    }
}
