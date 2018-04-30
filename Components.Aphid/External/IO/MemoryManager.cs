using System;
using System.Collections.Generic;
using System.IO;

namespace Components.IO
{
    public class MemoryManager
    {
        private const int _growSize = 0x100;

        private Stream _stream;

        private int _startingPosition = 0;

        private bool[] _bitmap;

        public bool[] Bitmap
        {
            get { return _bitmap; }
        }

        private Dictionary<int, int> _allocations = new Dictionary<int, int>();

        public Dictionary<int, int> Allocations
        {
            get { return _allocations; }
        }

        public int PageSize { get; private set; }

        public bool ZeroMemory { get; set; }

        public MemoryManager(Stream stream)
            : this(stream, 0x1000)
        {
        }

        public MemoryManager(Stream stream, int pageSize)
        {
            _stream = stream;
            PageSize = pageSize;
            _bitmap = new bool[_growSize];
            ZeroMemory = true;
        }

        public MemoryManager(
            Stream stream,
            bool[] bitmap,
            Dictionary<int, int> sizeTable,
            int pageSize,
            bool zeroMemory)
        {
            _stream = stream;
            _bitmap = bitmap;
            _allocations = sizeTable;
            PageSize = pageSize;
            ZeroMemory = zeroMemory;
        }

        private void Grow()
        {
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
                    Grow();
                }

                MarkBlock(index, pageCount);
            }

            var actualSize = pageCount * PageSize;

            return new Allocation(this, index, size, actualSize);
        }

        public void FreeOffset(long offset)
        {
            var handle = (int)(offset / PageSize);
            Free(handle, _allocations[handle]);
        }

        public void Free(Allocation allocation)
        {
            Free(allocation.Handle, allocation.Size);
        }

        public void Free(int handle, int size)
        {
            var pageCount = _allocations[handle];

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
                if (_startingPosition > handle)
                {
                    _startingPosition = handle;
                }
            }            
        }

        public byte[] Read(Allocation allocation)
        {
            return Read(allocation, GetSize(allocation));
        }

        public byte[] Read(int handle)
        {
            return Read(handle, GetSize(handle));
        }

        public byte[] Read(int handle, int bufferSize)
        {
            lock (_stream)
            {
                SetPosition(handle);

                return _stream.Read(bufferSize);
            }
        }

        public byte[] Read(Allocation allocation, int bufferSize)
        {
            lock (_stream)
            {
                SetPosition(allocation);

                return _stream.Read(bufferSize);
            }
        }

        public void Write(Allocation allocation, byte[] buffer)
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
            for (int x = _startingPosition; x <= _bitmap.Length - pageCount; x++)
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
                    _startingPosition = x + pageCount;
                    return x;
                }
            }

            return -1;
        }

        private void MarkBlock(int index, int pageCount)
        {
            SetBlock(index, pageCount, true);
        }

        private void ClearBlock(int index, int pageCount)
        {
            SetBlock(index, pageCount, false);
        }

        private void SetBlock(int index, int pageCount, bool value)
        {
            if (value)
            {
                _allocations.Add(index, pageCount);
            }
            else
            {
                _allocations.Remove(index);
            }

            for (int i = index; i < index + pageCount; i++)
            {
                _bitmap[i] = value;
            }
        }

        public int GetSizeFromOffset(long offset)
        {
            return _allocations[(int)(offset / PageSize)] * PageSize;
        }

        private int GetSize(Allocation allocation)
        {
            return _allocations[allocation.Handle] * PageSize;
        }

        private int GetSize(int handle)
        {
            return _allocations[handle] * PageSize;
        }

        public int GetPosition(Allocation allocation)
        {
            return allocation.Handle * PageSize;
        }

        private int GetPosition(int handle)
        {
            return handle * PageSize;
        }

        private void SetPosition(Allocation allocation)
        {
            _stream.Position = GetPosition(allocation);
        }

        private void SetPosition(int handle)
        {
            _stream.Position = GetPosition(handle);
        }
    }
}
