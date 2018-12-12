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

        public static int GetLastError() => Marshal.GetLastWin32Error();

        public static Win32Exception CreateWin32Exception() => new Win32Exception(GetLastError());

        public static void ThrowWin32Exception() => throw CreateWin32Exception();

        public static void ThrowLastError() => ThrowWin32Exception();

        public static void ThrowLastErrorIf(bool condition)
        {
            if (condition)
            {
                ThrowLastError();
            }
        }

        public static bool IsHandleValid(IntPtr handle) =>
            handle != INVALID_HANDLE_VALUE && handle != IntPtr.Zero;
    }
}
