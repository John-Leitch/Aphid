using Components.Aphid.Interpreter;
using Components.Aphid.Library;
using Components.Aphid.Parser;
using Components.External.ConsolePlus;
using System;
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
            if (args.Length < 1)
            {
                DisplayDirections();
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

            try
            {
                interpreter.Interpret(code, isTextDocument);
            }
            catch (AphidParserException exception)
            {
                Console.WriteLine("Parser exception\r\n");
                Console.WriteLine(ParserErrorMessage.Create(code, exception));
            }
            catch (AphidRuntimeException exception)
            {
                Console.WriteLine("Unexpected runtime exception\r\n\r\n{0}\r\n", exception.Message);
                DumpStackTrace(interpreter);
            }
            catch (Exception exception)
            {
                Console.WriteLine(
                    "Unexpected exception\r\n\r\n{0}\r\n", 
                    ExceptionHelper.Unwrap(exception).Message);

                DumpStackTrace(interpreter);
            }
        }

        static void DumpStackTrace(AphidInterpreter interpreter)
        {
            var trace = interpreter.GetStackTrace();
            var i = 0;
            Cli.WriteSubheader("Stack Trace", "~|Blue~~White~");

            foreach (var frame in trace)
            {
                Cli.WriteLine("[~White~{0:x4}~R~] {1}", i++, frame.ToString(true));
            }

            Cli.WriteLine();
        }
    }
}
