using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Cypress
{
    [Serializable]
    public class Instruction
    {
        public uint Address { get; set; }

        public string Mnemonic { get; set; }

        public string ByteString { get; set; }

        public NativeFunction Function { get; set; }

        public void Serialize(StringTable table, BinaryWriter writer)
        {
            writer.Write(Address);
            writer.Write(table.GetKey(Mnemonic));
            writer.Write(table.GetKey(ByteString));
        }

        public static Instruction Deserialize(StringTable table, BinaryReader reader)
        {
            return new Instruction
            {
                Address = reader.ReadUInt32(),
                Mnemonic = table[reader.ReadInt32()],
                ByteString = table[reader.ReadInt32()]
            };
        }
    }
}
