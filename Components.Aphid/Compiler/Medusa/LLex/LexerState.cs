using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LLex
{
    public class LexerState
    {
        public char State { get; set; }
        public string Token { get; set; }
        public string Code { get; set; }
        public int? NewMode { get; set; }
        public List<LexerState> Children { get; set; }

        public LexerState(char state, string token, List<LexerState> children)
        {
            State = state;
            Token = token;
            Children = children;
        }

        public LexerState(char state, string token)
            : this(state, token, null)
        {
        }

        public LexerState(List<LexerState> children)
            : this((char)0, "None", children)
        {
        }

        public LexerState()
            : this((char)0, "None", new List<LexerState>())
        {
        }
    }
}
