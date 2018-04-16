using Components.PInvoke;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Components.Cypress
{
    public static class MemoryDump
    {
        public static void Create(string filename)
        {
            Create(Process.GetCurrentProcess(), filename);
        }

        public static void Create(int processId, string filename)
        {
            Create(Process.GetProcessById(processId), filename);
        }

        public static void Create(Process process, string filename)
        {
            using (var s = File.Create(filename))
            {
                var ptrs = System.Runtime.InteropServices.Marshal.GetExceptionPointers();

                bool result;

                if (ptrs == IntPtr.Zero)
                {
                    result = DbgHelp.MiniDumpWriteDump(
                        process.Handle,
                        (uint)process.Id,
                        s.SafeFileHandle.DangerousGetHandle(),
                        MiniDumpType.MiniDumpWithFullMemory,
                        IntPtr.Zero,
                        IntPtr.Zero,
                        IntPtr.Zero);
                }
                else
                {
                    MINIDUMP_EXCEPTION_INFORMATION mei;
                    mei.ClientPointers = false;
                    mei.ExceptionPointers = ptrs;
                    mei.ThreadId = Kernel32.GetCurrentThreadId();

                    result = DbgHelp.MiniDumpWriteDump(
                        process.Handle,
                        (uint)process.Id,
                        s.SafeFileHandle.DangerousGetHandle(),
                        MiniDumpType.MiniDumpWithFullMemory,
                        ref mei,
                        IntPtr.Zero,
                        IntPtr.Zero);
                }

                if (!result)
                {
                    throw new InvalidOperationException(
                        string.Format("Failed creating memory dump '{0}'.", filename),
                        new Win32Exception(Marshal.GetLastWin32Error()));
                }
            }
        }
    }
}
