using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Components.External.ConsolePlus
{
    public abstract class CliApplication<TArgs> : Singleton<CliApplication<TArgs>>
        where TArgs : class, new()
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
            var asm = Assembly.GetEntryAssembly();
            var name = asm.GetName();
            var baseName = $"{name.Name} {name.Version}";

            DateTime linkTime;

            return (linkTime = asm.GetLinkTimeUtc()) == default ?
                baseName :
                $"{baseName} {linkTime.ToEasternStandardTime()} EST";
        }

        public virtual void Launch()
        {
            var n = Name;

            if (Debugger.IsAttached)
            {
                n += " (under debugger)";
            }

            Console.Title = n;

            if (ShowHeader)
            {
                Cli.WriteHeader(n, HeaderStyle);
                Cli.WriteLine();
            }

            var props = CliArgProperty.GetAll<TArgs>();

            if (Environment.GetCommandLineArgs().Length == 1 && props.Any())
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

        public TArgs SetArguments()
        {
            return Arguments ?? (Arguments = ParseArguments());
        }

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

                return default(TArgs);
            }
        }

        private void HandleUnexpectedException(Exception e)
        {
            try
            {
                string msg = e != null ?
                    e.ToString() :
                    "Unknown exception";

                Console.WriteLine("Crash: {0}", msg);

                var logPath = PathHelper.GetExecutingPath(
                    string.Format("Crash.{0}.{1}.log", Name, Guid.NewGuid()));

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

        public virtual void WriteMessage(ConsoleColor tokenColor, char token, string format, params object[] arg)
        {
            Cli.WriteLine(
                string.Format(_messageFormat, tokenColor, token, format),
                arg);
        }

        public virtual void WriteInfoMessage(string format, params object[] arg)
        {
            WriteMessage(
                ConsoleColor.White,
                InfoChar,
                format,
                arg);
        }

        public virtual void WriteQueryMessage(string format, params object[] arg)
        {
            WriteMessage(
                ConsoleColor.White,
                QueryChar,
                format,
                arg);
        }

        public virtual void WriteSuccessMessage(string format, params object[] arg)
        {
            WriteMessage(
                ConsoleColor.Green,
                SuccessChar,
                format,
                arg);
        }

        public virtual void WriteErrorMessage(string format, params object[] arg)
        {
            WriteMessage(
                ConsoleColor.Red,
                ErrorChar,
                format,
                arg);
        }

        public virtual void WriteCriticalErrorMessage(string format, params object[] arg)
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

    public abstract class CliApplication<TArgs, TConfig> : CliApplication<TArgs>
        where TArgs : class, new()
        where TConfig : new()
    {
        public TConfig Config { get; private set; }

        public override void Launch()
        {
            var asmPath = Assembly.GetEntryAssembly().Location;
            var name = Path.GetFileNameWithoutExtension(asmPath);

            using (var s = File.OpenRead(PathHelper.GetExecutingPath(name + ".xml")))
            {
                Config = XmlObject.Deserialize<TConfig>(s);
            }

            base.Launch();
        }
    }
}
