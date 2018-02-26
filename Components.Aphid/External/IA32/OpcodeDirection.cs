using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Cypress.IA32
{
    public enum OpcodeDirection : byte
    {
        RegisterToMemory = 0x0,
        MemoryToRegister = 0x1,
    }
}
