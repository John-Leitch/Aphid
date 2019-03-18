using Components.PInvoke;
using System;
using System.Collections.Generic;

namespace Components.Cypress
{
    public class TrampolineHeap
    {
        private readonly ProcessMemory _memory;

        private readonly List<IntPtr> _blocks = new List<IntPtr>();

        private IntPtr _currentPointer = IntPtr.Zero;

        private int _bytesRemaining = -1;

        public uint BlockSize { get; set; }

        public TrampolineHeap(ProcessMemory memory)
        {
            BlockSize = 0x1000;
            _memory = memory;
        }

        public IntPtr Allocate(uint size)
        {
            if (size > _bytesRemaining)
            {
                AllocateNewBlock();
            }

            _bytesRemaining -= (int)size;
            var i = _currentPointer;
            _currentPointer = (IntPtr)((uint)_currentPointer + size);

            return i;
        }

        private void AllocateNewBlock()
        {
            _currentPointer = _memory.Allocate(BlockSize, MemoryProtection.ExecuteRead);
            _bytesRemaining = (int)BlockSize;
        }
    }
}
