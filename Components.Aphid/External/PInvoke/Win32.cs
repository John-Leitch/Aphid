using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.PInvoke
{
    public static class Win32
    {
        public static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);

        public const int
            STD_INPUT_HANDLE = -10,
            STD_OUTPUT_HANDLE = -11,
            STD_ERROR_HANDLE = -12;
    }
}
