using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LLex
{
    public static class LLexFile
    {
        const string CodeDelimiter = "%%";

        const string KeywordDelimiter = "@@";

        public static string Interpret(string file)
        {
            var tokenTable = new TokenTable();

            var lexFileMode = LexFileMode.Normal;
            
            var llText = File.ReadAllText(file);

            var modeRegex = new Regex(@"^[a-zA-Z_][0-9a-zA-Z_-]*$");
            var tokenRegex = new Regex(@"^([^\s]+)\s+(([a-zA-Z_][0-9a-zA-Z_-]*)|(%%))(\s+([a-zA-Z_][0-9a-zA-Z_-]*))?$");            

            var lines = llText
                .Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim());            

            var lexerMode = 0;
            var lexerModes = new Dictionary<string, int>();
            var tokenTypes = new List<string>();
            var keywords = new List<string>();

            string llName = lines.First();
            lines = lines.Skip(1);

            var lastDot = llName.LastIndexOf('.');

            string ns = llName.Remove(lastDot);
            string name = llName.Substring(lastDot + 1);
            string lexerName = name + "Lexer";
            string tokenName = name + "Token";
            string tokenTypeName = name + "TokenType";

            string codeLexeme = null;
            string code = null;
            string buffer = null;
            string keywordDefault = "";
            string keywordTail = "";

            void registerMode(string x)
            {
                if (!lexerModes.ContainsKey(x))
                {
                    lexerModes.Add(x, lexerMode++);
                }
            }

            foreach (var line in lines)
            {
                if (lexFileMode == LexFileMode.Normal)
                {
                    Match m = null;
                    if (modeRegex.IsMatch(line))
                    {
                        registerMode(line);

                        tokenTable.SetMode(lexerModes[line]);
                    }
                    else if (line == KeywordDelimiter)
                    {
                        lexFileMode = LexFileMode.Keyword;                        
                        continue;
                    }
                    else if (line == CodeDelimiter)
                    {
                        lexFileMode = LexFileMode.Code;
                        codeLexeme = null;
                        code = "";
                        continue;
                    }
                    else if ((m = tokenRegex.Match(line)) != null)
                    {
                        var regex = m.Groups[1].Value;

                        var regexLexer = new RegexLexer(regex);
                        var tokens = regexLexer.GetTokens();
                        var parser = new RegexParser(tokens.ToArray());
                        var ast = parser.Parse();
                        var compiler = new RegexCompiler(ast);
                        var strings = compiler.ExpandRegex();

                        foreach (var lexeme in strings)
                        {
                            var tokenType = m.Groups[2].Value;

                            if (tokenType == CodeDelimiter)
                            {
                                codeLexeme = lexeme;
                                code = "";
                                lexFileMode = LexFileMode.Code;
                                continue;
                            }
                            else if (!tokenTypes.Contains(tokenType))
                            {
                                tokenTypes.Add(tokenType);
                            }

                            var newMode = m.Groups[6].Value;

                            if (!string.IsNullOrEmpty(newMode))
                            {
                                registerMode(newMode);

                                tokenTable.Add(lexeme, tokenType, lexerModes[newMode]);
                            }
                            else
                            {
                                tokenTable.Add(lexeme, tokenType);
                            }
                        }
                    }
                }
                else if (lexFileMode == LexFileMode.Code)
                {
                    if (line == CodeDelimiter)
                    {
                        if (codeLexeme != null)
                        {
                            tokenTable.AddLexemeCode(codeLexeme, code);
                        }
                        else
                        {
                            tokenTable.AddCode(code);
                        }

                        lexFileMode = LexFileMode.Normal;
                        continue;
                    }
                    else
                    {
                        code += line + "\r\n";
                    }
                }
                else if (lexFileMode == LexFileMode.Keyword)
                {
                    if (line == KeywordDelimiter)
                    {
                        lexFileMode = LexFileMode.Normal;
                        continue;
                    }
                    else if (line == CodeDelimiter)
                    {
                        lexFileMode = LexFileMode.KeywordDefault;
                        continue;
                    }
                    else if (line != "")
                    {
                        keywords.Add(line);
                        tokenTable.AddKeyword(line);
                    }
                }
                else if (lexFileMode == LexFileMode.KeywordDefault)
                {
                    if (line == CodeDelimiter)
                    {
                        if (string.IsNullOrEmpty(keywordDefault))
                        {
                            keywordDefault = buffer;
                        }
                        else
                        {
                            keywordTail = buffer;
                        }

                        buffer = "";

                        lexFileMode = LexFileMode.Keyword;
                        continue;
                    }
                    else
                    {
                        buffer += line + "\r\n";
                    }
                }
            }
            
            foreach (var keyword in keywords)
            {
                var t = keyword + "Keyword";
                if (keywordTail != null)
                {
                    tokenTable.AddLexemeCode(keyword, keywordTail.Replace("{Keyword}", t));
                }
                else
                {
                    tokenTable.Add(keyword, t);
                }
            }

            if (!string.IsNullOrEmpty(keywordDefault))
            {
                var k = keywords
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
                    tokenTable.AddLexemeCode(i, keywordDefault);
                }
            }

            //var tuples = tokenTable.Lists[1]
            //    .Where(x => x.TokenType != "None" && x.NewMode == null)
            //    .Concat(tokenTable.Keywords
            //        .Select(y => new TokenEntry(y, y + "Keyword")))
            //    .Select(x => string.Format(
            //        "Tuple.Create(TokenType.{0},\"{1}\"),",
            //        x.TokenType,
            //        Char.IsWhiteSpace(x.Lexeme[0]) ? string.Format("\\x{0:X2}", (int)x.Lexeme[0]) : 
            //        x.Lexeme == "\\" ? "\\\\" :
            //        x.Lexeme))
            //    .Aggregate((x, y) => x + "\r\n" + y);

            var generator = new LexerGenerator(tokenTable);
            var lexer = generator.Generate();

            return lexer
                .Replace("{Lexer}", lexerName)
                .Replace("{Token}", tokenName)
                .Replace("{TokenType}", tokenTypeName)
                .Replace("{LexerNamespace}", ns);
        }
    }
}
