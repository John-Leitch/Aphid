using Components.Aphid.Lexer;
using Components.Aphid.UI.Colors;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static Components.Aphid.Lexer.AphidTokenType;

namespace Components.Aphid.UI
{
    public class AphidSyntaxHighlighter : ISyntaxHighlighter
    {
        private IAphidColorTheme _theme = new DefaultAphidColorTheme();

        public IEnumerable<ColoredText> Highlight(string text)
        {
            var isFirst = true;
            byte[] bg = null, fg = null;
            var sb = new StringBuilder();

            foreach (var t in HighlightCore(text))
            {
                if (isFirst)
                {
                    sb.Append(t.Text);
                    fg = t.ForegroundRgb;
                    bg = t.BackgroundRgb;
                    isFirst = false;
                }
                else
                {
                    if ((fg == null && t.ForegroundRgb != null) ||
                        (bg == null && t.BackgroundRgb != null) ||
                        (fg != null &&
                            (fg[0] != t.ForegroundRgb[0] ||
                            fg[1] != t.ForegroundRgb[1] ||
                            fg[2] != t.ForegroundRgb[2])) ||
                        (bg != null &&
                            (bg[0] != t.BackgroundRgb[0] ||
                            bg[1] != t.BackgroundRgb[1] ||
                            bg[2] != t.BackgroundRgb[2])))
                    {
                        var ct = new ColoredText(fg, bg, sb.ToString());
                        sb.Clear();
                        sb.Append(t.Text);
                        fg = t.ForegroundRgb;
                        bg = t.BackgroundRgb;

                        yield return ct;
                    }
                    else
                    {
                        sb.Append(t.Text);
                    }
                }
            }

            if (!isFirst)
            {
                yield return new ColoredText(fg, bg, sb.ToString());
            }
        }

        private IEnumerable<ColoredText> HighlightCore(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return Array.Empty<ColoredText>();
            }

            var allTokens = AphidLexer.GetAllTokens(text);
            var tokens = AphidLexer.GetTokens(text);

            if (tokens.Count == 0)
            {
                return allTokens.Select(x => _theme.GetColoredText(x));
            }

            var peekTable = Enumerable
                .Range(0, tokens.Count - 1)
                .ToDictionary(x => tokens[x].Index, x => tokens[x + 1].TokenType);

            void addNone(in AphidToken t) => peekTable.Add(t.Index, None);
            addNone(tokens[tokens.Count - 1]);            
            allTokens.Except(tokens).For(x => addNone(in x));

            return allTokens.Select(x => _theme.GetColoredText(x, peekTable[x.Index]));
        }



        // Todo:
        // * Move colors into configuration file
        // * Allow for custom token groups, individual coloring,
        //   custom rbg, and themes.
        // * Generate from Mantipsid.
        // * Configuration builder/editor, possibly using WPF.
        //   - Use VT100 dump funcs or similar to build color picker.
        //   - Support custom named colors.
        //   - Live preview of colors.
        // * Unify with VS and VSC syntax highlighters
        
    }
}
