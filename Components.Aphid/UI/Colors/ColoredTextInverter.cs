using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Components.External.ConsolePlus;

namespace Components.Aphid.UI.Colors
{
    public static class ColoredTextInverter
    {
        public static ColoredText Apply(ColoredText x)
        {
            if (x.BackgroundRgb == null)
            {
                x.BackgroundRgb = x.ForegroundRgb;
                x.ForegroundRgb = SystemColor.Black;
            }
            else if (x.ForegroundRgb == null)
            {
                x.ForegroundRgb = x.BackgroundRgb;
                x.BackgroundRgb = SystemColor.White;
            }
            else
            {
                var bg = x.BackgroundRgb;
                x.BackgroundRgb = x.ForegroundRgb;
                x.ForegroundRgb = bg;
            }

            return x;
        }
    }
}
