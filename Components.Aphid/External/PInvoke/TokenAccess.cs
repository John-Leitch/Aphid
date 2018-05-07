using System;

namespace Components.PInvoke
{
    [Flags]
    public enum TokenAccess : uint
    {
        STANDARD_RIGHTS_REQUIRED = 0x000F0000,
        STANDARD_RIGHTS_READ = 0x00020000,
        TOKEN_ASSIGN_PRIMARY = 0x0001,
        TOKEN_DUPLICATE = 0x0002,
        TOKEN_IMPERSONATE = 0x0004,
        TOKEN_QUERY = 0x0008,
        TOKEN_QUERY_SOURCE = 0x0010,
        TOKEN_ADJUST_PRIVILEGES = 0x0020,
        TOKEN_ADJUST_GROUPS = 0x0040,
        TOKEN_ADJUST_DEFAULT = 0x0080,
        TOKEN_ADJUST_SESSIONID = 0x0100,
        TOKEN_READ = TokenAccess.STANDARD_RIGHTS_READ | TokenAccess.TOKEN_QUERY,

        TOKEN_ALL_ACCESS =
            TokenAccess.STANDARD_RIGHTS_REQUIRED |
            TokenAccess.TOKEN_ASSIGN_PRIMARY |
            TokenAccess.TOKEN_DUPLICATE |
            TokenAccess.TOKEN_IMPERSONATE |
            TokenAccess.TOKEN_QUERY |
            TokenAccess.TOKEN_QUERY_SOURCE |
            TokenAccess.TOKEN_ADJUST_PRIVILEGES |
            TokenAccess.TOKEN_ADJUST_GROUPS |
            TokenAccess.TOKEN_ADJUST_DEFAULT |
            TokenAccess.TOKEN_ADJUST_SESSIONID
    }
}
