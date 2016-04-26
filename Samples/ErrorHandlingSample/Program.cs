using Components.Aphid.Interpreter;
using Components.Aphid.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = @"
                #'std';
                print('foo'bar');
            ";

            try
            {
                var interpreter = new AphidInterpreter();
                interpreter.Interpret(code);
            }
            catch (AphidParserException e)
            {
                var msg = ParserErrorMessage.Create(code, e);
                Console.WriteLine(msg);
            }
        }
    }
}
