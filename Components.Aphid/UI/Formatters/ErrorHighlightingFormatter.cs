using Components.Aphid.UI.Colors;
using Components.External.ConsolePlus;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

using static Components.Aphid.UI.AphidCli;
using static System.Text.RegularExpressions.RegexOptions;

using RE = System.Text.RegularExpressions.Regex;

namespace Components.Aphid.UI.Formatters
{
    public static class ErrorHighlightingFormatter
    {
        private static RE
            _stackTraceRegex = new RE($@"^(\[.\]\s+)?{StackTraceHead}", Compiled),
            _stackTraceEndRegex = new RE(@"^\[[a-fA-F0-9]{2}\]\s+\[Entrypoint\s+\(Thread", Compiled),
            _varRegex = new RE(@"^\[[a-fA-F0-9]{2,4}\]", Compiled);

        public static IEnumerable<ColoredText> Highlight(string text)
        {
            var state = 0;
            var strs = new List<(bool, string)>();
            var sb = new StringBuilder();

            void push(bool highlight)
            {
                strs.Add((highlight, sb.ToString()));
                sb.Clear();
            }

            void append(string line, bool highlight)
            {
                if (line != null)
                {
                    sb.AppendLine(line);
                }

                push(highlight);
            }

            foreach (var t in text.SplitLines())
            {
                if (state == 0)
                {
                    
                    if (_stackTraceRegex.IsMatch(t))
                    {
                        if (sb.Length != 0)
                        {
                            push(false);
                        }

                        sb.AppendLine(t);
                        state = 1;
                    }
                    else
                    {
                        
                        if (_varRegex.IsMatch(t))
                        {
                            if (sb.Length != 0)
                            {
                                push(false);
                            }

                            append(t, true);
                        }
                        else
                        {
                            sb.AppendLine(t);
                        }
                    }
                }
                else if (state == 1)
                {
                    if (_stackTraceEndRegex.IsMatch(t))
                    {
                        append(t, true);
                        state = 0;
                    }
                    else
                    {
                        sb.AppendLine(t);
                    }
                }
            }

            if (sb.Length != 0)
            {
                push(state != 0);
            }

            var c = strs
                .SelectMany(x => x.Item1 ?
                    SyntaxHighlightingFormatter.Highlight(x.Item2) :
                    new[] { new ColoredText(new DefaultAphidColorTheme().GetColor(Lexer.AphidTokenType.Text), x.Item2) })
                .ToArray();

            return c;
        }
    }
}
