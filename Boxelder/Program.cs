using Components.Aphid.Compiler;
using Components.Aphid.Lexer;
using Components.Aphid.Parser;
using Components.ConsolePlus;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Boxelder
{
    class Program
    {
        private static void ValidateArgs(string[] args)
        {
            if (args.Length == 0)
            {
                WriteDirections();
                Environment.Exit(1);
            }
            else if (args.Length > 1)
            {
                Cli.WriteLine("Invalid arguments.");
                Environment.Exit(2);
            }

            if (!File.Exists(args[0]))
            {
                Cli.WriteLine("Could not find input file '~Yellow~{0}~R~'.", args[0]);
                Environment.Exit(3);
            }
            
        }

        private static void Main(string[] args)
        {
            WriteHeader();
            ValidateArgs(args);
            Cli.WriteInfoMessage("Parsing '~Cyan~{0}~R~'", args[0]);
            var ast = ParseCode(args[0]);
            Cli.WriteSuccessMessage("File successfully parsed");
            var outFile = GetOutFilename(args);
            EmitCode(ast, outFile);
        }

        private static string GetOutFilename(string[] args)
        {
            switch (args.Length)
            {
                case 1:
                    return Path.GetFileNameWithoutExtension(args[0]) + ".py";
                case 2:
                    return args[1];
                default:
                    throw new InvalidOperationException();
            }
        }

        private static List<AphidExpression> ParseCode(string filename)
        {
            var code = File.ReadAllText(filename);

            try
            {
                return AphidParser.Parse(code);
            }
            catch (AphidParserException exception)
            {
                var msg = ParserErrorMessage.Create(code, exception);
                Cli.WriteLine(Cli.Escape(msg));
                Environment.Exit(4);
                throw;
            }
        }

        private static void EmitCode(List<AphidExpression> ast, string filename)
        {
            try
            {
                var emitter = new AphidPythonEmitter();
                Cli.WriteInfoMessage("Compiling to Python");
                var python = emitter.Compile(ast);
                File.WriteAllText(filename, python);
                Cli.WriteSuccessMessage("Compilation successful, Python written to '~Cyan~{0}~R~'", filename);
            }
            catch (Exception e)
            {
                Cli.WriteCriticalErrorMessage("Compilation error: ~Yellow~{0}~R~", e.Message);
                Environment.Exit(5);
            }
        }

        private static void WriteHeader()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            var header = string.Format("Boxelder {0}", version);
            Cli.WriteHeader(header, "~|Blue~~White~");
            Cli.WriteLine();
        }

        private static void WriteDirections()
        {
            Cli.WriteLine("Compiles an Aphid program (~Cyan~*.alx~R~) program into Python (~Cyan~*.py~R~).\r\n");
            Cli.WriteLine("be ~|DarkGray~~White~script file~R~\r\n");
            Cli.WriteLine("e.g. be ~Cyan~HelloWorld.alx~R~");
        }
    }
}
