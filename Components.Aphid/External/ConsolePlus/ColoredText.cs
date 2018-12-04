using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Components.External.ConsolePlus
{
    public struct ColoredText
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] ForegroundRgb;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
        public byte[] BackgroundRgb;

        public string Text;

        public ColoredText(byte[] foreground, byte[] background, string text)
        {
            ForegroundRgb = foreground;
            BackgroundRgb = background;
            Text = text;
        }

        public ColoredText(byte[] foreground, string text)
        {
            ForegroundRgb = foreground;
            BackgroundRgb = null;
            Text = text;
        }

        public ColoredText(byte r, byte g, byte b, string text)
        {
            ForegroundRgb = new [] { r, g, b };
            BackgroundRgb = null;
            Text = text;
        }

        public ColoredText Clone()
        {
            return new ColoredText(
                ForegroundRgb != null ? (byte[])ForegroundRgb.Clone() : null,
                BackgroundRgb != null ? (byte[])BackgroundRgb.Clone() : null,
                Text);
        }
    }
}
