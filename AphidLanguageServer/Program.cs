using Components.Aphid.Interpreter;
using Components.Aphid.UI;
using LanguageServer.Infrastructure.JsonDotNet;
using LanguageServer.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //var interpreter = new AphidInterpreter();
            //interpreter.Interpret("#'std';");
            //var autocomplete = new AphidScopeObjectAutocompletionSource(interpreter.CurrentScope);
            //string buf;
            //var words = autocomplete.GetWords("new ", 4, true, out buf);


            Console.OutputEncoding = Encoding.UTF8;
            var app = new App(Console.OpenStandardInput(), Console.OpenStandardOutput());
            Logger.Instance.Attach(app);
            try
            {
                app.Listen().Wait();
            }
            catch (AggregateException ex)
            {
                Console.Error.WriteLine(ex.InnerExceptions[0]);
                Environment.Exit(-1);
            }
        }
    }
}
