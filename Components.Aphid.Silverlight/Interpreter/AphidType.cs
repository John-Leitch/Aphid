using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.Interpreter
{
    public static class AphidType
    {
        public const string Unknown = "unknown",
            String = "string",
            Number = "number",
            Boolean = "boolean",
            List = "list",
            Object = "object",
            Function = "function",
            Null = "null";
    }
}
