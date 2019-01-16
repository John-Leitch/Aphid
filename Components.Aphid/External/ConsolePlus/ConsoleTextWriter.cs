using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.External.ConsolePlus
{
    public class ConsoleTextWriter : TextWriter
    {
        public event EventHandler<ConsoleDataEventArgs> DataReceived;

        public override Encoding Encoding => Console.OutputEncoding;

        public override void Write(char value) => InvokeEvent(value.ToString());

        public override void Write(string value) => InvokeEvent(value);

        public override void WriteLine(char value) => InvokeEvent(value + "\r\n");

        public override void WriteLine(string value) => InvokeEvent(value + "\r\n");

        private void InvokeEvent(string value) => DataReceived?.Invoke(this, new ConsoleDataEventArgs(value));
    }
}


