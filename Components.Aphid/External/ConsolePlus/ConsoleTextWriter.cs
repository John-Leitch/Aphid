using System;
using System.IO;
using System.Text;

namespace Components.External.ConsolePlus
{
    public class ConsoleTextWriter : TextWriter
    {
        public event EventHandler<ConsoleDataEventArgs> DataReceived;

        public override Encoding Encoding => Console.OutputEncoding;

        public override void Write(char value) => InvokeEvent(value.ToString());

        public override void Write(string value) => InvokeEvent(value);

        public override void WriteLine(char value) => InvokeEvent(value.ToString() + Environment.NewLine);

        public override void WriteLine(string value) => InvokeEvent(value + Environment.NewLine);

        private void InvokeEvent(string value) => DataReceived?.Invoke(this, new ConsoleDataEventArgs(value));
    }
}


