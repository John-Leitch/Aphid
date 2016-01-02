using Components.Aphid.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LLex
{
    public static class AlxFile
    {
        public class LLexToken
        {
            [AphidProperty("regex")]
            public string Regex { get; set; }

            [AphidProperty("type")]
            public string TokenType { get; set; }

            [AphidProperty("code")]
            public string Code { get; set; }

            [AphidProperty("newMode")]
            public string NewMode { get; set; }
        }

        public class LLexMode
        {
            [AphidProperty("mode")]
            public string Mode { get; set; }

            [AphidProperty("tokens")]
            public LLexToken[] Tokens { get; set; }

            [AphidProperty("keywords")]
            public string[] Keywords { get; set; }

            [AphidProperty("keywordDefault")]
            public string KeywordDefault { get; set; }

            [AphidProperty("keywordTail")]
            public string KeywordTail { get; set; }            
        }

        public class LLexFile
        {
            [AphidProperty("name")]
            public string Name { get; set; }

            [AphidProperty("ignoreCase")]
            public bool IgnoreCase { get; set; }

            [AphidProperty("modes")]
            public LLexMode[] Modes { get; set; }

            [AphidProperty("ignore")]
            public string[] Ignore { get; set; }
        }

        public static string Interpret(string file)
        {
            var interpreter = new AphidInterpreter();
            interpreter.InterpretFile(file);
            var retVal = interpreter.GetReturnValue();

            return From(retVal);
        }

        public static string From(AphidObject retVal)
        {
            var llexFile = new LLexFile();
            retVal.Bind(llexFile);
            var tokenTable = new TokenTable();
            tokenTable.Ignore = llexFile.Ignore;
            var nameInfo = LLexNameInfo.Parse(llexFile.Name);

            int z = 0;
            var modeTable = llexFile.Modes.ToDictionary(x => x.Mode, x => z++);
            var tokenTypes = new List<string>();

            foreach (var mode in llexFile.Modes)
            {
                tokenTable.SetMode(modeTable[mode.Mode]);
                foreach (var token in mode.Tokens)
                {
                    if (token.Regex != null)
                    {
                        var regexLexer = new RegexLexer(token.Regex);
                        var tokens = regexLexer.GetTokens();
                        var parser = new RegexParser(tokens.ToArray());
                        var ast = parser.Parse();
                        var compiler = new RegexCompiler(ast);
                        var strings = compiler.ExpandRegex();

                        foreach (var l in strings)
                        {
                            if (token.Code != null)
                            {
                                tokenTable.AddLexemeCode(l, token.Code);
                                continue;
                            }

                            if (!tokenTypes.Contains(token.TokenType))
                                tokenTypes.Add(token.TokenType);

                            if (!string.IsNullOrEmpty(token.NewMode))
                            {
                                tokenTable.Add(l, token.TokenType, modeTable[token.NewMode]);
                            }
                            else
                            {
                                tokenTable.Add(l, token.TokenType);
                            }
                        }
                    }
                    else if (token.Code != null)
                    {
                        tokenTable.AddCode(token.Code);
                    }
                }

                foreach (var keyword in mode.Keywords ?? new string[0])
                {
                    tokenTable.AddKeyword(keyword);
                    var t = keyword + "Keyword";
                    if (mode.KeywordTail != null)
                    {
                        tokenTable.AddLexemeCode(keyword, mode.KeywordTail.Replace("{Keyword}", t));
                    }
                    else
                    {
                        tokenTable.Add(keyword, t);
                    }
                }

                if (!string.IsNullOrEmpty(mode.KeywordDefault))
                {
                    var k = mode.Keywords
                        .SelectMany(x => Enumerable
                            .Range(1, x.Length - 1)
                            .Select(y => x.Remove(y))
                            .ToArray())
                        .Distinct()
                        .ToArray();

                    foreach (var i in k)
                    {
                        if (tokenTable.Lists.Any(x => x.Value.Any(y => y.Lexeme == i)))
                        {
                            continue;
                        }
                        tokenTable.AddLexemeCode(i, mode.KeywordDefault);
                    }
                }
            }

            var generator = new LexerGenerator(tokenTable) { IgnoreCase = llexFile.IgnoreCase };
            var lexer = generator.Generate();


            return lexer
                .Replace("{Lexer}", nameInfo.LexerName)
                .Replace("{Token}", nameInfo.TokenName)
                .Replace("{TokenType}", nameInfo.TokenTypeName)
                .Replace("{LexerNamespace}", nameInfo.Namespace);
        }
    }
}
