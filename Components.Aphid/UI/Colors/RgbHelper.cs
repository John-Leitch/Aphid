using B = System.Byte;

namespace Components.Aphid.UI.Colors
{
    public static class RgbHelper
    {
        public static B[] Invert(this B[] rgb) => new [] { (B)~rgb[0], (B)~rgb[1], (B)~rgb[2] };
    }
}
