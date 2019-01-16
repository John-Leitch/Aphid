using Components.PInvoke;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Cypress
{
    public class StackDumper
    {
        public IntPtr Process { get; private set; }

        public uint ThreadId { get; private set; }

        public StackDumper(IntPtr process, uint threadId)
        {
            Process = process;
            ThreadId = threadId;
        }

        private static bool IsStackAddress(CONTEXT context, uint address)
        {
            var delta = context.Esp > address ?
                context.Esp - address :
                address - context.Esp;

            return delta < 1000;
        }

        private static IntPtr[] GetIntPtrs(IEnumerable<uint> uints)
        {
            var ptrs = new List<IntPtr>();

            foreach (var u in uints)
            {
                try
                {
                    ptrs.Add((IntPtr)u);
                }
                catch (OverflowException)
                {
                }
            }

            return ptrs.ToArray();
        }

        public List<uint> GetFunctionPointers(int count)
        {
            var pointers = new List<uint>();
            var reader = new ProcessMemory(Process);
            var context = ProcessMemory.GetContext(ThreadId);
            //var pointers = new List<uint> { context.Eip };

            uint[] stack = null;
            var ptr = IntPtr.Zero;
            try
            {
                ptr = (IntPtr)context.Esp;
            }
            catch { }

            if (ptr != IntPtr.Zero)
            {
                stack = reader.ReadUInt32s(ptr, count / 4);
            }

            if (stack == null)
            {
                return null;
            }

            foreach (var p in GetIntPtrs(stack))
            {
                var bytes = reader.ReadBytes(p, 0x20);

                if (bytes == null ||
                    //IsStackAddress(context, (uint)p) ||
                    !reader.IsExecutable(p))
                {
                    continue;
                }

                pointers.Add((uint)p);

                //var dasm = new DiStormWrapper().Disassemble(bytes);
            }

            return pointers;
        }

        public List<uint> GetFunctionPointers()
        {
            return GetFunctionPointers(0x100);
        }
    }
}
