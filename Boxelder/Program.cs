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
        private static Memoizer<string, string[]> _inputFileMemoizer = new Memoizer<string, string[]>();

        private static void Main(string[] args)
        {
            WriteHeader();
            ValidateArgs(args);

            foreach (var file in GetInputFiles(args[0]))
            {
                ComileFile(file, GetOutFilename(file));
            }
        }

        private static void WriteHeader()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
            var header = string.Format("Boxelder {0}", version);
            Cli.WriteHeader(header, "~|Blue~~White~");
            Cli.WriteLine();
        }

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

            var fullname = args[0];
            var hasWildcard = args[0].Contains('*');

            if (!File.Exists(fullname) && !hasWildcard)
            {
                Cli.WriteCriticalErrorMessage("Could not find input file '~Yellow~{0}~R~'.", args[0]);
                Environment.Exit(3);
            }

            if (hasWildcard)
            {
                var path = ParseWildcardPath(fullname);

                if (!Directory.Exists(path[0]))
                {
                    Cli.WriteCriticalErrorMessage("Could not find directory '~Yellow~{0}~R~'.", args[0]);
                    Environment.Exit(4);
                }

                if (!GetInputFiles(fullname).Any())
                {
                    Cli.WriteCriticalErrorMessage("Could not find input files in directory '~Yellow~{0}~R~'.", args[0]);
                    Environment.Exit(5);
                }
            }
        }

        private static string[] ParseWildcardPath(string fullname)
        {
            var dir = Path.GetDirectoryName(fullname);
            var name = Path.GetFileName(fullname);

            if (name == "*")
            {
                name = "*.alx";
            }

            return new[] { dir, name };
        }

        private static void WriteDirections()
        {
            Cli.WriteLine("Compiles an Aphid program (~Cyan~*.alx~R~) program into Python (~Cyan~*.py~R~).\r\n");
            Cli.WriteLine("be ~|DarkGray~~White~script file~R~\r\n");
            Cli.WriteLine("e.g. be ~Cyan~HelloWorld.alx~R~");
        }

        private static void ComileFile(string filename, string outFilename)
        {
            Cli.WriteInfoMessage("Parsing '~Cyan~{0}~R~'", filename);
            var ast = ParseCode(filename);
            Cli.WriteSuccessMessage("File successfully parsed");
            EmitCode(ast, outFilename);
        }

        private static string[] GetInputFiles(string fullname)
        {
            return _inputFileMemoizer.Call(GetInputFilesCore, fullname);
        }

        private static string[] GetInputFilesCore(string fullname)
        {
            if (fullname.Contains('*'))
            {
                var parts = ParseWildcardPath(fullname);
                return Directory.GetFiles(parts[0], parts[1], SearchOption.AllDirectories);
            }
            else
            {
                return new[] { fullname };
            }
        }

        private static string GetOutFilename(string[] args)
        {
            switch (args.Length)
            {
                case 1:
                    return GetOutFilename(args[0]);
                case 2:
                    return args[1];
                default:
                    throw new InvalidOperationException();
            }
        }

        private static string GetOutFilename(string filename)
        {
            return Path.Combine(
                Path.GetDirectoryName(filename),
                Path.GetFileNameWithoutExtension(filename) + ".py");
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
                Cli.WriteCriticalErrorMessage("~Yellow~Error parsing code~R~\r\n\r\n{0}", Cli.Escape(msg));
                Environment.Exit(100);
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
    }
}
