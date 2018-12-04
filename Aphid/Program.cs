using Components;
using Components.Aphid.Debugging;
using Components.Aphid.Interpreter;
using Components.Aphid.Library;
using Components.Aphid.Parser;
using Components.Aphid.UI;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
            try
            {
                VT100.Enable();
            }
            catch { }

            if (args.Length > 0 && args[0] == "-ignoreDbg")
            {
                AphidErrorHandling.IgnoreDebugger = true;
                args = args.Skip(1).ToArray();
            }
            else if (AphidConfig.Current.IgnoreDebugger)
            {
                AphidErrorHandling.IgnoreDebugger = true;
            }

            if (args.Length == 0)
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
            else
            {
                RunScript(args);
            }
        }

        static void RunScript(string[] args)
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

#if !APHID_DEBUGGING_ENABLED
            if (AphidConfig.Current.ScriptCaching)
            {
                if (AphidErrorHandling.HandleErrors)
                {
                    AphidCli.TryAction(
                        interpreter,
                        () => AphidScript.Read(file),
                        () =>
                        {
                            var cache = new AphidByteCodeCache(interpreter.Loader.SearchPaths.ToArray());
                            interpreter.Interpret(cache.Read(file));
                        },
                        allowErrorReporting: true);
                }
                else
                {
                    var cache = new AphidByteCodeCache(interpreter.Loader.SearchPaths.ToArray());
                    interpreter.Interpret(cache.Read(file));
                }
            }
            else
            {
#endif
                var code = AphidScript.Read(file);

                if (AphidErrorHandling.HandleErrors)
                {
                    AphidCli.TryAction(
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
            
        }

        static void RunExpression(string[] args)
        {
            AphidCli.DumpExpression(GetInlineCode('?'));
        }

        static void RunStatements(string[] args)
        {
            AphidCli.ExecuteCode(GetInlineCode('*'));
        }

        static string GetInlineCode(char startToken)
        {
            var index = Environment.CommandLine.IndexOf(startToken);

            return index != -1 ? Environment.CommandLine.Substring(index + 1) : null;
        }

        static void RunRepl()
        {
            var asm = Assembly.GetExecutingAssembly();
            var version = asm.GetName().Version;
            var time = asm.GetLinkTime().ToEasternStandardTime();
            Cli.WriteHeader($"Aphid Programming Language {version} {time} EST", "~White~~|Blue~");
            new AphidRepl().Run();
        }
    }
}
