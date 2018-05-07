using System;
using System.Runtime.InteropServices;

namespace Components.PInvoke
{
    public static class UserEnv
    {
        [DllImport("userenv.dll", SetLastError = true)]
        public static extern bool CreateEnvironmentBlock(
            out IntPtr lpEnvironment,
            IntPtr hToken,
            bool bInherit);
    }
}
