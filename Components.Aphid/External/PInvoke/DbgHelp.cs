using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.PInvoke
{
    public static class DbgHelp
    {
        [DllImport("Dbghelp.dll", SetLastError = true)]
        public static extern bool MiniDumpWriteDump(
            IntPtr hProcess,
            uint ProcessId,
            IntPtr hFile,
            MiniDumpType DumpType,
            ref MINIDUMP_EXCEPTION_INFORMATION ExceptionParam,
            IntPtr UserStreamParam,
            IntPtr CallbackParam);

        [DllImport("Dbghelp.dll", SetLastError = true)]
        public static extern bool MiniDumpWriteDump(
            IntPtr hProcess, 
            uint ProcessId,
            IntPtr hFile, 
            MiniDumpType DumpType, 
            IntPtr ExceptionParam,
            IntPtr UserStreamParam, IntPtr CallbackParam);
    }
}
