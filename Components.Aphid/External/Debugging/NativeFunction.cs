using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Cypress
{
    [Serializable]
    public class NativeFunction
    {
        public uint Address { get; set; }

        public string Name { get; set; }

        public int Size { get; set; }

        public Instruction[] Disassembly { get; set; }

        public NativeFunction()
        {
        }

        public NativeFunction(uint address, string name, int size)
            : this()
        {
            Address = address;
            Name = name;
            Size = size;
        }

        public override string ToString() => string.Format("{0:X8}: {1}", Address, Name);

        public void Serialize(StringTable table, BinaryWriter writer)
        {
            writer.Write(Address);
            writer.Write(table[Name]);
            writer.Write(Size);
            writer.Write(Disassembly.Length);
            foreach (var d in Disassembly)
            {
                d.Serialize(table, writer);
            }
        }

        public static void Serialize(Stream stream, NativeFunction[] functions)
        {
            var writer = new BinaryWriter(stream);

            writer.Write(0);
            writer.Write(functions.Length);
            var table = new StringTable();

            foreach (var f in functions)
            {
                f.Serialize(table, writer);
            }

            table.Serialize(writer);
        }

        public static NativeFunction Deserialize(StringTable table, BinaryReader reader)
        {
            var func = new NativeFunction
            {
                Address = reader.ReadUInt32(),
                Name = table[reader.ReadInt32()],
                Size = reader.ReadInt32(),
                Disassembly = Enumerable
                    .Range(0, reader.ReadInt32())
                    .Select(x => Instruction.Deserialize(table, reader))
                    .ToArray(),
            };

            foreach (var inst in func.Disassembly)
            {
                inst.Function = func;
            }

            if (func.Disassembly.Length == 0)
            {
                func.Disassembly = new[]
                {
                    new Instruction
                    {
                        Address = func.Address,
                        Mnemonic = "nop",
                    },
                };
            }
            else if (func.Size == 0)
            {
                func.Size = func.Disassembly
                    .Sum(x => x.ByteString != null ? x.ByteString.Length / 2 : 0);
            }

            return func;
        }

        public static NativeFunction[] Deserialize(Stream stream)
        {
            var reader = new BinaryReader(stream);
            var table = StringTable.Deserialize(reader);
            reader.BaseStream.Position = 0x4;
            var funcCount = reader.ReadInt32();

            var funcs = Enumerable
                .Range(0, funcCount)
                .Select(x => Deserialize(table, reader))
                .ToArray();

            return funcs;
        }

        public static NativeFunction[] Deserialize(string filename)
        {
            using (var s = File.OpenRead(filename))
            {
                return Deserialize(s);
            }
        }
    }
}
