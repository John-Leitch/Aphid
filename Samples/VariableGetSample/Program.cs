using Components.Aphid.Interpreter;
using System;

namespace VariableGetSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new AphidInterpreter();
            interpreter.Interpret("x = 'foo';");
            Console.WriteLine(interpreter.CurrentScope["x"].Value);
        }
    }
}
