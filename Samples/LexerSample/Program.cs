using Components.Aphid.Lexer;
using System;

namespace LexerSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var lexer = new AphidLexer(@"
                using System;
                Console.WriteLine('Hello world');
            ");

            foreach (var t in lexer.GetTokens())
            {
                Console.WriteLine(t);
            }
        }
    }
}
