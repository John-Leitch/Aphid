using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Components.PInvoke
{
    public static class Win32
    {
        public static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);

        public const int
            STD_INPUT_HANDLE = -10,
            STD_OUTPUT_HANDLE = -11,
            STD_ERROR_HANDLE = -12;

        public static Win32Exception CreateWin32Exception()
        {
            return new Win32Exception(Marshal.GetLastWin32Error());
        }

        public static void ThrowWin32Exception()
        {
            throw CreateWin32Exception();
        }

        public static bool IsHandleValid(IntPtr handle)
        {
            return handle != INVALID_HANDLE_VALUE && handle != IntPtr.Zero;
        }
    }
}
