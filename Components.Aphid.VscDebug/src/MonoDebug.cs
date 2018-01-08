/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Linq;

namespace VSCodeDebug
{
    public class ConsoleDataEventArgs : EventArgs
    {
        public string Data { get; private set; }

        public ConsoleDataEventArgs(string data)
        {
            Data = data;
        }
    }

    public class ConsoleTextWriter : TextWriter
    {
        public event EventHandler<ConsoleDataEventArgs> DataReceived;

        public override Encoding Encoding
        {
            get { return Console.OutputEncoding; }

        }

        public override void Write(char value)
        {
            InvokeEvent(value.ToString());
        }

        public override void Write(string value)
        {
            InvokeEvent(value);
        }

        public override void WriteLine(char value)
        {
            InvokeEvent(value + "\r\n");
        }

        public override void WriteLine(string value)
        {
            InvokeEvent(value + "\r\n");
        }

        private void InvokeEvent(string value)
        {
            var d = DataReceived;

            if (d != null)
            {
                d(this, new ConsoleDataEventArgs(value));
            }
        }
    }

    internal class Program
	{
		const int DEFAULT_PORT = 4711;

		private static bool trace_requests;
		private static bool trace_responses;
		static string LOG_FILE_PATH = null;

		private static void Main(string[] argv)
		{
            //var w = new ConsoleTextWriter();
            //w.DataReceived += W_DataReceived;
            //Console.SetOut(w);
            //Console.Write(true);
            //Console.Write(0xdeadbeef);
            //Console.Write(100m);
            //Console.WriteLine("foo {0}", "bar");
            //Console.Write('A');
            //Console.WriteLine('B');
            //Console.WriteLine("no parms");
            //Console.WriteLine("foo {0} {1} {2} {3}", 1, 2, 3, 4);
            //Environment.Exit(0);
			int port = -1;

			// parse command line arguments
			foreach (var a in argv) {
				switch (a) {
				case "--trace":
					trace_requests = true;
					break;
				case "--trace=response":
					trace_requests = true;
					trace_responses = true;
					break;
				case "--server":
					port = DEFAULT_PORT;
					break;
				default:
					if (a.StartsWith("--server=")) {
						if (!int.TryParse(a.Substring("--server=".Length), out port)) {
							port = DEFAULT_PORT;
						}
					}
					else if( a.StartsWith("--log-file=")) {
						LOG_FILE_PATH = a.Substring("--log-file=".Length);
					}
					break;
				}
			}

			if (string.IsNullOrEmpty(Environment.GetEnvironmentVariable("mono_debug_logfile")) == false) {
				LOG_FILE_PATH = Environment.GetEnvironmentVariable("mono_debug_logfile");
				trace_requests = true;
				trace_responses = true;
			}

			if (port > 0) {
				// TCP/IP server
				Program.Log("waiting for debug protocol on port " + port + "\r\n");
				RunServer(port);
			} else {
				// stdin/stdout
				Program.Log("waiting for debug protocol on stdin/stdout\r\n");
				RunSession(Console.OpenStandardInput(), Console.OpenStandardOutput());
			}
		}

        static TextWriter logFile;

		public static void Log(bool predicate, string format, params object[] data)
		{
			if (predicate)
			{
				Log(format, data);
			}
		}

        private static int LogId = 0;
		
		public static void Log(string format, params object[] data)
		{
			try
			{
                

                lock (Console.Error)
                {
                    var stackTrace = new StackTrace();
                    var fullStack = stackTrace.GetFrames().Select(x => x.ToString()).Aggregate((x, y) => x + "\r\n" + y);
                    //fullStack = "";
                    Console.Error.Write(
                        string.Format("[{0:x4}, {1:x8}]", LogId++, System.Threading.Thread.CurrentThread.ManagedThreadId) +
                        format +
                        //"\n\n" + fullStack +
                        "\n"
                        ,
                        data);
                    Console.Error.WriteLine(" \n");
                }

                if (LOG_FILE_PATH != null)
				{
					//if (logFile == null)
					//{
					//	logFile = File.CreateText(LOG_FILE_PATH);
					//}

					//string msg = string.Format(format, data);
					//logFile.WriteLine(string.Format("{0} {1}", DateTime.UtcNow.ToLongTimeString(), msg));
				}
			}
			catch (Exception ex)
			{
				if (LOG_FILE_PATH != null)
				{
					try
					{
						//File.WriteAllText(LOG_FILE_PATH + ".err", ex.ToString());
					}
					catch
					{
					}
				}

				throw;
			}
		}

		private static void RunSession(Stream inputStream, Stream outputStream)
		{
            Log("[s] Begin debug session");
			DebugSession debugSession = new MonoDebugSession();
			debugSession.TRACE = trace_requests;
			debugSession.TRACE_RESPONSE = trace_responses;
			debugSession.Start(inputStream, outputStream).Wait();

			if (logFile!=null)
			{
				logFile.Flush();
				logFile.Close();
				logFile = null;
			}
		}

		private static void RunServer(int port)
		{
			TcpListener serverSocket = new TcpListener(IPAddress.Parse("127.0.0.1"), port);
			serverSocket.Start();

			new System.Threading.Thread(() => {
				while (true) {
					var clientSocket = serverSocket.AcceptSocket();
					if (clientSocket != null) {
						Program.Log(">> accepted connection from client\r\n");

						new System.Threading.Thread(() => {
							using (var networkStream = new NetworkStream(clientSocket)) {
								try {
									RunSession(networkStream, networkStream);
								}
								catch (Exception e) {
                                    Program.Log("[E] " + e);
									Console.Error.WriteLine("Exception: " + e);
								}
							}
							clientSocket.Close();
							Console.Error.WriteLine(">> client connection closed");
						}).Start();
					}
				}
			}).Start();
		}
	}
}
