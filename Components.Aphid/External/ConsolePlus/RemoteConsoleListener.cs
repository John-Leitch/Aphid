using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Components.External.ConsolePlus
{
    [Serializable]
    public sealed class RemoteConsoleListener : MarshalByRefObject, IDisposable
    {
        private StringBuilder _outBuffer;

        private ConsoleTextWriter _writer;

        private TextWriter _originalOut, _originalError;

        public void SetOut()
        {
            Cli.Async = false;
            _originalOut = Console.Out;
            _originalError = Console.Error;
            _outBuffer = new StringBuilder();
            _writer = new ConsoleTextWriter();
            _writer.DataReceived += DataReceived;
            Cli.UseTrace = false;
            Cli.WriteHandler = Console.Write;
            Cli.WriteLineHandler = Console.WriteLine;
            Console.SetOut(_writer);
            Console.SetError(_writer);
        }

        void DataReceived(object sender, ConsoleDataEventArgs e)
        {
            lock (_outBuffer)
            {
                _outBuffer.Append(e.Data);
            }
        }

        public void Dispose()
        {
            Console.SetOut(_originalOut);
            Console.SetError(_originalError);
        }

        public string Flush()
        {
            lock (_outBuffer)
            {
                _writer.Flush();
                var s = _outBuffer.ToString();
                _outBuffer.Clear();

                return s;
            }
        }
    }
}
