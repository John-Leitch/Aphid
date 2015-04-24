using Components.Aphid.Interpreter;
using System.Reflection;

namespace InteropFunctionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var interprer = new AphidInterpreter();
            interprer.Loader.LoadModule(Assembly.GetExecutingAssembly());
            
            interprer.Interpret(@"
                #'Std';
                ##'InteropFunctionSample.AphidMath';
                print(math.add(3, 7));
            ");
        }
    }
}
