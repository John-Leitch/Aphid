using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.PInvoke
{
    public static class AccessViolationFlag
    {
        public const uint Read = 0x0,
            Write = 0x1,
            Dep = 0x8;
    }
}
