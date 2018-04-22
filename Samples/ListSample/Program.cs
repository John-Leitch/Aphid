using Components.Aphid.Interpreter;

namespace ListSample
{
    class Program
    {
        static void Main(string[] args)
        {
            new AphidInterpreter().Interpret(@"
                #'std';
                var list = [ 10, 20, 'foo' ];
                list.add('bar');

                printf(
                    'Count: {0}, Contains foo: {1}',
                    list.count(),
                    list.contains('foo'));
                
                for (x in list)
                    print(x);
            ");
        }
    }
}
