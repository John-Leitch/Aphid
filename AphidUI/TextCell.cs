using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AphidUI
{
    public readonly struct TextCell
    {
        public readonly int Index;

        public readonly TextCellType Type;

        public readonly char Char;

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

        public override bool Equals(object obj)
        {
            if (!(obj is TextCell))
            {
                return false;
            }

            var cell = (TextCell)obj;
            return Index == cell.Index &&
                   Type == cell.Type &&
                   Char == cell.Char;
        }

        public override int GetHashCode()
        {
            var hashCode = -1679561427;
            hashCode = hashCode * -1521134295 + Index.GetHashCode();
            hashCode = hashCode * -1521134295 + Type.GetHashCode();
            hashCode = hashCode * -1521134295 + Char.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(in TextCell cell1, in TextCell cell2) => cell1.Equals(cell2);

        public static bool operator !=(in TextCell cell1, in TextCell cell2) => !(cell1 == cell2);
    }
}
