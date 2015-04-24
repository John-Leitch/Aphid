using Components.Aphid.Interpreter;

namespace HigherOrderFunctionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new AphidInterpreter();

            interpreter.Interpret(@"
                #'Std';
                call = @(func) func();
                foo = @() print('foo() called');                
                call(foo);
            ");
        }
    }
}
