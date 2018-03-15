﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Components.Aphid.TypeSystem
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
            InteropFunction = "interopFunction",
            PartialFunction = "partialFunction",
            FunctionComposition = "functionComposition",
            Null = "null";

        public static string GetName(object value)
        {
            Type t;

            return value != null ?
                AphidAlias.Resolve(t = value.GetType()) ?? t.FullName :
                AphidType.Null;
        }
    }
}