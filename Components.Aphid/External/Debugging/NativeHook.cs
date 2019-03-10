using Components;
using Components.Cypress.IA32;
using Components.PInvoke;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Cypress
{
    public static class NativeHook
    {
        private static byte[] CreateJmpRel32(uint offset)
        {
            var addrBytes = BitConverter.GetBytes(offset);

            return new byte[5]
            {
                0xE9,
                addrBytes[0],
                addrBytes[1],
                addrBytes[2],
                addrBytes[3]
            };
        }

        private static byte[] CreateJmpRel32(uint source, uint destination) => CreateJmpRel32(destination - source - 0x5);

        private static readonly byte[] _nops = Enumerable
            .Range(0x0, 0x100)
            .Select(x => (byte)0x90)
            .ToArray();

        public static bool Hook(ProcessMemory memory, IntPtr funcAddr, TrampolineHeap heap)
        {
            var objectCode = _nops.ToArray();
            var trampolineAddr = heap.Allocate((uint)objectCode.Length);
            var jmpToTrampoline = CreateJmpRel32((uint)funcAddr, (uint)trampolineAddr);
            var originalCode = memory.ReadBytes(funcAddr, 0x100);
            var bytes = originalCode.Select(x => string.Format("{0:X2}", x)).Join(" ");
            var dasm = IA32Disassembler.Disassemble(originalCode);

            var matches = dasm
                .TakeWhile(x => ((Opcode[])Enum.GetValues(typeof(Opcode))).Contains(x.Opcode.Opcode))
                .ToArray();

            var matchSum = matches.Sum(x => x.Size);
            var sum = 0;
            dasm.TakeWhile(x => (sum += x.Size) < jmpToTrampoline.Length).ToArray();

            if (matchSum < sum)
            {
                return false;
            }

            var originalCodeCopy = originalCode.ToArray();
            Array.Resize(ref originalCode, sum);
            originalCodeCopy = originalCodeCopy.Skip(originalCode.Length).ToArray();
            //0x10 8B 4C 24 14 8B 7C 24 0C 8B
            if (originalCodeCopy[0] == 0x10 &&
                originalCodeCopy[1] == 0x8B &&
                originalCodeCopy[2] == 0x4C &&
                originalCodeCopy[3] == 0x24 &&
                originalCodeCopy[4] == 0x14 &&
                originalCodeCopy[5] == 0x8B &&
                originalCodeCopy[6] == 0x7C &&
                originalCodeCopy[7] == 0x24 &&
                originalCodeCopy[8] == 0x0C &&
                originalCodeCopy[9] == 0x8B)
            {
                Console.WriteLine();
            }

            const int originalCodeOffset = 0x10;

            originalCode.CopyTo(objectCode, originalCodeOffset);
            var jmpToFuncOffset = (uint)originalCodeOffset + (uint)originalCode.Length + 0x4;
            //objectCode[(uint)originalCodeOffset + (uint)originalCode.Length + 1] = 0xCC;

            var jmpToFunc = CreateJmpRel32(
                (uint)trampolineAddr + jmpToFuncOffset,
                (uint)funcAddr + (uint)originalCode.Length);

            jmpToFunc.CopyTo(objectCode, jmpToFuncOffset);
            memory.Write(trampolineAddr, objectCode);
            memory.Write(funcAddr, jmpToTrampoline);

            return true;
        }
    }
}
