using Components.PInvoke;
using System;
using System.Collections.Generic;

namespace Components.Cypress
{
    public class BreakpointManager
    {
        private readonly ProcessMemory mem;

        public Dictionary<IntPtr, byte> BreakpointTable { get; }

        public Dictionary<IntPtr, uint> HitTable { get; }

        public int MaxHits { get; set; }

        public Cache<uint, IntPtr> ThreadCache { get; set; }

        private IntPtr lastBreakpoint = IntPtr.Zero;

        public BreakpointManager(ProcessMemory memory)
        {
            BreakpointTable = new Dictionary<IntPtr, byte>();
            HitTable = new Dictionary<IntPtr, uint>();
            MaxHits = 0x1;
            ThreadCache = new Cache<uint, IntPtr>(x => Kernel32.OpenThread(
                ThreadAccess.THREAD_GET_CONTEXT | ThreadAccess.THREAD_SET_CONTEXT,
                false,
                x));
            mem = memory;
        }

        public bool SetBreakpoint(IntPtr address)
        {
            if (BreakpointTable.ContainsKey(address))
            {
                return false;
            }

            var buffer = mem.ReadBytes(address, 0x1);
            BreakpointTable.Add(address, buffer[0]);
            HitTable.Add(address, 0);
            mem.Write(address, new byte[] { 0xCC });

            return true;
        }

        public bool HandleException(
            DebuggerEventArgs e,
            Action<IntPtr> breakpointHit)
        {
            switch (e.DebugEvent.Exception.ExceptionRecord.ExceptionCode)
            {
                case ExceptionCode.EXCEPTION_BREAKPOINT:
                    var addr = (IntPtr)e.DebugEvent.Exception.ExceptionRecord.ExceptionAddress;
                    if (!BreakpointTable.TryGetValue(addr, out _))
                    {
                        return false;
                    }

                    uint hits;

                    lock (HitTable)
                    {
                        hits = ++HitTable[addr];
                        //var hits2 = HitTable.OrderByDescending(x => x.Value).ToArray();
                    }

                    //var writeResult = mem.Write(addr, new[] { originalByte });

                    if (MaxHits <= 0 || hits < MaxHits)
                    {
                        ThreadContext.EnableSingleStep(ThreadCache[e.DebugEvent.dwThreadId], (uint)addr);
                    }
                    else
                    {
                        ThreadContext.SetEip(ThreadCache[e.DebugEvent.dwThreadId], (uint)addr);
                    }

                    lastBreakpoint = addr;
                    breakpointHit(addr);
                    e.DebugEvent.ContinueHandled();
                    return true;

                case ExceptionCode.EXCEPTION_SINGLE_STEP:
                    mem.Write(lastBreakpoint, new byte[] { 0xCC });
                    lastBreakpoint = IntPtr.Zero;
                    ThreadContext.DisableSingleStep(ThreadCache[e.DebugEvent.dwThreadId]);
                    e.DebugEvent.ContinueHandled();
                    return true;

                default:
                    return false;
            }
        }
    }
}
