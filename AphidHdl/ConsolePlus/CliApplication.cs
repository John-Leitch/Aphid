using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.ConsolePlus
{
    public abstract class CliApplication<TArgs>
        where TArgs : new()
    {
        private const string _defaultHeaderStyle = "~|Blue~~White~", 
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

        public string Name { get; private set; }

        public TArgs Arguments { get; private set; }

        public bool ShowHeader { get; set; }

        public string HeaderStyle { get; set; }

        public string ErrorHeaderStyle { get; set; }

        public bool IsProcessing { get; private set; }

        public CliApplication(string name)
        {
            Name = name;
            ShowHeader = true;
            HeaderStyle = _defaultHeaderStyle;
            ErrorHeaderStyle = _defaultErrorHeaderStyle;
        }

        public CliApplication()
            : this(GetDefaultName())
        {
        }

        private static string GetDefaultName()
        {
            var name = Assembly.GetEntryAssembly().GetName();

            return string.Format("{0} {1}", name.Name, name.Version);
        }

        public void Launch()
        {
            if (ShowHeader)
            {
                Cli.WriteHeader(Name, HeaderStyle);
                Cli.WriteLine();
            }

            if (Environment.GetCommandLineArgs().Length == 1)
            {
                CliArgWriter.WriteArguments<TArgs>();
                Environment.Exit(1);
            }

            var args = Environment.GetCommandLineArgs().Skip(1).ToArray();
            
            try
            {
                Arguments = new CliArgReader(args).Read<TArgs>();
            }
            catch (ArgumentException e)
            {
                WriteFatalError(0x1, e.Message);
            }

            Main(Arguments);
        }

        public void WriteFatalError(int errorCode, string format, params object[] arg)
        {
            if (IsProcessing)
            {
                Cli.WriteLine("\r\n");
            }

            Cli.WriteSubheader(_fatalError, ErrorHeaderStyle);
            Cli.WriteLine();
            Cli.WriteLine(format, arg);
            Environment.Exit(errorCode);
        }

        public void WriteMessage(ConsoleColor tokenColor, char token, string format, params object[] arg)
        {
            Cli.WriteLine(
                string.Format(_messageFormat, tokenColor, token, format),
                arg);
        }

        public void WriteInfoMessage(string format, params object[] arg)
        {
            WriteMessage(
                ConsoleColor.White,
                InfoChar,
                format,
                arg);
        }

        public void WriteQueryMessage(string format, params object[] arg)
        {
            WriteMessage(
                ConsoleColor.White,
                QueryChar,
                format,
                arg);
        }

        public void WriteSuccessMessage(string format, params object[] arg)
        {
            WriteMessage(
                ConsoleColor.Green,
                SuccessChar,
                format,
                arg);
        }

        public void WriteErrorMessage(string format, params object[] arg)
        {
            WriteMessage(
                ConsoleColor.Red,
                ErrorChar,
                format,
                arg);
        }

        public void WriteCriticalErrorMessage(string format, params object[] arg)
        {
            WriteMessage(
                ConsoleColor.Red,
                FatalErrorChar,
                format,
                arg);
        }

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
