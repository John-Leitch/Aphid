using System.Collections.Generic;

namespace Components.External.ConsolePlus
{
    public interface ISyntaxHighlighter
    {
        IEnumerable<ColoredText> Highlight(string text);
    }
}
