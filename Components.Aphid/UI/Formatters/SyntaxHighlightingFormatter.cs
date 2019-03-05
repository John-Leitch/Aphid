using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Components.Aphid.UI.Colors;
using Components.External.ConsolePlus;
using static Components.External.ConsolePlus.Cli;
using static Components.Aphid.UI.Formatters.CodeMarker;
using Inverter = Components.Aphid.UI.Colors.ColoredTextInverter;

namespace Components.Aphid.UI.Formatters
{
    public static class SyntaxHighlightingFormatter
    {
        private static readonly AphidSyntaxHighlighter _highlighter = new AphidSyntaxHighlighter();

        public static IEnumerable<ColoredText> Highlight(string text) =>
            _highlighter.Highlight(text);

        public static string Format(string code) => Format(code, escapeStyles: true);

        public static string Format(string code, bool escapeStyles)
        {
            if (code.Trim().Length == 0)
            {
                return code;
            }

            var escaped = escapeStyles ? StyleEscape(code) : code;

            //if(code.Contains("tryAction"))
            //{
            //    Debugger.Break();
            //}

            var ct = _highlighter.Highlight(escaped).ToArray();

            //var color = SystemColor.AntiqueWhite;

            int start = Array.FindIndex(ct, x => x.Text == Start.Trim()),
                end = -1;

            if (start != -1)
            {
                end = Array.FindIndex(ct, start, x => x.Text == End.Trim());
            }

            foreach (var i in new[] { start, end })
            {
                if (i == -1)
                {
                    continue;
                }

                if (i - 1 >= 0)
                {
                    var t = ct[i - 1].Text;

                    if (t.Length > 0 && t[t.Length - 1] == ' ')
                    {
                        ct[i - 1].Text = t.Remove(t.Length - 1);
                    }
                }

                if (i >= 0 && i < ct.Length)
                {
                    ct[i].Text = "";
                }

                if (i + 1 < ct.Length)
                {
                    var t = ct[i + 1].Text;

                    if (t.Length > 0 && t[0] == ' ')
                    {
                        ct[i + 1].Text = t.Substring(1);
                    }
                }
            }

            if (start != -1 && end != -1)
            {
                for (var i = start + 1; i < end; i++)
                {
                    ct[i] = Inverter.Apply(ct[i]);
                }
            }
            else if (start != -1)
            {
                start += 2;

                if (ct.Length != start)
                {
                    ct[start] = Inverter.Apply(ct[start]);
                }
            }
            else if (end != -1)
            {
                if (--end >= 0)
                {
                    ct[end] = Inverter.Apply(ct[end]);
                }
            }

            return ct.ToVT100String();
        }
    }
}
