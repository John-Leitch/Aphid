using System;
using System.Collections.Generic;
using System.IO;

namespace Components.IO
{
    public class MemoryManager
    {
        private readonly int _initialGrowSize;

        private int _growSize;

        private Stream _stream;

        private bool[] _bitmap;

        public bool[] Bitmap => _bitmap;

        public int StartingPosition { get; private set; } = 0;

        public Dictionary<int, int> Allocations { get; } = new Dictionary<int, int>();

        public int PageSize { get; set; }

        public bool ZeroMemory { get; set; }

        public MemoryManager(Stream stream)
            : this(stream, 0x1000)
        {
        }

        public MemoryManager(Stream stream, int pageSize)
        {
            _stream = stream;
            _initialGrowSize = _growSize = PageSize = pageSize;
            _bitmap = new bool[_growSize];
            ZeroMemory = true;
        }

        public MemoryManager(
            Stream stream,
            bool[] bitmap,
            Dictionary<int, int> sizeTable,
            int pageSize,
            bool zeroMemory,
            int startingPosition)
        {
            _stream = stream;
            _bitmap = bitmap;
            Allocations = sizeTable;
            _initialGrowSize = _growSize = PageSize = pageSize;
            ZeroMemory = zeroMemory;
            StartingPosition = startingPosition;
        }

        private void Grow(int pagesNeeded)
        {
            while (_growSize < pagesNeeded)
            {
                _growSize += _initialGrowSize;
            }

            Array.Resize(ref _bitmap, _bitmap.Length + _growSize);
        }

        public Allocation Allocate(int size)
        {
            var pageCount = GetPageCount(size);
            int index;

            lock (_bitmap)
            {
                while ((index = FindBlock(pageCount)) == -1)
                {
                    Grow(pageCount);
                }

                MarkBlock(index, pageCount);
            }

            var actualSize = pageCount * PageSize;

            return new Allocation(this, index, size, actualSize);
        }

        public void FreeOffset(long offset)
        {
            var handle = (int)(offset / PageSize);
            Free(handle, Allocations[handle]);
        }

        public void Free(in Allocation allocation) => Free(allocation.Handle, allocation.Size);

        public void Free(int handle, int size)
        {
            var pageCount = Allocations[handle];

            if (ZeroMemory)
            {
                lock (_stream)
                {
                    SetPosition(handle);
                    var buffer = new byte[size];
                    _stream.Write(buffer);
                }
            }

            lock (_bitmap)
            {
                ClearBlock(handle, pageCount);

                // _startingPosition is synchronized via _bitmap
                if (StartingPosition > handle)
                {
                    StartingPosition = handle;
                }
            }            
        }

        public byte[] Read(in Allocation allocation) => Read(allocation, GetSize(allocation));

        public byte[] Read(int handle) => Read(handle, GetSize(handle));

        public byte[] Read(int handle, int bufferSize)
        {
            lock (_stream)
            {
                SetPosition(handle);

                return _stream.Read(bufferSize);
            }
        }

        public byte[] Read(in Allocation allocation, int bufferSize)
        {
            lock (_stream)
            {
                SetPosition(allocation);

                return _stream.Read(bufferSize);
            }
        }

        public void Write(in Allocation allocation, byte[] buffer)
        {
            var size = GetSize(allocation);

            if (buffer.Length > size)
            {
                throw new InternalBufferOverflowException();
            }

            lock (_stream)
            {
                SetPosition(allocation);
                _stream.Write(buffer);
                _stream.Flush();
            }
        }

        private int GetPageCount(int size)
        {
            var x = size / PageSize;

            if ((size % PageSize) != 0)
            {
                x++;
            }

            return x;
        }

        private int FindBlock(int pageCount)
        {
            for (int x = StartingPosition; x <= _bitmap.Length - pageCount; x++)
            {
                var isMatch = true;

                for (int y = 0; y < pageCount; y++)
                {
                    if (_bitmap[x + y])
                    {
                        isMatch = false;
                        break;
                    }
                }

                if (isMatch)
                {
                    StartingPosition = x + pageCount;
                    return x;
                }
            }

            return -1;
        }

        private void MarkBlock(int index, int pageCount) => SetBlock(index, pageCount, true);

        private void ClearBlock(int index, int pageCount) => SetBlock(index, pageCount, false);

        private void SetBlock(int index, int pageCount, bool value)
        {
            if (value)
            {
                Allocations.Add(index, pageCount);
            }
            else
            {
                Allocations.Remove(index);
            }

            for (int i = index; i < index + pageCount; i++)
            {
                _bitmap[i] = value;
            }
        }

        public int GetSizeFromOffset(long offset) => Allocations[(int)(offset / PageSize)] * PageSize;

        private int GetSize(in Allocation allocation) => Allocations[allocation.Handle] * PageSize;

        private int GetSize(int handle) => Allocations[handle] * PageSize;

        public long GetPosition(in Allocation allocation) => (long)allocation.Handle * PageSize;

        private long GetPosition(int handle) => (long)handle * PageSize;

        private void SetPosition(in Allocation allocation) => _stream.Position = GetPosition(allocation);

        private void SetPosition(int handle) => _stream.Position = GetPosition(handle);
    }
}
