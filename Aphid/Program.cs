using Components.Aphid;
using Components.Aphid.Interpreter;
using Components.Aphid.Lexer;
using Components.Aphid.Library;
using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
            if (args.Length != 1)
            {
                DisplayDirections();
            }
            else if (!File.Exists(args[0]))
            {
                Console.WriteLine("Could not find {0}", args[0]);
                Environment.Exit(1);
            }

            var code = File.ReadAllText(args[0]);

            EnvironmentLibrary.SetEnvArgs(true);

            var interpreter = new AphidInterpreter();

            try
            {
                interpreter.Interpret(code);
            }
            catch (AphidParserException exception)
            {
                Console.WriteLine(ParserErrorMessage.Create(code, exception));
            }
            catch (AphidRuntimeException exception)
            {
                Console.WriteLine("Unexpected runtime exception\r\n\r\n{0}\r\n", exception.Message);
                DumpStackTrace(interpreter);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Unexpected exception\r\n\r\n{0}\r\n", exception.Message);
                DumpStackTrace(interpreter);
            }
        }

        static void DumpStackTrace(AphidInterpreter interpreter)
        {
            var trace = interpreter.GetStackTrace();
            var i = 0;

            foreach (var frame in trace)
            {
                Console.Write('[');
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("{0:x4}", i++);
                Console.ResetColor();
                Console.WriteLine("] {0}", frame.ToString(true));
            }
        }
    }
}
