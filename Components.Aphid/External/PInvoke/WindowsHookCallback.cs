using System;

namespace Components.PInvoke
{
    public delegate IntPtr WindowsHookCallback(int code, IntPtr wParam, ref KeyboardHook lParam);
}
