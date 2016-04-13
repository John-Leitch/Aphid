using Components.Aphid.Interpreter;

namespace MacroSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new AphidInterpreter();

            interpreter.Interpret(@"
                #'std';
                m1 = macro(@{ 'Hello world' });
                m2 = macro(@(msg) { print(msg) });
                
                m3 = macro(@{
                    m2('foobar');
                    m2(m1());
                });
                
                m3();
            ");
        }
    }
}
