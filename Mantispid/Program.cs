using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantispid
{
    class Program
    {
        static void DisplayDirections()
        {
            Console.WriteLine("mantispid [Parser Script] [Output File]");
            Environment.Exit(0);
        }

        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                DisplayDirections();
            }
            else if (!File.Exists(args[0]))
            {
                Console.WriteLine("Could not find parser script '{0}'", args[0]);
                Environment.Exit(1);
            }
            else if (args[1].Any(Path.GetInvalidPathChars().Contains))
            {
                Console.WriteLine("Invalid output file '{0}'", args[1]);
                Environment.Exit(2);
            }

            // Todo fix critical bug where include dates are not checked
            var scriptInfo = new FileInfo(args[0]);
            var outputInfo = new FileInfo(args[1]);

            if (scriptInfo.LastWriteTimeUtc < outputInfo.LastWriteTimeUtc)
            {
                Console.WriteLine("C# output update to date, not regenerating");
                Environment.Exit(0);
            }

            string code = "";
            
            try
            {
                var dir = Path.GetDirectoryName(Path.GetFullPath(args[0]));
                code = File.ReadAllText(args[0]);
                Console.WriteLine("Parsing input file");
                var ast = AphidParser.Parse(code);
                var includeMutator = new IncludeMutator(dir);
                var macroMutator = new AphidMacroMutator();
                var pipelineMutator = new PipelineToCallMutator();
                ast = macroMutator.MutateRecursively(pipelineMutator.Mutate(includeMutator.MutateRecursively(ast)));
                Console.WriteLine("Generating parser");
                var parserGenerator = new ParserGenerator();
                var s = parserGenerator.Generate(ast);
                File.WriteAllText(args[1], s);
                Console.WriteLine("Parser written to '{0}'", args[1]);
            }
            catch (AphidParserException exception)
            {
                Console.WriteLine(ParserErrorMessage.Create(code, exception));
            }
            catch (Exception exception)
            {
                if (Debugger.IsAttached)
                {
                    throw;
                }
                else
                {
                    Console.WriteLine("Unexpected exception\r\n\r\n{0}\r\n", exception.Message);
                    Environment.Exit(3);
                }
            }
        }
    }
}
