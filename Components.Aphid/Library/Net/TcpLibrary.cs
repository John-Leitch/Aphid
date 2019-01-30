using Components.Aphid.Interpreter;
using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Net.Sockets;
using Components.Aphid.Parser;
using Components.Aphid.TypeSystem;

namespace Components.Aphid.Library.Net
{
    [AphidLibraryAttribute("tcp")]
    public static class TcpLibrary
    {
        private static Dictionary<NetworkStream, TcpClient> _clients = new Dictionary<NetworkStream, TcpClient>();

        [AphidInteropFunction("__tcp.connect")]
        public static NetworkStream TcpConnect(string host, decimal port)
        {
            var client = new TcpClient();
            client.Connect(host, (int)port);
            var stream = client.GetStream();

            lock (_clients)
            {
                _clients.Add(stream, client);
            }

            return stream;
        }

        [AphidInteropFunction("__tcp.close")]
        public static void TcpClose(NetworkStream stream)
        {
            lock (_clients)
            {
                stream.Close();
                var c = _clients[stream];
                c.Close();                
                _clients.Remove(stream);
            }
        }
    }
}

