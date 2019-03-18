using System;

namespace Components.Cypress
{
    public class HookManager
    {
        private readonly ProcessMemory _memory;

        private readonly TrampolineHeap _heap;

        public HookManager(ProcessMemory memory) => _heap = new TrampolineHeap(_memory = memory);

        public bool Hook(IntPtr funcAddr) => NativeHook.Hook(_memory, funcAddr, _heap);
    }
}
