using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Cypress.IA32
{
    public class DecodedOpcode
    {
        public Opcode Opcode { get; set; }

        public byte OriginalByte { get; set; }

        public byte DecodedByte { get; set; }

        public OpcodeDirection Direction { get; set; }

        public OpcodeSize Size { get; set; }

        public static DecodedOpcode Decode(byte opcode)
        {
            return new DecodedOpcode
            {
                Opcode = (Opcode)opcode,
                OriginalByte = opcode,
                DecodedByte = (byte)(opcode & ~3),
                Direction = (OpcodeDirection)((opcode >> 1) & 1),
                Size = (OpcodeSize)(opcode & 1)
            };
        }

        public override string ToString()
        {
            return Opcode.ToString();
        }
    }
}
