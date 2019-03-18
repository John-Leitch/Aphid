using System;

namespace Components.PInvoke
{
    [Flags]
    public enum ThreadAccess : uint
    {
        DELETE = 0x00010000,
        READ_CONTROL = 0x00020000,
        WRITE_DAC = 0x00040000,
        WRITE_OWNER = 0x00080000,
        SYNCHRONIZE = 0x00100000,
        THREAD_DIRECT_IMPERSONATION = 0x0200,
        THREAD_GET_CONTEXT = 0x0008,
        THREAD_IMPERSONATE = 0x0100,
        THREAD_QUERY_INFORMATION = 0x0040,
        THREAD_QUERY_LIMITED_INFORMATION = 0x0800,
        THREAD_SET_CONTEXT = 0x0010,
        THREAD_SET_INFORMATION = 0x0020,
        THREAD_SET_LIMITED_INFORMATION = 0x0400,
        THREAD_SET_THREAD_TOKEN = 0x0080,
        THREAD_SUSPEND_RESUME = 0x0002,
        THREAD_TERMINATE = 0x0001,
    }    
}
