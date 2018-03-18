using Components.Aphid.Interpreter;
using Components.Aphid.TypeSystem;
using System;

namespace VariableSetSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new AphidInterpreter();
            interpreter.CurrentScope.Add("x", new AphidObject("foo"));

            interpreter.Interpret(@"
                #'Std';
                print(x);
            ");
        }
    }
}
