using System;

namespace Components.External.ConsolePlus
{
    public class ConsoleDataEventArgs : EventArgs
    {
        public string Data { get; }

        public ConsoleDataEventArgs(string data) => Data = data;
    }
}
