using Components.Aphid.Interpreter;

namespace SeamlessInteropSample3
{
    class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new AphidInterpreter();

            interpreter.Interpret(@"
                load System.Web.Extensions;
                using System;
                using System.Web.Script.Serialization;
                serializer = new JavaScriptSerializer();
                
                obj = 
                    '{ ""x"":52, ""y"":30 }' 
                    |> serializer.DeserializeObject;
                
                Console.WriteLine(
                    'x={0}, y={1}',
                    obj.get_Item('x'),
                    obj.get_Item('y'));
            ");
        }
    }
}
