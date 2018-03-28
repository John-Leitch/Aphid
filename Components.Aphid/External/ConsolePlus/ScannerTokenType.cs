using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.External.ConsolePlus
{
    public enum ScannerTokenType : byte
    {
        Identifier,
        MemberOperator,
        Type,
        Value,
        Ignore,
        Other,
    }
}
