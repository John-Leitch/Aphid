using Components.Aphid.Debugging;
using Components.Aphid.Interpreter;
using Components.Aphid.Library;
using Components.Aphid.Parser;
using Components.Aphid.UI;
using Components.External.ConsolePlus;
using System;
using System.IO;
using System.Linq;

namespace Aphid
{
    internal static class Program
    {

        private static void Main(string[] args)
        {
            VT100.TryEnable();

            if (args.Length > 0 && args[0] == "-ignoreDbg")
            {
                AphidErrorHandling.IgnoreDebugger = true;
                args = args.Skip(1).ToArray();
            }
            else if (AphidConfig.Current.IgnoreDebugger)
            {
                AphidErrorHandling.IgnoreDebugger = true;
            }

            var runRepl = args.Length == 0;

            if (Cli.HasConsole)
            {
                var cursorVisible = Console.CursorVisible;
                AppDomain.CurrentDomain.ProcessExit += (o, e) =>
                Console.CursorVisible = cursorVisible;
            }

            AppDomain.CurrentDomain.ProcessExit += (o, e) => Console.ResetColor();
            CliApplication.SetTitle("Aphid", showHeader: runRepl);

            if (runRepl)
            {
                RunRepl();
            }
            else if (args[0][0] == '?')
            {
                RunExpression(args);
            }
            else if (args[0][0] == '*')
            {
                RunStatements(args);
            }
            else if (args[0][0] == '!')
            {
                RunQuotedStatements(args);
            }
            else
            {
                RunScript(args);
            }
        }

        private static void RunScript(string[] args)
        {
            if (!File.Exists(args[0]))
            {
                Console.WriteLine("Could not find {0}", args[0]);
                Environment.Exit(1);
            }

            var ext = Path.GetExtension(args[0]).ToLower();
            var isTextDocument = ext == ".alxt";
            var file = Path.GetFullPath(args[0]);
            var interpreter = new AphidInterpreter();
            interpreter.SetScriptFilename(file);
            EnvironmentLibrary.SetEnvArgs(true);
            var result = true;

#if !APHID_DEBUGGING_ENABLED
            if (AphidConfig.Current.ScriptCaching)
            {
                var cache = new AphidByteCodeCache(interpreter.Loader.SearchPaths.ToArray())
                {
                    DisableConstantFolding = false,
                    InlineScripts = true,
                };

                if (AphidErrorHandling.HandleErrors)
                {
                    result = AphidCli.TryAction(
                        interpreter,
                        () => AphidScript.Read(file),
                        () => interpreter.Interpret(cache.Read(file)),
                        allowErrorReporting: true);
                }
                else
                {
                    interpreter.Interpret(cache.Read(file));
                }
            }
            else
            {
#endif
                var code = AphidScript.Read(file);

                if (AphidErrorHandling.HandleErrors)
                {
                    result = AphidCli.TryAction(
                        interpreter,
                        code,
                        () => interpreter.Interpret(code, file, isTextDocument),
                        allowErrorReporting: true);
                }
                else
                {
                    interpreter.Interpret(code, file, isTextDocument);
                }

                if (interpreter.CurrentScope.ResolveBool(AphidName.OpenRepl))
                {
                    new AphidRepl { Interpreter = interpreter }.Run();
                }
#if !APHID_DEBUGGING_ENABLED
            }
#endif
            if (!result)
            {
                Environment.Exit(0xbad5230);
            }
        }

        private static void RunExpression(string[] args) =>
            AphidEvaluator.EvalExpression(GetInlineCode('?'));

        private static void RunStatements(string[] args) =>
            AphidEvaluator.Eval(GetInlineCode('*'));

        private static void RunQuotedStatements(string[] args) =>
            AphidEvaluator.Eval(StringParser.Parse(GetInlineCode('!')));

        private static string GetInlineCode(char startToken)
        {
            var index = Environment.CommandLine.IndexOf(startToken);

            return index != -1 ? Environment.CommandLine.Substring(index + 1) : null;
        }

        private static void RunRepl() => new AphidRepl().Run();
    }
}
