using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Cypress
{
    [Serializable]
    public class NativeContext
    {
        public uint Eax { get; set; }

        public uint Ebx { get; set; }

        public uint Ecx { get; set; }

        public uint Edx { get; set; }

        public uint Esi { get; set; }

        public uint Edi { get; set; }

        public uint Eip { get; set; }

        public uint Esp { get; set; }

        public uint Ebp { get; set; }

        public uint Efl { get; set; }
    }
}
