using Components.Aphid.Interpreter;

namespace LambdaSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new AphidInterpreter();

            interpreter.Interpret(@"
                #'Std';
                add = @(x, y) x + y;
                print(add(3, 7));
            ");
        }
    }
}
