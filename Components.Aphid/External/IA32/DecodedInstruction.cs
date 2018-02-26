using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Cypress.IA32
{
    public class DecodedInstruction
    {
        public DecodedOpcode Opcode { get; set; }

        public DecodedModRMByte ModRM { get; set; }

        public SibByte Sib { get; set; }

        public int Displacement { get; set; }

        public int OperandDisplacement { get; set; }

        public int Size { get; set; }

        public override string ToString()
        {
            return Opcode.ToString();
        }
    }
}
