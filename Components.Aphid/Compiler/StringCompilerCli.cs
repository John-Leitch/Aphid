using Components.Aphid.Parser;
using Components.External;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Components.Aphid.Compiler
{
    public class StringCompilerCli
    {
        private AphidStringEmitter _emitter;

        private readonly string _name;

        private readonly string _targetName;

        private readonly string _extension;

        private string[] _args;

        private readonly bool _isText;

        public StringCompilerCli(
            string name,
            string targetName,
            string extension,
            AphidStringEmitter emitter,
            bool isText)
        {
            _name = name;
            _targetName = targetName;
            _extension = extension;
            _emitter = emitter;
            _isText = isText;
            _args = Environment.GetCommandLineArgs().Skip(1).ToArray();
        }

        private Memoizer<string, string[]> _inputFileMemoizer = new Memoizer<string, string[]>();

        private void WriteHeader()
        {
            var version = Assembly.GetEntryAssembly().GetName().Version;
            var header = string.Format("{0} {1}", _name, version);
            Cli.WriteHeader(header, "~|Blue~~White~");
            Cli.WriteLine();
        }

        private void ValidateArgs()
        {
            if (_args.Length == 0)
            {
                WriteDirections();
                Environment.Exit(1);
            }
            else if (_args.Length > 2)
            {
                Cli.WriteLine("Invalid arguments.");
                Environment.Exit(2);
            }

            var fullname = _args[0];
            var hasWildcard = _args[0].Contains('*');

            if (!File.Exists(fullname) && !hasWildcard)
            {
                Cli.WriteCriticalErrorMessage("Could not find input file '~Yellow~{0}~R~'.", _args[0]);
                Environment.Exit(3);
            }

            if (_args.Length > 1 && !Directory.Exists(_args[1]))
            {
                Cli.WriteLine("Output directory does not exist.");
                Environment.Exit(4);
            }

            if (hasWildcard)
            {
                var path = ParseWildcardPath(fullname);

                if (!Directory.Exists(path[0]))
                {
                    Cli.WriteCriticalErrorMessage("Could not find directory '~Yellow~{0}~R~'.", _args[0]);
                    Environment.Exit(5);
                }

                if (GetInputFiles(fullname).Length == 0)
                {
                    Cli.WriteCriticalErrorMessage("Could not find input files in directory '~Yellow~{0}~R~'.", _args[0]);
                    Environment.Exit(6);
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

        private void WriteDirections()
        {
            Cli.WriteLine(
                "Compiles an Aphid program (~Cyan~*.alx~R~) program into {0} (~Cyan~*.{1}~R~).\r\n",
                _targetName,
                _extension);
            var asm = Path.GetFileNameWithoutExtension(Assembly.GetEntryAssembly().Location);
            Cli.WriteLine("{0} ~|DarkGray~~White~script file~R~\r\n", asm);
            Cli.WriteLine("e.g. {0} ~Cyan~HelloWorld.alx~R~", asm);
        }

        private void ComileFile(string filename, string outFilename)
        {
            Cli.WriteInfoMessage("Parsing '~Cyan~{0}~R~'", filename);
            var ast = ParseCode(filename);
            Cli.WriteSuccessMessage("File successfully parsed");
            TryEmitCode(ast, outFilename);
        }

        private string[] GetInputFiles(string fullname) =>
            _inputFileMemoizer.Call(GetInputFilesCore, fullname);

        private static string[] GetInputFilesCore(string fullname)
        {
            if (fullname.Contains('*'))
            {
                var parts = ParseWildcardPath(fullname);
                return Directory.GetFiles(parts[0], parts[1], SearchOption.AllDirectories);
            }

            return new[] { fullname };
        }

        private string GetOutFilename(string filename)
        {
            return Path.Combine(
                _args.Length == 1 ? Path.GetDirectoryName(filename) : _args[1],
                Path.GetFileNameWithoutExtension(filename) + "." + _extension);
        }

        private List<AphidExpression> ParseCode(string filename)
        {
            var code = File.ReadAllText(filename);

            try
            {
                return AphidParser.Parse(code, isTextDocument: _isText);
            }
            catch (AphidParserException exception)
            {
                var msg = ParserErrorMessage.Create(code, exception, true);
                Cli.WriteCriticalErrorMessage("~Yellow~Error parsing code~R~\r\n\r\n{0}", Cli.Escape(msg));
                Environment.Exit(100);
                throw;
            }
        }

        private void TryEmitCode(List<AphidExpression> ast, string filename)
        {
            if (!Debugger.IsAttached)
            {
                try
                {
                    EmitCode(ast, filename);
                }
                catch (Exception e)
                {
                    Cli.WriteCriticalErrorMessage("Compilation error: ~Yellow~{0}~R~", e.Message);
                    Environment.Exit(5);
                }
            }
            else
            {
                EmitCode(ast, filename);
            }
        }

        private void EmitCode(List<AphidExpression> ast, string filename)
        {
            Cli.WriteInfoMessage("Compiling to {0}", _targetName);
            var output = _emitter.Compile(filename, ast);
            File.WriteAllText(filename, output);

            Cli.WriteSuccessMessage(
                "Compilation successful, {0} written to '~Cyan~{1}~R~'",
                _targetName,
                filename);
        }

        public void Compile()
        {
            WriteHeader();
            ValidateArgs();

            foreach (var file in GetInputFiles(_args[0]))
            {
                ComileFile(file, GetOutFilename(file));
            }
        }
    }
}
