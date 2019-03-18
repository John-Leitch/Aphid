using System;
using System.Runtime.InteropServices;

namespace Components.PInvoke
{
    public static class Shell32
    {
        public const uint
            SHGFI_ICON = 0x100,
            SHGFI_LARGEICON = 0x0,
            SHGFI_SMALLICON = 0x1;

        [DllImport("shell32.dll")]
        public static extern IntPtr SHGetFileInfo(
            string pszPath,
            uint dwFileAttributes,
            ref SHFILEINFO psfi,
            uint cbSizeFileInfo,
            uint uFlags);

        [DllImport("shell32.dll")]
        public static extern int ShellAbout(
            IntPtr hWnd,
            string szApp,
            string szOtherStuff,
            IntPtr hIcon);
    }
}
