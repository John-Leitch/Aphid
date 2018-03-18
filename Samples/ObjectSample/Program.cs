using Components.Aphid.Interpreter;
using Components.Aphid.TypeSystem;
using System;

namespace ObjectSample
{
    public class Point
    {
        [AphidProperty("x")]
        public int X { get; set; }

        [AphidProperty("y")]
        public int Y { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}", X, Y);
        }
    }

    public class Widget
    {
        [AphidProperty("name")]
        public string Name { get; set; }

        [AphidProperty("location")]
        public Point Location { get; set; }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Name, Location);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var interpreter = new AphidInterpreter();
            
            interpreter.Interpret(@"
                #'Std';
                ret {
                    name: 'My Widget',
                    location: { x: 10, y: 20 }
                };
            ");

            var widget = interpreter.GetReturnValue().ConvertTo<Widget>();
            Console.WriteLine(widget);
            widget.Location.X = 40;
            var aphidWidget = AphidObject.ConvertFrom(widget);
            interpreter.CurrentScope.Add("w", aphidWidget);
            interpreter.Interpret(@"printf('New X value: {0}', w.location.x);");
        }
    }
}
