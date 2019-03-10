using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Cypress.IA32
{
    public class DecodedModRMByte
    {
        public Mod Mod { get; set; }

        public Register32 Reg { get; set; }

        public byte Rm { get; set; }

        public Register32 RmReg { get; set; }

        public static DecodedModRMByte Decode(byte modRMByte)
        {
            var rm = modRMByte & 7;

            return new DecodedModRMByte
            {
                Mod = (Mod)(modRMByte >> 6),
                Reg = (Register32)((modRMByte >> 3) & 7),
                Rm = (byte)rm,
                RmReg = (Register32)rm
            };
        }
    }
}
