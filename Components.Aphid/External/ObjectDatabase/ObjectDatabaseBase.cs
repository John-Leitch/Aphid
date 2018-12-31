using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.ConstrainedExecution;

namespace Components.ObjectDatabase
{
    public abstract class ObjectDatabaseBase<TElement> : CriticalFinalizerObject, IDatabaseContext<TElement>
    {
        private CrossProcessLockContext _locks = new CrossProcessLockContext();

        public bool IsOpened { get; private set; }

        public string Filename { get; private set; }

        public void Open()
        {
            if (IsOpened)
            {
                throw new InvalidOperationException("Database already opened.");
            }

            OpenCore();
            IsOpened = true;
        }

        public ObjectDatabaseBase()
            : this(typeof(TElement).FullName + ".odb")
        {
        }

        public ObjectDatabaseBase(string filename) => Filename = Path.GetFullPath(filename);

        public void AcquireLock() => _locks.AcquireLock();

        public void AcquireLock(string key) => _locks.AcquireLock(key);

        public void ReleaseLock() => _locks.ReleaseLock();

        public void ReleaseLock(string key) => _locks.ReleaseLock(key);

        public void Sync(Action action) => Sync(Filename.ToLower(), action);

        public TResult Sync<TResult>(Func<TResult> func) => Sync(Filename.ToLower(), func);

        public void Sync(string key, Action action)
        {
            using (_locks.CreateLock(key))
            {
                action();
            }
        }

        public TResult Sync<TResult>(string key, Func<TResult> func)
        {
            using (_locks.CreateLock(key))
            {
                return func();
            }
        }

        public virtual void Dispose() => _locks.Dispose();

        protected abstract void OpenCore();

        public abstract void Create(TElement element);

        public abstract TElement ReadUnsafe(long offset);

        public abstract IEnumerable<TElement> ReadUnsafe();

        public abstract void Update(TElement element);

        public abstract int Count();

        public abstract Dictionary<TIndex, List<int>> Index<TIndex>(Func<TElement, TIndex> selector);        
    }

}
