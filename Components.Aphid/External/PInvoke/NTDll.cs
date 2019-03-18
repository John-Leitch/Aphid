using System;
using System.Runtime.InteropServices;

namespace Components.PInvoke
{
    public static class NTDll
    {
        [DllImport("ntdll.dll", SetLastError = true)]
        public static extern int NtQueryInformationProcess(IntPtr processHandle,
           int processInformationClass, ref PROCESS_BASIC_INFORMATION processInformation, uint processInformationLength,
           IntPtr returnLength);
    }
}
