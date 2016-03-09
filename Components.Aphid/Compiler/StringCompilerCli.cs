﻿using Components.Aphid.Parser;
using Components.ConsolePlus;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Compiler
{
    public class StringCompilerCli
    {
        private AphidStringEmitter _emitter;

        private string _name;

        private string _targetName;

        private string _extension;

        private string[] _args;

        public StringCompilerCli(
            string name,
            string targetName,
            string extension,
            AphidStringEmitter emitter,
            string[] args)
        {
            _name = name;
            _targetName = targetName;
            _extension = extension;
            _emitter = emitter;
            _args = args;
        }

        private Memoizer<string, string[]> _inputFileMemoizer = new Memoizer<string, string[]>();

        private void WriteHeader()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;
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
            else if (_args.Length > 1)
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

            if (hasWildcard)
            {
                var path = ParseWildcardPath(fullname);

                if (!Directory.Exists(path[0]))
                {
                    Cli.WriteCriticalErrorMessage("Could not find directory '~Yellow~{0}~R~'.", _args[0]);
                    Environment.Exit(4);
                }

                if (!GetInputFiles(fullname).Any())
                {
                    Cli.WriteCriticalErrorMessage("Could not find input files in directory '~Yellow~{0}~R~'.", _args[0]);
                    Environment.Exit(5);
                }
            }
        }

        private string[] ParseWildcardPath(string fullname)
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

            Cli.WriteLine("be ~|DarkGray~~White~script file~R~\r\n");
            Cli.WriteLine("e.g. be ~Cyan~HelloWorld.alx~R~");
        }

        private void ComileFile(string filename, string outFilename)
        {
            Cli.WriteInfoMessage("Parsing '~Cyan~{0}~R~'", filename);
            var ast = ParseCode(filename);
            Cli.WriteSuccessMessage("File successfully parsed");
            EmitCode(ast, outFilename);
        }

        private string[] GetInputFiles(string fullname)
        {
            return _inputFileMemoizer.Call(GetInputFilesCore, fullname);
        }

        private string[] GetInputFilesCore(string fullname)
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

        private string GetOutFilename()
        {
            switch (_args.Length)
            {
                case 1:
                    return GetOutFilename(_args[0]);
                case 2:
                    return _args[1];
                default:
                    throw new InvalidOperationException();
            }
        }

        private string GetOutFilename(string filename)
        {
            return Path.Combine(
                Path.GetDirectoryName(filename),
                Path.GetFileNameWithoutExtension(filename) + "." + _extension);
        }

        private List<AphidExpression> ParseCode(string filename)
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

        private void EmitCode(List<AphidExpression> ast, string filename)
        {
            try
            {
                Cli.WriteInfoMessage("Compiling to {0}", _targetName);
                var output = _emitter.Compile(ast);
                File.WriteAllText(filename, output);

                Cli.WriteSuccessMessage(
                    "Compilation successful, {0} written to '~Cyan~{1}~R~'",
                    _targetName,
                    filename);
            }
            catch (Exception e)
            {
                Cli.WriteCriticalErrorMessage("Compilation error: ~Yellow~{0}~R~", e.Message);
                Environment.Exit(5);
            }
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