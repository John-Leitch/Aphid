using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Components.Cypress;

namespace Components.External.ConsolePlus
{
    public abstract class CliApplication<TArgs> : Singleton<CliApplication<TArgs>>
        where TArgs : class, new()
    {
        private const string
            _defaultErrorHeaderStyle = "~|Red~~White~",
            _fatalError = "Fatal Error",
            _messageFormat = "[~{0}~{1}~R~] {2}";

        public const char QueryChar = '?',
          InfoChar = 'i',
          SuccessChar = '+',
          StringChar = 's',
          BinaryChar = 'b',
          ErrorChar = '-',
          FatalErrorChar = 'x';

        public string Name { get; }

        public TArgs Arguments { get; private set; }

        public bool ShowHeader { get; set; }

        public string HeaderStyle { get; set; }

        public string ErrorHeaderStyle { get; set; }

        public bool IsProcessing { get; private set; }

        protected CliApplication(string name)
        {
            Name = name;
            ShowHeader = true;
            ErrorHeaderStyle = _defaultErrorHeaderStyle;
        }

        protected CliApplication()
            : this(null)
        {
        }

        public virtual void Launch()
        {
            CliApplication.SetTitle(Name, ShowHeader, HeaderStyle);
            var props = CliArgProperty.GetAll<TArgs>();

            if (Environment.GetCommandLineArgs().Length == 1 && props.Length > 0)
            {
                WriteDirections();
            }

            Arguments = SetArguments();

            if (Debugger.IsAttached)
            {
                Main(Arguments);
            }
            else
            {
                try
                {
                    AppDomain.CurrentDomain.UnhandledException += (o, e) =>
                        HandleUnexpectedException(e.ExceptionObject as Exception);

                    Main(Arguments);
                }
                catch (OutOfMemoryException e)
                {
                    HandleUnexpectedException(e);
                }
                catch (Exception e)
                {
                    HandleUnexpectedException(e);
                }
            }
        }

        protected virtual void WriteDirections()
        {
            CliArgWriter.WriteArguments<TArgs>();
            Environment.Exit(1);
        }

        public TArgs SetArguments() => Arguments ?? (Arguments = ParseArguments());

        protected virtual TArgs ParseArguments()
        {
            var args = Environment.GetCommandLineArgs().Skip(1).ToArray();

            try
            {
                return new CliArgReader(args).Read<TArgs>();
            }
            catch (ArgumentException e)
            {
                Cli.WriteLine();
                WriteFatalError(0x1, e.Message);

                return default;
            }
        }

        private void HandleUnexpectedException(Exception e)
        {
            try
            {
                var name = Name ?? Assembly.GetEntryAssembly().GetName().ToString();

                try
                {
                    var dmp = PathHelper.GetEntryPath($"{name}_{Guid.NewGuid().ToString()}.dmp");
                    MemoryDump.Create(dmp);
                }
                catch (Exception e2)
                {
                    Cli.WriteErrorMessage("Error creating dump: {0}", e2);
                }

                var msg = e != null ?
                    e.ToString() :
                    "Unknown exception";

                Console.WriteLine("Crash: {0}", msg);

                var logPath = PathHelper.GetExecutingPath(
                    string.Format(
                        "Crash.{0}.{1}.log",
                        name,
                        Guid.NewGuid()));

                File.WriteAllText(logPath, msg);

                Environment.Exit(0xbad);
            }
            catch (Exception e2)
            {
                Console.WriteLine("Failed logging crash:\r\n{0}", e2.ToString());
                Environment.Exit(0xbad1);
            }
        }

        public virtual void WriteFatalError(int errorCode, string format, params object[] arg)
        {
            if (IsProcessing)
            {
                Cli.WriteLine("\r\n");
            }

            Cli.WriteSubheader(_fatalError, ErrorHeaderStyle);
            Cli.WriteLine();
            Cli.WriteLine(format, arg);
            Cli.WriteLine();
            Environment.Exit(errorCode);
        }

        public virtual void WriteMessage(ConsoleColor tokenColor, char token, string format, params object[] arg) =>
            Cli.WriteLine(
                string.Format(_messageFormat, tokenColor, token, format),
                arg);

        public virtual void WriteInfoMessage(string format, params object[] arg) =>
            WriteMessage(
                ConsoleColor.White,
                InfoChar,
                format,
                arg);

        public virtual void WriteQueryMessage(string format, params object[] arg) =>
            WriteMessage(
                ConsoleColor.White,
                QueryChar,
                format,
                arg);

        public virtual void WriteSuccessMessage(string format, params object[] arg) =>
            WriteMessage(
                ConsoleColor.Green,
                SuccessChar,
                format,
                arg);

        public virtual void WriteErrorMessage(string format, params object[] arg) =>
            WriteMessage(
                ConsoleColor.Red,
                ErrorChar,
                format,
                arg);

        public virtual void WriteCriticalErrorMessage(string format, params object[] arg) =>
            WriteMessage(
                ConsoleColor.Red,
                FatalErrorChar,
                format,
                arg);

        public void Process<TElement>(IEnumerable<TElement> collection, Action<TElement> action)
        {
            IsProcessing = true;
            var progress = new CliProgressBar(collection.Count());
            progress.Write();

            foreach (var element in collection)
            {
                action(element);
                progress.IncrementAndWrite();
            }

            Cli.WriteLine();
            IsProcessing = false;
        }

        public abstract void Main(TArgs args);
    }
}
