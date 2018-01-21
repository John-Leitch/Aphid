using Components.Aphid.Interpreter;

namespace SeamlessInteropSample2
{
    class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new AphidInterpreter();

            interpreter.Interpret(@"
                using System;
                using System.Text;
                sb = new StringBuilder('Hello');
                sb.Append(' world');
                
                Console.WriteLine(
                    'Length={0}, Capacity={1}', 
                    [ sb.Length, sb.Capacity ]);

                sb |> Console.WriteLine;
            ");
        }
    }
}
