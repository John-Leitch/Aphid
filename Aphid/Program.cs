using Components.Aphid.Interpreter;
using Components.Aphid.Library;
using Components.Aphid.Parser;
using Components.Aphid.UI;
using Components.External.ConsolePlus;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Aphid
{
    class Program
    {
        static void DisplayDirections()
        {
            Console.WriteLine("aphid [Script]");
            Environment.Exit(0);
        }

        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                RunRepl();
            }
            else if (!File.Exists(args[0]))
            {
                Console.WriteLine("Could not find {0}", args[0]);
                Environment.Exit(1);
            }

            var ext = Path.GetExtension(args[0]).ToLower();
            var isTextDocument = ext == ".alxt";
            var code = File.ReadAllText(args[0]);
            EnvironmentLibrary.SetEnvArgs(true);
            var interpreter = new AphidInterpreter();
            interpreter.SetScriptFilename(Path.GetFullPath(args[0]));

            if (!Debugger.IsAttached)
            {
                AphidCli.TryAction(
                    interpreter,
                    code,
                    () => interpreter.Interpret(code, isTextDocument));
            }
            else
            {
                interpreter.Interpret(code, isTextDocument);
            }

            if (interpreter.CurrentScope.ResolveBool(AphidName.OpenRepl))
            {
                new AphidRepl { Interpreter = interpreter }.Run();
            }
        }

        static void RunRepl()
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version;

            Cli.WriteHeader(
                string.Format("Aphid Programming Language {0}", version),
                "~White~~|Blue~");

            new AphidRepl().Run();
        }
    }
}
