
using System;
using System.Collections.Generic;

namespace Components.IO
{
    public readonly struct Allocation
    {
        private readonly MemoryManager _manager;

        //public bool IsCommitted;

        public readonly int Handle, UserSize, Size;

        public Allocation(
            MemoryManager manager, 
            int handle, 
            int userSize, 
            int size)
        {
            _manager = manager;
            Handle = handle;
            UserSize = userSize;
            Size = size;
        }

        public byte[] Read() => _manager.Read(this);

        public byte[] Read(int bufferSize) => _manager.Read(this, bufferSize);

        public void Write(byte[] buffer) => _manager.Write(this, buffer);

        public void Write(byte[] buffer, int length) => _manager.Write(this, buffer, length);

        public override bool Equals(object obj) => obj is Allocation && Equals((Allocation)obj);

        public override int GetHashCode()
        {
            var hashCode = 1675899751;
            hashCode = hashCode * -1521134295 + EqualityComparer<MemoryManager>.Default.GetHashCode(_manager);
            hashCode = hashCode * -1521134295 + Handle.GetHashCode();
            hashCode = hashCode * -1521134295 + UserSize.GetHashCode();
            hashCode = hashCode * -1521134295 + Size.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Allocation allocation1, Allocation allocation2) => allocation1.Equals(allocation2);

        public static bool operator !=(Allocation allocation1, Allocation allocation2) => !(allocation1 == allocation2);
    }
}
