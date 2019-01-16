using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.PInvoke
{
    [StructLayout(LayoutKind.Sequential)]
    public struct DEBUG_EVENT
    {
        public DebugEventType dwDebugEventCode;
        public uint dwProcessId;
        public uint dwThreadId;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 86, ArraySubType = UnmanagedType.U1)]
#pragma warning disable IDE0044 // Add readonly modifier
        byte[] debugInfo;
#pragma warning restore IDE0044 // Add readonly modifier

        public EXCEPTION_DEBUG_INFO Exception
        {
            get { return GetDebugInfo<EXCEPTION_DEBUG_INFO>(); }
        }

        public CREATE_THREAD_DEBUG_INFO CreateThread
        {
            get { return GetDebugInfo<CREATE_THREAD_DEBUG_INFO>(); }
        }

        public CREATE_PROCESS_DEBUG_INFO CreateProcessInfo
        {
            get { return GetDebugInfo<CREATE_PROCESS_DEBUG_INFO>(); }
        }

        public EXIT_THREAD_DEBUG_INFO ExitThread
        {
            get { return GetDebugInfo<EXIT_THREAD_DEBUG_INFO>(); }
        }

        public EXIT_PROCESS_DEBUG_INFO ExitProcess
        {
            get { return GetDebugInfo<EXIT_PROCESS_DEBUG_INFO>(); }
        }

        public LOAD_DLL_DEBUG_INFO LoadDll
        {
            get { return GetDebugInfo<LOAD_DLL_DEBUG_INFO>(); }
        }

        public UNLOAD_DLL_DEBUG_INFO UnloadDll
        {
            get { return GetDebugInfo<UNLOAD_DLL_DEBUG_INFO>(); }
        }

        public OUTPUT_DEBUG_STRING_INFO DebugString
        {
            get { return GetDebugInfo<OUTPUT_DEBUG_STRING_INFO>(); }
        }

        public RIP_INFO RipInfo
        {
            get { return GetDebugInfo<RIP_INFO>(); }
        }

        private T GetDebugInfo<T>() where T : struct
        {
            var structSize = Marshal.SizeOf(typeof(T));
            var pointer = Marshal.AllocHGlobal(structSize);
            Marshal.Copy(debugInfo, 0, pointer, structSize);

            var result = Marshal.PtrToStructure(pointer, typeof(T));
            Marshal.FreeHGlobal(pointer);
            return (T)result;
        }

        public void ContinueDebugEvent(ContinueStatus status)
        {
            Kernel32.ContinueDebugEvent(dwProcessId, dwThreadId, status);
        }

        public void ContinueHandled()
        {
            ContinueDebugEvent(ContinueStatus.DBG_CONTINUE);
        }

        public void ContinueUnhandled()
        {
            ContinueDebugEvent(ContinueStatus.DBG_EXCEPTION_NOT_HANDLED);
        }
    }
}
