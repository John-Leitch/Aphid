﻿using Components.Aphid.Interpreter;
using Components.Aphid.Parser;
using Components.Aphid.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantispid
{
    internal static class Program
    {
        private static void DisplayDirections()
        {
            Console.WriteLine("mantispid [Parser Script] [Output File]");
            Environment.Exit(0);
        }

        private static void Main(string[] args)
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

            //if (scriptInfo.LastWriteTimeUtc < outputInfo.LastWriteTimeUtc)
            //{
            //    Console.WriteLine("C# output update to date, not regenerating");
            //    Environment.Exit(0);
            //}

            var dir = Path.GetDirectoryName(Path.GetFullPath(args[0]));
            var code = File.ReadAllText(args[0]);

            if (!Debugger.IsAttached)
            {
                try
                {
                    GenerateParser(code, dir, args[1]);
                    Environment.Exit(0);
                }
                catch (AphidParserException exception)
                {
                    AphidCli.DumpException(exception, code);
                }
                catch (AphidLoadScriptException exception)
                {
                    AphidCli.DumpException(exception, exception.Interpreter);
                }
                catch (AphidRuntimeException exception)
                {
                    AphidCli.DumpException(exception, exception.Interpreter);
                }
                catch (Exception exception)
                {
                    AphidCli.DumpException(exception, null);
                }

                Environment.Exit(0xbad);
            }
            else
            {
                GenerateParser(code, dir, args[1]);
            }
        }

        private static void GenerateParser(string code, string dir, string outFile)
        {
            Console.WriteLine("Parsing input file");
            var ast = AphidParser.Parse(code);
            var includeMutator = new IncludeMutator(dir);
            var idMutator = new AphidPreprocessorDirectiveMutator();
            var macroMutator = new AphidMacroMutator();
            var pipelineMutator = new PipelineToCallMutator();

            ast = idMutator.MutateRecursively(
                macroMutator.MutateRecursively(
                    pipelineMutator.Mutate(
                        includeMutator.MutateRecursively(ast))));

            Console.WriteLine("Generating parser");
            var parserGenerator = new ParserGenerator();
            var s = parserGenerator.Generate(ast, code);
            File.WriteAllText(outFile, s);
            Console.WriteLine("Parser written to '{0}'", outFile);
        }
    }
}
