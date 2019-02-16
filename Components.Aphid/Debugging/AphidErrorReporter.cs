using Components.Aphid.Interpreter;
using Components.Aphid.Serialization;
using Components.Aphid.UI;
using Components.External.ConsolePlus;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Debugging
{
    public static class AphidErrorReporter
    {
        private static readonly object _sync = new object();

        private static bool _isEnabledSet;

        private static bool _isEnabled;

        public static bool IsEnabled
        {
            get
            {
                lock (_sync)
                {
                    if (!_isEnabledSet)
                    {
                        _isEnabled = AphidConfig.Current.SaveErrors;
                        _isEnabledSet = true;
                    }
                }

                return _isEnabled;
            }
        }

        public static bool IsInitialized { get; private set; }

        public static void Init()
        {
            lock (_sync)
            {
                if (!IsInitialized)
                {
                    if (IsEnabled)
                    {
                        AppDomain.CurrentDomain.UnhandledException += (o, e) =>
                            Report((Exception)e.ExceptionObject);

                        TaskScheduler.UnobservedTaskException += (o, e) =>
                            Report(e.Exception);
                    }

                    IsInitialized = true;
                }
            }
        }

        public static void Report(Exception o) => Report(o, null);

        public static void Report(Exception o, AphidInterpreter interpreter)
        {
            lock (_sync)
            {
                if (IsEnabled)
                {
                    SaveException(o, interpreter);
                }
            }
        }

        public static void SaveException(Exception o) => SaveException(o, null);

        public static void SaveException(Exception exception, AphidInterpreter interpreter) =>
            SaveException(exception, interpreter, exit: true);

        public static void SaveException(Exception exception, AphidInterpreter interpreter, bool exit)
        {
            var dumpFile = AphidMemoryDump.Create();

            if (exception is AggregateException ae)
            {
                new[] { ae }.Concat(ae.InnerExceptions).For((e, i) => SaveExceptionLogs(e, interpreter, i, dumpFile));
            }
            else
            {
                SaveExceptionLogs(exception, interpreter, -1, dumpFile);
            }

            if (exit)
            {
                Environment.Exit(0xbad02);
            }
        }

        private static void SaveExceptionLogs(Exception exception, AphidInterpreter interpreter, int number, string dumpFile)
        {
            var tag = number >= 0 ? $"{number}." : "";
            AphidRuntimeException are;
            AphidInterpreter exInterpreter = null;

            var sb = new StringBuilder();
            var writeOut = AphidCli.WriteOut;
            var writeLineOut = AphidCli.WriteLineOut;

            AphidCli.WriteOut = x =>
            {
                sb.Append(Cli.EraseStyles(x));
                writeOut(x);
            };

            AphidCli.WriteLineOut = x =>
            {
                sb.AppendLine(Cli.EraseStyles(x));
                writeLineOut(x);
            };

            if (exception is AphidLoadScriptException ale)
            {
                exInterpreter = ale.Interpreter;
                AphidCli.DumpException(ale, ale.Interpreter);
            }
            else if ((are = exception as AphidRuntimeException) != null)
            {
                exInterpreter = are.Interpreter;
                AphidCli.DumpException(are, are.Interpreter);
            }
            else
            {
                AphidCli.DumpException(exception, null);
            }

            var i = exInterpreter ?? interpreter;

            if (dumpFile != null && i != null)
            {
                File.WriteAllText(
                    Path.ChangeExtension(dumpFile, $"{tag}alxd"),
                    new AphidSerializer(i).Serialize(i.CurrentScope));
            }

            if (dumpFile != null)
            {
                var logFile = Path.ChangeExtension(dumpFile, $"{tag}log");

                using (var writer = new StreamWriter(File.Create(logFile)))
                {
                    writer.AutoFlush = true;
                    writer.WriteLine(sb.ToString().Trim());
                    writer.WriteLine();

                    void writeValue(string name, Func<object> getValue) =>
                        TryWriteValue(writer, name, getValue);

                    writeValue("Command Line", () => Environment.CommandLine);

                    writeValue(
                        "Command Line Arguments",
                        () => Environment.GetCommandLineArgs().JoinLines());

                    writeValue("Current Directory", () => Environment.CurrentDirectory);

                    writeValue("Machine Name", () => Environment.MachineName);
                    writeValue("OS Version", () => Environment.OSVersion);
                    writeValue("64-bit OS", () => Environment.Is64BitOperatingSystem);
                    writeValue("64-bit Process", () => Environment.Is64BitProcess);
                    writeValue("CLR Version", () => Environment.Version);
                    writeValue("Processor Count", () => Environment.ProcessorCount);
                    writeValue("User", () => Environment.UserName);
                    writeValue("Domain", () => Environment.UserDomainName);

                    writeValue(
                        "Environment Variables",
                        () => Environment
                            .GetEnvironmentVariables()
                            .Cast<DictionaryEntry>()
                            .Select(x => string.Format("{0}: {1}", x.Key, x.Value))
                            .JoinLines());

                    writeValue(
                        "Assemblies",
                        () => AppDomain.CurrentDomain
                            .GetAssemblies()
                            .Select(x => string.Format(
                                "{0}\r\n{1}",
                                x,
                                !x.IsDynamic ? x.Location : "Dynamic Assembly"))
                            .JoinLines());

                    WalkExceptions(exception, writer);
                }
            }
        }

        private static void TryWriteValue(
            StreamWriter writer,
            string name,
            Func<object> getValue)
        {
            DebugTry(
                writer,
                () => writer.WriteLine("{0}:\r\n{1}\r\n", name, getValue() ?? "null"));
        }

        private static void WalkExceptions(Exception rootException, StreamWriter writer)
        {
            var exceptionHistory = new List<Exception>();
            var exceptionQueue = new Queue<Exception>(new[] { rootException });

            while (exceptionQueue.Count > 0)
            {
                var ex = exceptionQueue.Dequeue();
                writer.WriteLine("{0}\r\n", ex);

                DebugTry(
                    writer,
                    () => FindExceptionProperties(
                        ex,
                        exceptionHistory,
                        exceptionQueue));
            }
        }

        private static void FindExceptionProperties(
            Exception node,
            List<Exception> exceptionHistory,
            Queue<Exception> exceptionQueue)
        {
            var nestedExceptions = node
                .GetType()
                .GetProperties()
                .SelectMany(x =>
                {
                    var nested = new List<Exception>();

                    DebugTry(() =>
                    {
                        if (typeof(Exception)
                            .IsAssignableFrom(x.PropertyType))
                        {
                            if (x.GetValue(node) is Exception n && !exceptionHistory.Contains(n))
                            {
                                nested.Add(n);
                            }
                        }
                        else if (typeof(IEnumerable<Exception>)
                            .IsAssignableFrom(x.PropertyType))
                        {
                            if (x.GetValue(node) is IEnumerable<Exception> n)
                            {
                                nested.AddRange(n.Where(y => !exceptionHistory.Contains(y)));
                            }
                        }
                    });

                    return nested;
                })
                .ToArray();

            foreach (var n in nestedExceptions)
            {
                exceptionQueue.Enqueue(n);
            }
        }

        private static void DebugTry(Action action)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Error logging value: {0}", e);
            }
        }

        private static void DebugTry(StreamWriter writer, Action action)
        {
            DebugTry(() =>
            {
                try
                {
                    action();
                }
                catch (Exception e)
                {
                    writer.WriteLine("Error logging value: {0}", e);
                }
            });
        }
    }
}
