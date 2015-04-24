using Components.Aphid.Interpreter;
using System;

namespace CallAphidFunctionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new AphidInterpreter();
            interpreter.Interpret("add = @(x, y) x + y;");
            var x = interpreter.CallFunction("add", 3, 7).Value;
            Console.WriteLine(x);
        }
    }
}
