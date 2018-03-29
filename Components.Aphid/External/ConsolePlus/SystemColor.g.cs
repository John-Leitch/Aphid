using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Components.External.ConsolePlus
{
    public static partial class SystemColor
    {
        
        public static readonly byte[] ActiveBorder = new byte[]
        {
            (byte)180, (byte)180, (byte)180
        };
        
        public static readonly byte[] ActiveCaption = new byte[]
        {
            (byte)153, (byte)180, (byte)209
        };
        
        public static readonly byte[] ActiveCaptionText = new byte[]
        {
            (byte)0, (byte)0, (byte)0
        };
        
        public static readonly byte[] AppWorkspace = new byte[]
        {
            (byte)171, (byte)171, (byte)171
        };
        
        public static readonly byte[] Control = new byte[]
        {
            (byte)240, (byte)240, (byte)240
        };
        
        public static readonly byte[] ControlDark = new byte[]
        {
            (byte)160, (byte)160, (byte)160
        };
        
        public static readonly byte[] ControlDarkDark = new byte[]
        {
            (byte)105, (byte)105, (byte)105
        };
        
        public static readonly byte[] ControlLight = new byte[]
        {
            (byte)227, (byte)227, (byte)227
        };
        
        public static readonly byte[] ControlLightLight = new byte[]
        {
            (byte)255, (byte)255, (byte)255
        };
        
        public static readonly byte[] ControlText = new byte[]
        {
            (byte)0, (byte)0, (byte)0
        };
        
        public static readonly byte[] Desktop = new byte[]
        {
            (byte)0, (byte)0, (byte)0
        };
        
        public static readonly byte[] GrayText = new byte[]
        {
            (byte)109, (byte)109, (byte)109
        };
        
        public static readonly byte[] Highlight = new byte[]
        {
            (byte)0, (byte)120, (byte)215
        };
        
        public static readonly byte[] HighlightText = new byte[]
        {
            (byte)255, (byte)255, (byte)255
        };
        
        public static readonly byte[] HotTrack = new byte[]
        {
            (byte)0, (byte)102, (byte)204
        };
        
        public static readonly byte[] InactiveBorder = new byte[]
        {
            (byte)244, (byte)247, (byte)252
        };
        
        public static readonly byte[] InactiveCaption = new byte[]
        {
            (byte)191, (byte)205, (byte)219
        };
        
        public static readonly byte[] InactiveCaptionText = new byte[]
        {
            (byte)0, (byte)0, (byte)0
        };
        
        public static readonly byte[] Info = new byte[]
        {
            (byte)255, (byte)255, (byte)225
        };
        
        public static readonly byte[] InfoText = new byte[]
        {
            (byte)0, (byte)0, (byte)0
        };
        
        public static readonly byte[] Menu = new byte[]
        {
            (byte)240, (byte)240, (byte)240
        };
        
        public static readonly byte[] MenuText = new byte[]
        {
            (byte)0, (byte)0, (byte)0
        };
        
        public static readonly byte[] ScrollBar = new byte[]
        {
            (byte)200, (byte)200, (byte)200
        };
        
        public static readonly byte[] Window = new byte[]
        {
            (byte)255, (byte)255, (byte)255
        };
        
        public static readonly byte[] WindowFrame = new byte[]
        {
            (byte)100, (byte)100, (byte)100
        };
        
        public static readonly byte[] WindowText = new byte[]
        {
            (byte)0, (byte)0, (byte)0
        };
        
        public static readonly byte[] Transparent = new byte[]
        {
            (byte)255, (byte)255, (byte)255
        };
        
        public static readonly byte[] AliceBlue = new byte[]
        {
            (byte)240, (byte)248, (byte)255
        };
        
        public static readonly byte[] AntiqueWhite = new byte[]
        {
            (byte)250, (byte)235, (byte)215
        };
        
        public static readonly byte[] Aqua = new byte[]
        {
            (byte)0, (byte)255, (byte)255
        };
        
        public static readonly byte[] Aquamarine = new byte[]
        {
            (byte)127, (byte)255, (byte)212
        };
        
        public static readonly byte[] Azure = new byte[]
        {
            (byte)240, (byte)255, (byte)255
        };
        
        public static readonly byte[] Beige = new byte[]
        {
            (byte)245, (byte)245, (byte)220
        };
        
        public static readonly byte[] Bisque = new byte[]
        {
            (byte)255, (byte)228, (byte)196
        };
        
        public static readonly byte[] Black = new byte[]
        {
            (byte)0, (byte)0, (byte)0
        };
        
        public static readonly byte[] BlanchedAlmond = new byte[]
        {
            (byte)255, (byte)235, (byte)205
        };
        
        public static readonly byte[] Blue = new byte[]
        {
            (byte)0, (byte)0, (byte)255
        };
        
        public static readonly byte[] BlueViolet = new byte[]
        {
            (byte)138, (byte)43, (byte)226
        };
        
        public static readonly byte[] Brown = new byte[]
        {
            (byte)165, (byte)42, (byte)42
        };
        
        public static readonly byte[] BurlyWood = new byte[]
        {
            (byte)222, (byte)184, (byte)135
        };
        
        public static readonly byte[] CadetBlue = new byte[]
        {
            (byte)95, (byte)158, (byte)160
        };
        
        public static readonly byte[] Chartreuse = new byte[]
        {
            (byte)127, (byte)255, (byte)0
        };
        
        public static readonly byte[] Chocolate = new byte[]
        {
            (byte)210, (byte)105, (byte)30
        };
        
        public static readonly byte[] Coral = new byte[]
        {
            (byte)255, (byte)127, (byte)80
        };
        
        public static readonly byte[] CornflowerBlue = new byte[]
        {
            (byte)100, (byte)149, (byte)237
        };
        
        public static readonly byte[] Cornsilk = new byte[]
        {
            (byte)255, (byte)248, (byte)220
        };
        
        public static readonly byte[] Crimson = new byte[]
        {
            (byte)220, (byte)20, (byte)60
        };
        
        public static readonly byte[] Cyan = new byte[]
        {
            (byte)0, (byte)255, (byte)255
        };
        
        public static readonly byte[] DarkBlue = new byte[]
        {
            (byte)0, (byte)0, (byte)139
        };
        
        public static readonly byte[] DarkCyan = new byte[]
        {
            (byte)0, (byte)139, (byte)139
        };
        
        public static readonly byte[] DarkGoldenrod = new byte[]
        {
            (byte)184, (byte)134, (byte)11
        };
        
        public static readonly byte[] DarkGray = new byte[]
        {
            (byte)169, (byte)169, (byte)169
        };
        
        public static readonly byte[] DarkGreen = new byte[]
        {
            (byte)0, (byte)100, (byte)0
        };
        
        public static readonly byte[] DarkKhaki = new byte[]
        {
            (byte)189, (byte)183, (byte)107
        };
        
        public static readonly byte[] DarkMagenta = new byte[]
        {
            (byte)139, (byte)0, (byte)139
        };
        
        public static readonly byte[] DarkOliveGreen = new byte[]
        {
            (byte)85, (byte)107, (byte)47
        };
        
        public static readonly byte[] DarkOrange = new byte[]
        {
            (byte)255, (byte)140, (byte)0
        };
        
        public static readonly byte[] DarkOrchid = new byte[]
        {
            (byte)153, (byte)50, (byte)204
        };
        
        public static readonly byte[] DarkRed = new byte[]
        {
            (byte)139, (byte)0, (byte)0
        };
        
        public static readonly byte[] DarkSalmon = new byte[]
        {
            (byte)233, (byte)150, (byte)122
        };
        
        public static readonly byte[] DarkSeaGreen = new byte[]
        {
            (byte)143, (byte)188, (byte)139
        };
        
        public static readonly byte[] DarkSlateBlue = new byte[]
        {
            (byte)72, (byte)61, (byte)139
        };
        
        public static readonly byte[] DarkSlateGray = new byte[]
        {
            (byte)47, (byte)79, (byte)79
        };
        
        public static readonly byte[] DarkTurquoise = new byte[]
        {
            (byte)0, (byte)206, (byte)209
        };
        
        public static readonly byte[] DarkViolet = new byte[]
        {
            (byte)148, (byte)0, (byte)211
        };
        
        public static readonly byte[] DeepPink = new byte[]
        {
            (byte)255, (byte)20, (byte)147
        };
        
        public static readonly byte[] DeepSkyBlue = new byte[]
        {
            (byte)0, (byte)191, (byte)255
        };
        
        public static readonly byte[] DimGray = new byte[]
        {
            (byte)105, (byte)105, (byte)105
        };
        
        public static readonly byte[] DodgerBlue = new byte[]
        {
            (byte)30, (byte)144, (byte)255
        };
        
        public static readonly byte[] Firebrick = new byte[]
        {
            (byte)178, (byte)34, (byte)34
        };
        
        public static readonly byte[] FloralWhite = new byte[]
        {
            (byte)255, (byte)250, (byte)240
        };
        
        public static readonly byte[] ForestGreen = new byte[]
        {
            (byte)34, (byte)139, (byte)34
        };
        
        public static readonly byte[] Fuchsia = new byte[]
        {
            (byte)255, (byte)0, (byte)255
        };
        
        public static readonly byte[] Gainsboro = new byte[]
        {
            (byte)220, (byte)220, (byte)220
        };
        
        public static readonly byte[] GhostWhite = new byte[]
        {
            (byte)248, (byte)248, (byte)255
        };
        
        public static readonly byte[] Gold = new byte[]
        {
            (byte)255, (byte)215, (byte)0
        };
        
        public static readonly byte[] Goldenrod = new byte[]
        {
            (byte)218, (byte)165, (byte)32
        };
        
        public static readonly byte[] Gray = new byte[]
        {
            (byte)128, (byte)128, (byte)128
        };
        
        public static readonly byte[] Green = new byte[]
        {
            (byte)0, (byte)128, (byte)0
        };
        
        public static readonly byte[] GreenYellow = new byte[]
        {
            (byte)173, (byte)255, (byte)47
        };
        
        public static readonly byte[] Honeydew = new byte[]
        {
            (byte)240, (byte)255, (byte)240
        };
        
        public static readonly byte[] HotPink = new byte[]
        {
            (byte)255, (byte)105, (byte)180
        };
        
        public static readonly byte[] IndianRed = new byte[]
        {
            (byte)205, (byte)92, (byte)92
        };
        
        public static readonly byte[] Indigo = new byte[]
        {
            (byte)75, (byte)0, (byte)130
        };
        
        public static readonly byte[] Ivory = new byte[]
        {
            (byte)255, (byte)255, (byte)240
        };
        
        public static readonly byte[] Khaki = new byte[]
        {
            (byte)240, (byte)230, (byte)140
        };
        
        public static readonly byte[] Lavender = new byte[]
        {
            (byte)230, (byte)230, (byte)250
        };
        
        public static readonly byte[] LavenderBlush = new byte[]
        {
            (byte)255, (byte)240, (byte)245
        };
        
        public static readonly byte[] LawnGreen = new byte[]
        {
            (byte)124, (byte)252, (byte)0
        };
        
        public static readonly byte[] LemonChiffon = new byte[]
        {
            (byte)255, (byte)250, (byte)205
        };
        
        public static readonly byte[] LightBlue = new byte[]
        {
            (byte)173, (byte)216, (byte)230
        };
        
        public static readonly byte[] LightCoral = new byte[]
        {
            (byte)240, (byte)128, (byte)128
        };
        
        public static readonly byte[] LightCyan = new byte[]
        {
            (byte)224, (byte)255, (byte)255
        };
        
        public static readonly byte[] LightGoldenrodYellow = new byte[]
        {
            (byte)250, (byte)250, (byte)210
        };
        
        public static readonly byte[] LightGray = new byte[]
        {
            (byte)211, (byte)211, (byte)211
        };
        
        public static readonly byte[] LightGreen = new byte[]
        {
            (byte)144, (byte)238, (byte)144
        };
        
        public static readonly byte[] LightPink = new byte[]
        {
            (byte)255, (byte)182, (byte)193
        };
        
        public static readonly byte[] LightSalmon = new byte[]
        {
            (byte)255, (byte)160, (byte)122
        };
        
        public static readonly byte[] LightSeaGreen = new byte[]
        {
            (byte)32, (byte)178, (byte)170
        };
        
        public static readonly byte[] LightSkyBlue = new byte[]
        {
            (byte)135, (byte)206, (byte)250
        };
        
        public static readonly byte[] LightSlateGray = new byte[]
        {
            (byte)119, (byte)136, (byte)153
        };
        
        public static readonly byte[] LightSteelBlue = new byte[]
        {
            (byte)176, (byte)196, (byte)222
        };
        
        public static readonly byte[] LightYellow = new byte[]
        {
            (byte)255, (byte)255, (byte)224
        };
        
        public static readonly byte[] Lime = new byte[]
        {
            (byte)0, (byte)255, (byte)0
        };
        
        public static readonly byte[] LimeGreen = new byte[]
        {
            (byte)50, (byte)205, (byte)50
        };
        
        public static readonly byte[] Linen = new byte[]
        {
            (byte)250, (byte)240, (byte)230
        };
        
        public static readonly byte[] Magenta = new byte[]
        {
            (byte)255, (byte)0, (byte)255
        };
        
        public static readonly byte[] Maroon = new byte[]
        {
            (byte)128, (byte)0, (byte)0
        };
        
        public static readonly byte[] MediumAquamarine = new byte[]
        {
            (byte)102, (byte)205, (byte)170
        };
        
        public static readonly byte[] MediumBlue = new byte[]
        {
            (byte)0, (byte)0, (byte)205
        };
        
        public static readonly byte[] MediumOrchid = new byte[]
        {
            (byte)186, (byte)85, (byte)211
        };
        
        public static readonly byte[] MediumPurple = new byte[]
        {
            (byte)147, (byte)112, (byte)219
        };
        
        public static readonly byte[] MediumSeaGreen = new byte[]
        {
            (byte)60, (byte)179, (byte)113
        };
        
        public static readonly byte[] MediumSlateBlue = new byte[]
        {
            (byte)123, (byte)104, (byte)238
        };
        
        public static readonly byte[] MediumSpringGreen = new byte[]
        {
            (byte)0, (byte)250, (byte)154
        };
        
        public static readonly byte[] MediumTurquoise = new byte[]
        {
            (byte)72, (byte)209, (byte)204
        };
        
        public static readonly byte[] MediumVioletRed = new byte[]
        {
            (byte)199, (byte)21, (byte)133
        };
        
        public static readonly byte[] MidnightBlue = new byte[]
        {
            (byte)25, (byte)25, (byte)112
        };
        
        public static readonly byte[] MintCream = new byte[]
        {
            (byte)245, (byte)255, (byte)250
        };
        
        public static readonly byte[] MistyRose = new byte[]
        {
            (byte)255, (byte)228, (byte)225
        };
        
        public static readonly byte[] Moccasin = new byte[]
        {
            (byte)255, (byte)228, (byte)181
        };
        
        public static readonly byte[] NavajoWhite = new byte[]
        {
            (byte)255, (byte)222, (byte)173
        };
        
        public static readonly byte[] Navy = new byte[]
        {
            (byte)0, (byte)0, (byte)128
        };
        
        public static readonly byte[] OldLace = new byte[]
        {
            (byte)253, (byte)245, (byte)230
        };
        
        public static readonly byte[] Olive = new byte[]
        {
            (byte)128, (byte)128, (byte)0
        };
        
        public static readonly byte[] OliveDrab = new byte[]
        {
            (byte)107, (byte)142, (byte)35
        };
        
        public static readonly byte[] Orange = new byte[]
        {
            (byte)255, (byte)165, (byte)0
        };
        
        public static readonly byte[] OrangeRed = new byte[]
        {
            (byte)255, (byte)69, (byte)0
        };
        
        public static readonly byte[] Orchid = new byte[]
        {
            (byte)218, (byte)112, (byte)214
        };
        
        public static readonly byte[] PaleGoldenrod = new byte[]
        {
            (byte)238, (byte)232, (byte)170
        };
        
        public static readonly byte[] PaleGreen = new byte[]
        {
            (byte)152, (byte)251, (byte)152
        };
        
        public static readonly byte[] PaleTurquoise = new byte[]
        {
            (byte)175, (byte)238, (byte)238
        };
        
        public static readonly byte[] PaleVioletRed = new byte[]
        {
            (byte)219, (byte)112, (byte)147
        };
        
        public static readonly byte[] PapayaWhip = new byte[]
        {
            (byte)255, (byte)239, (byte)213
        };
        
        public static readonly byte[] PeachPuff = new byte[]
        {
            (byte)255, (byte)218, (byte)185
        };
        
        public static readonly byte[] Peru = new byte[]
        {
            (byte)205, (byte)133, (byte)63
        };
        
        public static readonly byte[] Pink = new byte[]
        {
            (byte)255, (byte)192, (byte)203
        };
        
        public static readonly byte[] Plum = new byte[]
        {
            (byte)221, (byte)160, (byte)221
        };
        
        public static readonly byte[] PowderBlue = new byte[]
        {
            (byte)176, (byte)224, (byte)230
        };
        
        public static readonly byte[] Purple = new byte[]
        {
            (byte)128, (byte)0, (byte)128
        };
        
        public static readonly byte[] Red = new byte[]
        {
            (byte)255, (byte)0, (byte)0
        };
        
        public static readonly byte[] RosyBrown = new byte[]
        {
            (byte)188, (byte)143, (byte)143
        };
        
        public static readonly byte[] RoyalBlue = new byte[]
        {
            (byte)65, (byte)105, (byte)225
        };
        
        public static readonly byte[] SaddleBrown = new byte[]
        {
            (byte)139, (byte)69, (byte)19
        };
        
        public static readonly byte[] Salmon = new byte[]
        {
            (byte)250, (byte)128, (byte)114
        };
        
        public static readonly byte[] SandyBrown = new byte[]
        {
            (byte)244, (byte)164, (byte)96
        };
        
        public static readonly byte[] SeaGreen = new byte[]
        {
            (byte)46, (byte)139, (byte)87
        };
        
        public static readonly byte[] SeaShell = new byte[]
        {
            (byte)255, (byte)245, (byte)238
        };
        
        public static readonly byte[] Sienna = new byte[]
        {
            (byte)160, (byte)82, (byte)45
        };
        
        public static readonly byte[] Silver = new byte[]
        {
            (byte)192, (byte)192, (byte)192
        };
        
        public static readonly byte[] SkyBlue = new byte[]
        {
            (byte)135, (byte)206, (byte)235
        };
        
        public static readonly byte[] SlateBlue = new byte[]
        {
            (byte)106, (byte)90, (byte)205
        };
        
        public static readonly byte[] SlateGray = new byte[]
        {
            (byte)112, (byte)128, (byte)144
        };
        
        public static readonly byte[] Snow = new byte[]
        {
            (byte)255, (byte)250, (byte)250
        };
        
        public static readonly byte[] SpringGreen = new byte[]
        {
            (byte)0, (byte)255, (byte)127
        };
        
        public static readonly byte[] SteelBlue = new byte[]
        {
            (byte)70, (byte)130, (byte)180
        };
        
        public static readonly byte[] Tan = new byte[]
        {
            (byte)210, (byte)180, (byte)140
        };
        
        public static readonly byte[] Teal = new byte[]
        {
            (byte)0, (byte)128, (byte)128
        };
        
        public static readonly byte[] Thistle = new byte[]
        {
            (byte)216, (byte)191, (byte)216
        };
        
        public static readonly byte[] Tomato = new byte[]
        {
            (byte)255, (byte)99, (byte)71
        };
        
        public static readonly byte[] Turquoise = new byte[]
        {
            (byte)64, (byte)224, (byte)208
        };
        
        public static readonly byte[] Violet = new byte[]
        {
            (byte)238, (byte)130, (byte)238
        };
        
        public static readonly byte[] Wheat = new byte[]
        {
            (byte)245, (byte)222, (byte)179
        };
        
        public static readonly byte[] White = new byte[]
        {
            (byte)255, (byte)255, (byte)255
        };
        
        public static readonly byte[] WhiteSmoke = new byte[]
        {
            (byte)245, (byte)245, (byte)245
        };
        
        public static readonly byte[] Yellow = new byte[]
        {
            (byte)255, (byte)255, (byte)0
        };
        
        public static readonly byte[] YellowGreen = new byte[]
        {
            (byte)154, (byte)205, (byte)50
        };
        
        public static readonly byte[] ButtonFace = new byte[]
        {
            (byte)240, (byte)240, (byte)240
        };
        
        public static readonly byte[] ButtonHighlight = new byte[]
        {
            (byte)255, (byte)255, (byte)255
        };
        
        public static readonly byte[] ButtonShadow = new byte[]
        {
            (byte)160, (byte)160, (byte)160
        };
        
        public static readonly byte[] GradientActiveCaption = new byte[]
        {
            (byte)185, (byte)209, (byte)234
        };
        
        public static readonly byte[] GradientInactiveCaption = new byte[]
        {
            (byte)215, (byte)228, (byte)242
        };
        
        public static readonly byte[] MenuBar = new byte[]
        {
            (byte)240, (byte)240, (byte)240
        };
        
        public static readonly byte[] MenuHighlight = new byte[]
        {
            (byte)51, (byte)153, (byte)255
        };
        
    }
}
