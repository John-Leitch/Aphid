using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LLex
{
    public class LexerGenerator
    {
        private TokenTable table;

        public bool IgnoreCase { get; set; }

        public LexerGenerator(TokenTable table) => this.table = table;

        private static string EncodeChar(char c) =>
            c < 32 ? "\\x" + Convert.ToString(c, 16).PadLeft(2, '0') :
                c == '\\' ? "\\\\" :
                c == '\'' ? "\\'" :
                c.ToString();

        private void SetNone(LexerState state, bool ancestralExitState)
        {
            if (ancestralExitState && state.Token == "Unknown")
            {
                state.Token = "None";
            }
            else if (state.Token != "Unknown" && state.Token != "None")
            {
                ancestralExitState = true;
            }

            foreach (var child in state.Children)
            {
                SetNone(child, ancestralExitState);
            }
        }

        public LexerState GroupTokens(IEnumerable<TokenEntry> tokens)
        {
            var state = new LexerState();

            GroupTokens(tokens, 0, state);

            SetNone(state, false);

            return state;
        }

        public void GroupTokens(IEnumerable<TokenEntry> tokens, int groupIndex, LexerState state)
        {
            var groups = tokens
                .Where(x => x.Lexeme != null && groupIndex < x.Lexeme.Length)
                .GroupBy(x => x.Lexeme[groupIndex]);

            foreach (var group in groups)
            {
                var groupState = new LexerState();
                groupState.State = group.Key;
                var returnTokens = group.Where(x => x.Lexeme.Length - 1 == groupIndex).ToArray();

                if (returnTokens.Length > 1)
                {
                    Console.WriteLine(
                        "Invalid token declared {0} times: {1}",
                        returnTokens.Length,
                        returnTokens[0].Lexeme);
                }

                var returnToken = returnTokens.FirstOrDefault();

                if (returnToken?.Lexeme != null)
                {
                    groupState.Token = returnToken.TokenType;
                    groupState.Code = returnToken.Code;
                    groupState.NewMode = returnToken.NewMode;
                }
                else
                {
                    groupState.Token = "Unknown";
                }

                state.Children.Add(groupState);

                GroupTokens(group, groupIndex + 1, groupState);
            }
        }

        private string CreateCase(string charString) => string.Format("case '{0}':", charString);

        private string CreateCases(string charString)
        {
            if (!IgnoreCase || charString.Length != 1)
            {
                return CreateCase(charString);
            }

            return new[] { charString, charString.ToUpper(), charString.ToLower() }
                .Distinct()
                .Select(CreateCase)
                .Aggregate((x, y) => x + "\r\n" + y);
        }

        public string EmitState(LexerState state, bool root, IEnumerable<string> defaults = null)
        {
            if (table.KeywordTokens.Contains(state.Token))
            {
                //defaults 
            }

            string childTemplates;

            if (state.Children.Count > 0)
            {
                childTemplates = state.Children
                    .Select(x =>
                    {
                        var isCode = !string.IsNullOrEmpty(x.Code);

                        var body = "";

                        if (isCode)
                        {
                            body += x.Code;
                        }

                        if (x.NewMode != null)
                        {
                            body += "mode = " + x.NewMode.ToString() + ";\r\n";
                        }

                        if (x.Token != "None")
                        {
                            body += "return {TokenType}." + x.Token.ToString() + ";\r\n";
                        }
                        else
                        {
                            body += "\r\nbreak;\r\n";
                        }

                        var t = Components.Aphid.Properties.Resources.CaseTemplate
                            .Replace("{{Cases}}", CreateCases(EncodeChar(x.State)))
                            .Replace("{{Body}}", body)
                            .Replace("{{States}}", x.Children.Count > 0 ? EmitState(x, false) : "");

                        return t;
                    })
                    .Aggregate((x, y) => x + "\r\n" + y);
            }
            else
            {
                return "";
            }

            if (defaults?.Any() == true)
            {
                childTemplates += "\r\ndefault:\r\n" +
                    defaults.Aggregate((x, y) => x + "\r\n" + y) + "\r\nbreak;\r\n";
            }

            var template = !root ? 
                Components.Aphid.Properties.Resources.StateTemplate : 
                Components.Aphid.Properties.Resources.RootStateTemplate;

            return template.Replace("{{States}}", childTemplates);
        }

        public string GenerateIsKeyword() =>
            table.KeywordTokens.Count > 0 ?
                table.KeywordTokens
                    .Select(x => "TokenType == {TokenType}." + x)
                    .Aggregate((x, y) => x + "||\r\n" + new string(' ', 16) + y) :
                "false";

        private string GenerateIgnore()
        {
            if (table.Ignore == null || table.Ignore.Length == 0)
            {
                return "";
            }

            var conditions = string.Join("&&", table.Ignore.Select(x => "tokenType != {TokenType}." + x));

            return string.Format(@"if ({0})
                {{
                    {{Body}}
                }}", conditions);
        }

        public string Generate()
        {
            var enums = new [] { "None" }
                .Concat(table.Lists                
                    .SelectMany(x => x.Value)
                    .Select(x => x.TokenType)
                    .Concat(new[] { "Unknown", "EndOfFile" })
                    .Concat(table.Lists
                        .SelectMany(y => y.Value)
                        .Where(y => y.Code != null)
                        .SelectMany(y => Regex
                            .Matches(y.Code, @"TokenType\}?\s*.\s*([a-zA-Z_\x7f-\xff][a-zA-Z0-9_\x7f-\xff]*)")
                            .OfType<Match>()
                            .Select(z => z.Groups[1].Value)))
                    .Distinct()
                    .Where(x => x != "None")
                    .OrderBy(x => x))
                .Aggregate((x, y) => x + ",\r\n" + y);

            var root = table.Lists
                .Select(x => @"
                    if (mode == " + x.Key.ToString() + @")
                    {
                        " + EmitState(GroupTokens(x.Value), true, GetDefaults(x.Value)) + @"
                    }
                    ")
                .Aggregate((x, y) => x + "else " + y);


            var s = Components.Aphid.Properties.Resources.LexicalAnalyzerTemplate
                .Replace("{Root}", root)
                .Replace("{Enums}", enums)
                .Replace("{IsKeyword}", GenerateIsKeyword())
                .Replace("{Ignore}", GenerateIgnore());

            if (table.Ignore != null && table.Ignore.Length != 0)
            {
                s = s.Replace("{Body}", GenerateIgnore());
            }

            return s
                .Replace("{Body}", Components.Aphid.Properties.Resources.AddTokenTemplate)
                .Replace("{AllBody}", Components.Aphid.Properties.Resources.AddTokenTemplate)
                .Replace("PreviousChar();", "charIndex--;");
        }

        private static IEnumerable<string> GetDefaults(List<TokenEntry> tokens) =>
            tokens.Where(y => y.Lexeme == null).Select(y => y.Code);
    }
}
