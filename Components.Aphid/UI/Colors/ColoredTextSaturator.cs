using Components.External.ConsolePlus;
using System;
using System.Linq;
using static System.Array;

namespace Components.Aphid.UI.Colors
{
    public static class ColoredTextSaturator
    {
        public static ColoredText Apply(ColoredText targetColor)
        {
            var old = targetColor.ForegroundRgb;

            var top = old
                .OrderByDescending(a => a)
                .GroupToArrayDictionary(a => a)
                .First();

            static byte increase(byte a) => Math.Max(a, (byte)(a * 1.4));

            byte[] color;

            if (top.Value.Length == 3)
            {
                color = old.Select(increase).ToArray();
            }
            else if (top.Value.Length == 2)
            {
                var off1 = IndexOf(old, top.Value[0]);
                var off2 = IndexOf(old, top.Value[1], off1 + 1);

                color = targetColor.ForegroundRgb.ToArray();
                color[off1] = increase(color[off1]);
                color[off2] = increase(color[off2]);
            }
            else
            {
                var off = IndexOf(old, top.Value[0]);

                color = targetColor.ForegroundRgb.ToArray();
                color[off] = increase(color[off]);
            }

            return new ColoredText(
                color,
                //targetColor.ForegroundRgb.Select((a => (byte)(a * 1.1)).ToArray(),
                new byte[] { 0x00, 0x20, 0x20 },
                targetColor.Text);
        }
    }
}
