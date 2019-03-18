using System;

namespace Components.ObjectDatabase
{
    public interface IDatabaseContext : IDisposable
    {
        bool IsOpened { get; }

        void Open();

        void AcquireLock();

        void AcquireLock(string key);

        void ReleaseLock();

        void ReleaseLock(string key);
    }
}
