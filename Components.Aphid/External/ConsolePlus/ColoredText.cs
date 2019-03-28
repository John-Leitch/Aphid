using System.Collections.Generic;
using System.Runtime.InteropServices;

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

        public ColoredText Clone() => new ColoredText(
                ForegroundRgb != null ? (byte[])ForegroundRgb.Clone() : null,
                BackgroundRgb != null ? (byte[])BackgroundRgb.Clone() : null,
                Text);

        public override string ToString() =>
            
                string.Format(
                    (ForegroundRgb != null ? 
                        "\"{0}\" Fg: {1:x2}{2:x2}{3:x2}" :
                        "\"{0}\"") +
                        (BackgroundRgb != null ? " Bg: {4:x2}{5:x2}{6:x2}" : ""),
                    Text?.Replace("\r", "\\r").Replace("\n", "\\n").Replace("\"", "\\\""),
                    ForegroundRgb?[0],
                    ForegroundRgb?[1],
                    ForegroundRgb?[2],
                    BackgroundRgb?[0],
                    BackgroundRgb?[1],
                    BackgroundRgb?[2]);


        public override bool Equals(object obj)
        {
            if (!(obj is ColoredText))
            {
                return false;
            }

            var text = (ColoredText)obj;
            return EqualityComparer<byte[]>.Default.Equals(ForegroundRgb, text.ForegroundRgb) &&
                   EqualityComparer<byte[]>.Default.Equals(BackgroundRgb, text.BackgroundRgb) &&
                   Text == text.Text;
        }

        public override int GetHashCode()
        {
            var hashCode = 1709251333;
            hashCode = (hashCode * -1521134295) + EqualityComparer<byte[]>.Default.GetHashCode(ForegroundRgb);
            hashCode = (hashCode * -1521134295) + EqualityComparer<byte[]>.Default.GetHashCode(BackgroundRgb);
            hashCode = (hashCode * -1521134295) + EqualityComparer<string>.Default.GetHashCode(Text);
            return hashCode;
        }

        public static bool operator ==(ColoredText text1, ColoredText text2) => text1.Equals(text2);

        public static bool operator !=(ColoredText text1, ColoredText text2) => !(text1 == text2);
    }
}
