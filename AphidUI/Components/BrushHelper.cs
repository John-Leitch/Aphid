using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media;
using static AphidUI.CodeViewer;
using B = System.Windows.Media.SolidColorBrush;
using Rgb = System.ValueTuple<byte, byte, byte>;
using BrushMemoizer = Components.Threading.DefaultThreadLocal<Components.External.Memoizer<System.ValueTuple<byte, byte, byte>, System.Windows.Media.SolidColorBrush>>;
using Components.Threading;

namespace Components.Aphid.Wpf
{
    public static class BrushHelper
    {
        
        private static readonly BrushMemoizer _localMemoizer = new();
        
        public static B FromRgb(byte[] rgb) => rgb != null ? FromRgb((rgb[0], rgb[1], rgb[2])) : null;

        public static B FromRgb(byte r, byte g, byte b) => FromRgb((r, g, b));

        public static B FromRgb(Rgb rgb) => _localMemoizer.Value.Call(FromRgbUnsafe, rgb);

        private static B FromRgbUnsafe(Rgb rgb) => new B(Color.FromRgb(rgb.Item1, rgb.Item2, rgb.Item3));

    }
}
