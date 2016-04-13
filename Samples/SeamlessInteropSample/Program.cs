using Components.Aphid.Interpreter;

namespace SeamlessInteropSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new AphidInterpreter();
            
            interpreter.Interpret(@"
                using System;
                Console.WriteLine('Hello world');
            ");
        }
    }
}
