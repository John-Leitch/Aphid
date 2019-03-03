/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See License.txt in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
//#define LOG_JSON
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using Components.External.ConsolePlus;
using System.Runtime.InteropServices;
using Components.PInvoke;
using System.IO.Pipes;
using Components.Aphid.UI;
using Components.Aphid.Parser;
using Components.Aphid.Interpreter;
using Components;

namespace VSCodeDebug
{
    internal class Program
	{
		const int DEFAULT_PORT = 4711;

		private static bool trace_requests;
		private static bool trace_responses;
		static string LOG_FILE_PATH = null;

        private static string GetNamedPort(string guid, bool stdOut)
        {
            return string.Format("AphidDebug_{0}_{1}", guid, stdOut ? "StdOut" : " StdIn");
        }

		private static void Main(string[] argv)
		{
            string id;

            if (!argv.Contains("--child"))
            {
#if LOG_JSON
                var file = File.Create("d:\\staging\\vscJson.log");
                var writer = new StreamWriter(file);
#endif
                id = Guid.NewGuid().ToString();

                var proc = Process.Start(
                    typeof(Program).Assembly.Location,
                    string.Format("--child {0}", id));

                var t = new System.Threading.Thread(() =>
                {
                    var stdOutPipe = new NamedPipeClientStream(GetNamedPort(id, true));
                    stdOutPipe.Connect();
                    var stdOut = Console.OpenStandardOutput();
                    var buffer = new byte[0x1000];
                    int read;

                    while (!proc.HasExited && stdOutPipe.IsConnected)
                    {
                        if ((read = stdOutPipe.Read(buffer, 0, buffer.Length)) > 0)
                        {
#if LOG_JSON
                            if (read > 0)
                            {
                                using (new CrossProcessLock("AphidVSCDebug"))
                                {
                                    writer.WriteLine("STD Out");
                                    file.Write(buffer, 0, read);
                                    writer.WriteLine();
                                }
                            }
#endif
                            stdOut.Write(buffer, 0, read);
                            stdOut.Flush();
                        }
                    }
                });

                t.Start();

                var t2 = new System.Threading.Thread(() =>
                {
                    var stdInPipe = new NamedPipeClientStream(GetNamedPort(id, false));
                    stdInPipe.Connect();
                    var stdIn = Console.OpenStandardInput();
                    var buffer = new byte[0x1000];
                    int read;

                    while (!proc.HasExited && stdInPipe.IsConnected)
                    {
                        if ((read = stdIn.Read(buffer, 0, buffer.Length)) > 0)
                        {
#if LOG_JSON
                            if (read > 0)
                            {
                                using (new CrossProcessLock("AphidVSCDebug"))
                                {
                                    writer.WriteLine("STD In");
                                    file.Write(buffer, 0, read);
                                    writer.WriteLine();
                                }
                            }
#endif

                            stdInPipe.Write(buffer, 0, read);
                            stdInPipe.Flush();
                        }
                    }
                });

                t2.Start();

                foreach (var x in new[] { t, t2 })
                {
                    x.Join();
                }
            }
            else
            {
                if (!Debugger.IsAttached)
                {
                    try
                    {
                        try
                        {
                            StartServer(argv);
                        }
                        catch (AphidLoadScriptException e)
                        {
                            AphidCli.DumpException(e, e.Interpreter);
                        }
                        catch (AphidParserException e)
                        {
                            AphidCli.DumpException(e, null);
                        }
                        catch (AphidRuntimeException e)
                        {
                            AphidCli.DumpException(e, e.Interpreter);
                        }
                    }
                    catch (Exception e2)
                    {
                        Cli.WriteErrorMessage("Internal exception: {0}", e2);
                    }

                    Console.WriteLine("Press enter to continue...");

                    while (Console.ReadKey(true).Key != ConsoleKey.Enter)
                    {
                    }
                }
                else
                {
                    StartServer(argv);
                }
            }
		}

        static void StartServer(string[] argv)
        {
            var id = argv[1];

            var stdOutPipeServer = new NamedPipeServerStream(
                    GetNamedPort(id, true));

            var stdInPipeServer = new NamedPipeServerStream(
                GetNamedPort(id, false));


            //Cli.WriteInfoMessage("Waiting for stdin pipe");
            stdInPipeServer.WaitForConnection();
            //Cli.WriteSuccessMessage("Connected");
            //Cli.WriteInfoMessage("Waiting for stdout pipe");
            stdOutPipeServer.WaitForConnection();
            //Cli.WriteSuccessMessage("Connected");

            var port = -1;

            // parse command line arguments
            foreach (var a in argv)
            {
                switch (a)
                {
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
                        if (a.StartsWith("--server="))
                        {
                            if (!int.TryParse(a.Substring("--server=".Length), out port))
                            {
                                port = DEFAULT_PORT;
                            }
                        }
                        else if (a.StartsWith("--log-file="))
                        {
                            LOG_FILE_PATH = a.Substring("--log-file=".Length);
                        }
                        break;
                }
            }

            if (string.IsNullOrEmpty(Environment.GetEnvironmentVariable("mono_debug_logfile")) == false)
            {
                LOG_FILE_PATH = Environment.GetEnvironmentVariable("mono_debug_logfile");
                trace_requests = true;
                trace_responses = true;
            }

            if (port > 0)
            {
                // TCP/IP server
                Program.Log("waiting for debug protocol on port " + port + "\r\n");
                RunServer(port);
            }
            else
            {
                // stdin/stdout
                Program.Log("waiting for debug protocol on stdin/stdout\r\n");
                RunSession(stdInPipeServer, stdOutPipeServer);
                //RunSession(Console.OpenStandardInput(), Console.OpenStandardOutput());

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

        public static bool EnableLogging = false;
		
		public static void Log(string format, params object[] data)
		{
            if (!EnableLogging)
            {
                return;
            }

            try
			{
                

                lock (Console.Error)
                {
                    var stackTrace = new StackTrace();
                    var fullStack = stackTrace.GetFrames().Select(x => x.ToString()).Aggregate((x, y) => x + "\r\n" + y);
                    //fullStack = "";
                    Console.Error.WriteLine(
                        string.Format("[{0:x4}, {1:x8}]", LogId++, System.Threading.Thread.CurrentThread.ManagedThreadId) +
                        format,
                        data);
                    //Console.Error.WriteLine(" \n");
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
			DebugSession debugSession = new AphidDebugSession();
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
			var serverSocket = new TcpListener(IPAddress.Parse("127.0.0.1"), port);
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
