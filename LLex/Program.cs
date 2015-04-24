using System;
using System.IO;

namespace LLex
{
    class Program
    {
        static void TestCompiler()
        {
            foreach (var regex in new[] 
            {
                @"<(\?(php)?)|%",
                @"<(\?|%)=",
                @"(<>)|(!=)",
                @"\?|:",
                //@"\r|\n|\t|\v|\s",
                @"(\?|%)>",
            })
            {
                var regexLexer = new RegexLexer(regex);
                var tokens = regexLexer.GetTokens();
                var parser = new RegexParser(tokens.ToArray());
                var ast = parser.Parse();
                var compiler = new RegexCompiler(ast);
                var strings = compiler.ExpandRegex();

                Console.WriteLine("Regex:\r\n    {0}\r\nExpanded:", regex);

                foreach (var s in strings)
                {
                    Console.WriteLine("    {0}", s);
                }

                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //TestCompiler();

            if (args.Length == 0)
            {
                Console.WriteLine("No llex or alx file specified");
                return;
            }
            else if (!File.Exists(args[0]))
            {
                Console.WriteLine("Invalid llex file {0}", args[0]);
                return;
            }

            Console.WriteLine("Generating lexer...");

            string outputFile = args.Length > 1 ? args[1] : new FileInfo(args[0]).FullName + ".cs";

            var lexer = args[0].ToLower().EndsWith(".alx") ?
                AlxFile.Interpret(args[0]) :
                LLexFile.Interpret(args[0]);

            File.WriteAllText(outputFile, lexer);
           
            Console.WriteLine("Lexer written to {0}", outputFile);            
        }
    }
}
