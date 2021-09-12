using Components.Aphid.TypeSystem;
using Components.Aphid.UI;
using Components.External.ConsolePlus;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Components.Aphid.Interpreter;
using Components.External;

namespace SandboxTest
{
    class Program
    {
        static void Write(string message)
        {
            Console.Write(message);
        }

        static void WriteLine(string message)
        {
            Console.Write(message + "\r\n");
        }

        //[System.Security]
        static void Main(string[] args)
        {
            string untrustedCode = @"
                using System;
              
                Console.WriteLine('Hello, world');
            ";

            var rootPath = "f:\\temp";
            var Request = new { UserHostAddress = "test" };

            //        Response.Write(untrustedCode);
            var logFile = Path.Combine(rootPath, "data", "aphidCode." + Guid.NewGuid() + ".dat");

            var logDir = Path.GetDirectoryName(logFile);

            if (!Directory.Exists(logDir))
            {
                Directory.CreateDirectory(logDir);
            }

            File.AppendAllText(logFile, Request.UserHostAddress + " - " + DateTime.Now.ToUniversalTime().ToString() + "\r\n");
            File.AppendAllText(logFile, new string('-', 64) + "\r\n");
            File.AppendAllText(logFile, untrustedCode);
            File.AppendAllText(logFile, new string('-', 64) + "\r\n");

            var w = new ConsoleTextWriter();
            w.DataReceived += (o, e) => Console.Write(e.Data + "\r\n");
            Cli.WriteHandler = Write;
            Cli.WriteLineHandler = WriteLine;
            //Console.SetOut(w);
            //Console.SetError(w);

            var code = @"
using Components.External.ConsolePlus;
using System.IO;
//Directory.GetCurrentDirectory() |> Cli.WriteLine;
#'Std';
            #'System/Sandbox';


            sandbox.root = sandboxDir;
            sandbox.bin = sandboxBin;
            sandbox.eval(untrustedCode)
        ";

            var interpreter = new AphidInterpreter(true);

            interpreter.CurrentScope.Add(
                "untrustedCode",
                AphidObject.Scalar(untrustedCode));

            interpreter.CurrentScope.Add(
                "sandboxDir",
                AphidObject.Scalar(Path.Combine(rootPath, "Data", "Temp", "Sandbox")));

            interpreter.CurrentScope.Add(
                "sandboxBin",
                //AphidObject.Scalar(Path.Combine(rootPath, "bin")));
                AphidObject.Scalar(PathHelper.GetExecutingPath()));


            //interpreter.Loader.SystemSearchPaths.Add((Path.Combine(rootPath, "bin", "Library")));
            //interpreter.Loader.SearchPaths.Add((Path.Combine(rootPath, "bin", "Library")));
            //interpreter.Loader.SystemSearchPaths.Add(".\\Library");
            //interpreter.Loader.SearchPaths.Add(".\\Library");



            //interpreter.Loader.SystemSearchPaths.Add(Path.Combine(rootPath, "bin", "Library"));
            //interpreter.Loader.SearchPaths.Add(Path.Combine(rootPath, "bin", "Library"));

            var result = AphidCli.TryAction(
                interpreter,
                code,
                () => interpreter.Interpret(code, isTextDocument: false),
                allowErrorReporting: false);
        }
    }
}
