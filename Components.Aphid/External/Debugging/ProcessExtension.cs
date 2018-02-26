using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Components.PInvoke;

namespace Components.Cypress
{
    public static class ProcessExtension
    {
        public static int GetParentId(this Process process)
        {
            var pbi = new PROCESS_BASIC_INFORMATION();
            var result = NTDll.NtQueryInformationProcess(process.Handle, 0, 
                ref pbi, (uint)Marshal.SizeOf(pbi), IntPtr.Zero);
            return (int)pbi.InheritedFromUniqueProcessId;
        }
    }
}
