using Components.External.ConsolePlus;
using B = System.Byte;

namespace Components.Aphid.UI.Colors
{
    public class DefaultAphidColorTheme : AphidSyntaxColorTheme
    {
        public override B[] Foreground => SystemColor.White;

        public override B[] Background => SystemColor.Black;

        public override B[] StringLiteral => SystemColor.Coral;

        public override B[] Number => SystemColor.PaleGoldenrod;

        public override B[] Keyword => SystemColor.DodgerBlue;

        public override B[] Identifier => SystemColor.CadetBlue;

        public override B[] Operator => SystemColor.Silver;

        public override B[] Bracket => SystemColor.LightGray;

        public override B[] Comment => SystemColor.DarkGreen;
    }
}
