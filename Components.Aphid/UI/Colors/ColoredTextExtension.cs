using System.Collections.Generic;
using Components.External.ConsolePlus;

namespace Components.Aphid.UI.Colors
{
    public static class ColoredTextExtension
    {
        public static string ToVT100String(this IEnumerable<ColoredText> source) =>
            VT100.GetString(source);
    }
}
