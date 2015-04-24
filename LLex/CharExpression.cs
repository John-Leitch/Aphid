using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LLex
{
    public class CharExpression : RegexExpression
    {
        public char Char { get; private set; }

        public CharExpression(char c)
        {
            Char = c;
        }

        public override string ToString()
        {
            return System.Text.RegularExpressions.Regex.Escape(Char.ToString()) + base.ToString();
        }
    }
}
