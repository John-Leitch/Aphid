﻿using System.Collections.Generic;

namespace LLex
{
    public class TokenTable
    {
        public string[] Ignore { get; set; }

        private readonly List<string> _keywordTokens = new();

        public List<string> KeywordTokens => _keywordTokens;

        private readonly List<string> _keywords = new();

        public List<string> Keywords => _keywords;

        private readonly Dictionary<int, List<TokenEntry>> _lists =
            new();

        public Dictionary<int, List<TokenEntry>> Lists => _lists;

        private int _mode;

        public int Mode => _mode;

        public TokenTable() => SetMode(0);

        public void SetMode(int mode)
        {
            if (!_lists.ContainsKey(mode))
            {
                _lists.Add(mode, new List<TokenEntry>());
            }

            _mode = mode;
        }

        public void Add(TokenEntry entry) => _lists[_mode].Add(entry);

        public void Add(string[] lexemes, string tokenType)
        {
            foreach (var lexeme in lexemes)
            {
                Add(new TokenEntry(lexeme, tokenType));
            }
        }

        public void AddKeyword(string keyword)
        {
            var tokenType = keyword + "Keyword";
            _keywordTokens.Add(tokenType);
            _keywords.Add(keyword);
            //Add(keyword, tokenType);
        }

        public void Add(string lexeme, string tokenType) =>
            Add(new TokenEntry(lexeme, tokenType));

        public void Add(string lexeme, string tokenType, int newMode) =>
            Add(new TokenEntry(lexeme, tokenType) { NewMode = newMode });

        public void AddLexemeCode(string lexeme, string code) =>
            Add(new TokenEntry(lexeme, "None", code));

        public void AddCode(string code) =>
            Add(new TokenEntry(null, "None", code));

        public void AddLexemeCode(string lexeme, string code, int newMode) =>
            Add(new TokenEntry(lexeme, "None", code) { NewMode = newMode });
    }
}
