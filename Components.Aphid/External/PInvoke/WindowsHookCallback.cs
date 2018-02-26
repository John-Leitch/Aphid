using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.PInvoke
{
    public delegate IntPtr WindowsHookCallback(int code, IntPtr wParam, ref KeyboardHook lParam);
}
