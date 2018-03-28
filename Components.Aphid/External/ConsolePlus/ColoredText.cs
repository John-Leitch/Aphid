using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.External.ConsolePlus
{
    public struct ColoredText
    {
        public ConsoleColor Color;
        public string Text;

        public ColoredText(ConsoleColor color, string text)
        {
            Color = color;
            Text = text;
        }
    }
}
