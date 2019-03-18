using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Components.PInvoke
{
    [SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "5#")]
    public static class AdvApi32
    {
        [DllImport("advapi32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool OpenProcessToken(
            IntPtr ProcessHandle,
            TokenAccess DesiredAccess,
            out IntPtr TokenHandle);

        [DllImport("advapi32.dll")]
        public extern static bool DuplicateToken(
            IntPtr ExistingTokenHandle,
            SECURITY_IMPERSONATION_LEVEL ImpersonationLevel,
            out IntPtr DuplicateTokenHandle);

        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public extern static bool DuplicateTokenEx(
            IntPtr hExistingToken,
            TokenAccess dwDesiredAccess,
            ref SECURITY_ATTRIBUTES lpTokenAttributes,
            SECURITY_IMPERSONATION_LEVEL ImpersonationLevel,
            TOKEN_TYPE TokenType,
            out IntPtr phNewToken);

        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public extern static bool DuplicateTokenEx(
            IntPtr hExistingToken,
            TokenAccess dwDesiredAccess,
            IntPtr lpTokenAttributes,
            SECURITY_IMPERSONATION_LEVEL ImpersonationLevel,
            TOKEN_TYPE TokenType,
            out IntPtr phNewToken);

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool CreateProcessWithTokenW(
            IntPtr hToken,
            LogonFlags dwLogonFlags,
            string lpApplicationName,
            string lpCommandLine,
            ProcessCreationFlags dwCreationFlags,
            IntPtr lpEnvironment,
            string lpCurrentDirectory,
            STARTUPINFO lpStartupInfo,
            PROCESS_INFORMATION lpProcessInformation);
    }
}
