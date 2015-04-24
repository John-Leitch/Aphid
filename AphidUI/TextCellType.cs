using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AphidUI
{
    public enum TextCellType : byte
    {
        Text,
        Operator,
        Keyword,
        Literal,
        Identifier,
        Delimiter,
        Comment,
        Unknown,
    }
}
