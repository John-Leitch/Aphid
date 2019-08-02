using System;
using System.Linq;
using System.Text;
using Components.Aphid.Parser;
using Components.Aphid.UI.Colors;
using Components.External;
using Components.External.ConsolePlus;
using static Components.Aphid.UI.Formatters.SyntaxHighlightingFormatter;

namespace Components.Aphid.UI.Formatters
{
    public static class SourcePositionFormatter
    {
        public static string Format(AphidExpression frameExp)
        {
            var frameExpFile = frameExp?.Filename;

            if (frameExpFile == null)
            {
                return null;
            }

            var basePath = PathHelper.GetEntryDirectory();

            if (frameExpFile.StartsWith(basePath, StringComparison.OrdinalIgnoreCase))
            {
                frameExpFile = frameExpFile.Substring(basePath.Length);
            }

            var pos = new[]
            {
                string.Format(" [in {0}", frameExpFile),
                string.Format(
                    "{0}]",
                    ParserErrorMessage
                        .AppendPosition(
                            new StringBuilder(),
                            frameExp.Code,
                            frameExp.Index,
                            false)
                        .ToString())
            };

            return pos
                .SelectMany(Highlight)
                .Select(ColoredTextSaturator.Apply)
                .ToVT100String()
                + VT100.Reset;
        }
    }
}
