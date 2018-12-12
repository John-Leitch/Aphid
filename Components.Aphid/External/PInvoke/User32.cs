using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Components.PInvoke
{
    public static class User32
    {
        public const int
            WM_KEYDOWN = 0x100,
            WM_KEYUP = 0x101,
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,
            BM_CLICK = 0x00F5,
            KEYEVENTF_EXTENDEDKEY = 1,
            KEYEVENTF_KEYUP = 2,
            LLKHF_INJECTED = 0x00000010;

        public static readonly IntPtr
            HWND_TOPMOST = new IntPtr(-1),
            HWND_NOTOPMOST = new IntPtr(-2),
            HWND_TOP = new IntPtr(0),
            HWND_BOTTOM = new IntPtr(1);

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool AttachThreadInput(uint idAttach, uint idAttachTo, bool fAttach);

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern bool GetKeyboardState(byte[] lpKeyState);

        [DllImport("user32.dll")]
        public static extern uint MapVirtualKey(uint uCode, MapType uMapType);

        [DllImport("user32.dll")]
        public static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        [DllImport("user32.dll")]
        public static extern void mouse_event(MouseEventFlags dwFlags, int dx, int dy, uint dwData, UIntPtr dwExtraInfo);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCursorPos(out POINT lpPoint);

        [DllImport("user32.dll")]
        public static extern int ToUnicode(
            uint wVirtKey,
            uint wScanCode,
            byte[] lpKeyState,
            [Out, MarshalAs(UnmanagedType.LPWStr, SizeParamIndex = 4)]
            StringBuilder pwszBuff,
            int cchBuff,
            uint wFlags);

        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetWindowsHookEx(HookType hookType, WindowsHookCallback lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll")]
        public static extern IntPtr SetWindowsHookEx(HookType code, WindowsHookCallback func, IntPtr hInstance, int threadID);

        [DllImport("user32.dll")]
        public static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, ref KeyboardHook lParam);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetActiveWindow(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool BringWindowToTop(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern bool BringWindowToTop(HandleRef hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, SetWindowPosFlags uFlags);

        [DllImport("user32.dll")]
        public static extern IntPtr SetFocus(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindowEx(IntPtr hWndParent, IntPtr hWndChildAfter, string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll")]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);

        [DllImport("user32.dll")]
        public static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);

        [DllImport("user32.dll")]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        public static WindowStyle GetWindowLong(IntPtr hWnd, GWL nIndex) =>
            (WindowStyle)(IntPtr.Size == 8 ?
                GetWindowArchSpecific.GetWindowLongPtr64(hWnd, nIndex) :
                GetWindowArchSpecific.GetWindowLongPtr32(hWnd, nIndex));

        public static WindowStyle SetWindowLong(IntPtr hWnd, GWL nIndex, WindowStyle dwNewLong) =>
            (WindowStyle)(IntPtr.Size == 8 ?
                GetWindowArchSpecific.SetWindowLongPtr64(hWnd, nIndex, new IntPtr((uint)dwNewLong)) :
                new IntPtr(GetWindowArchSpecific.SetWindowLong32(hWnd, nIndex, (uint)dwNewLong)));

        private static class GetWindowArchSpecific
        {
            [DllImport("user32.dll", EntryPoint = "GetWindowLong")]
            internal static extern IntPtr GetWindowLongPtr32(IntPtr hWnd, GWL nIndex);

            [DllImport("user32.dll", EntryPoint = "GetWindowLongPtr")]
            internal static extern IntPtr GetWindowLongPtr64(IntPtr hWnd, GWL nIndex);

            [DllImport("user32.dll", EntryPoint = "SetWindowLong")]
            internal static extern int SetWindowLong32(IntPtr hWnd, GWL nIndex, uint dwNewLong);

            [DllImport("user32.dll", EntryPoint = "SetWindowLongPtr")]
            internal static extern IntPtr SetWindowLongPtr64(IntPtr hWnd, GWL nIndex, IntPtr dwNewLong);
        }
    }
}
