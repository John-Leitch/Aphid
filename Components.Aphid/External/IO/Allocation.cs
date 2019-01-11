
namespace Components.IO
{
    public struct Allocation
    {
        private MemoryManager _manager;

        //public bool IsCommitted;

        public int Handle, UserSize, Size;

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

        public byte[] Read()
        {
            return _manager.Read(this);
        }

        public byte[] Read(int bufferSize)
        {
            return _manager.Read(this, bufferSize);
        }

        public void Write(byte[] buffer)
        {
            _manager.Write(this, buffer);
        }
    }
}
