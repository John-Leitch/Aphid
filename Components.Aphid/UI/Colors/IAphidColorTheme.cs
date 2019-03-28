using Components.Aphid.Lexer;
using Components.External.ConsolePlus;

namespace Components.Aphid.UI.Colors
{
    public interface IAphidColorTheme
    {
        byte[] GetColor(AphidTokenType type);
        byte[] GetColor(AphidTokenType type, AphidTokenType nextType);
        ColoredText GetColoredText(in AphidToken token);
        ColoredText GetColoredText(in AphidToken token, AphidTokenType nextType);
        byte[] GetBackground();
    }
}