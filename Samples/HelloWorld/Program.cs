using Components.Aphid.Interpreter;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new AphidInterpreter();
            
            interpreter.Interpret(@"
                #'Std';
                print('Hello, world');
            ");
        }
    }
}
