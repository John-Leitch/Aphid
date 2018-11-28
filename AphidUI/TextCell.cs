using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AphidUI
{
    public struct TextCell
    {
        public int Index;

        public TextCellType Type;

        public char Char;

        public TextCell(int index)
        {
            Index = index;
            Type = default;
            Char = default;
        }

        public TextCell(int index, TextCellType type, char cellChar)
        {
            Index = index;
            Type = type;
            Char = cellChar;
        }
    }
}
