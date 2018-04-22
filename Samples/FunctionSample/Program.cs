using Components.Aphid.Interpreter;

namespace FunctionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new AphidInterpreter();

            interpreter.Interpret(@"
                #'Std';

                var add = @(x, y) {
                    ret x + y;
                };

                print(add(3, 7));
            ");
        }
    }
}
