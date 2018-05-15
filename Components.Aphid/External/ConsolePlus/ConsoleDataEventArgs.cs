using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.External.ConsolePlus
{
    public class ConsoleDataEventArgs : EventArgs
    {
        public string Data { get; private set; }

        public ConsoleDataEventArgs(string data)
        {
            Data = data;
        }
    }
}
