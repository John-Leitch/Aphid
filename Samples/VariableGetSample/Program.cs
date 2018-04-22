using Components.Aphid.Interpreter;
using System;

namespace VariableGetSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new AphidInterpreter();
            interpreter.Interpret("var x = 'foo';");
            Console.WriteLine(interpreter.CurrentScope["x"].Value);
        }
    }
}
