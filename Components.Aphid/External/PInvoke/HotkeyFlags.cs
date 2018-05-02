using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.PInvoke
{
    [Flags]
    public enum HotkeyFlags
    {
        None = 0x0000,
        MOD_ALT = 0x0001,
        MOD_CONTROL = 0x0002,
        MOD_SHIFT = 0x0004,
        MOD_WIN = 0x0008,
        MOD_KEYUP = 0x1000,
    }
}
