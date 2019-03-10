using Components.Aphid.Interpreter;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Debugging
{
    public sealed class AphidTrace : AphidRuntimeComponent, IDisposable
    {
        private bool _isDisposed;

        private Stream _stream;

        private StreamWriter _writer;

        private readonly object _sync = new object();

        public AphidTraceSettings Settings { get; set; } = AphidTraceSettings.Default;

        public string Name { get; }

        public string OutputFile { get; }

        public bool IsOpened { get; private set; }

        public bool MultiprocessSafe { get; set; }

        public bool ThreadSafe { get; set; }

        public AphidTrace(string name, string outputFile, AphidInterpreter interpreter)
            : this(name, interpreter) => OutputFile = Path.GetFullPath(outputFile);

        public AphidTrace(string name, Stream outputStream, AphidInterpreter interpreter)
            : this(name, interpreter)
        {
            _writer = new StreamWriter(_stream = outputStream);
            IsOpened = true;
        }

        private AphidTrace(string name, AphidInterpreter interpreter)
            : base(interpreter)
        {
            ThreadSafe = true;
            Name = name;
        }

        public void Open()
        {
            lock (_sync)
            {
                if (IsOpened)
                {
                    throw new InvalidOperationException("AphidTrace already opened.");
                }

                _stream = File.Open(
                    OutputFile,
                    FileMode.OpenOrCreate,
                    FileAccess.Write,
                    FileShare.ReadWrite);

                _writer = new StreamWriter(_stream);
                IsOpened = true;
            }
        }

        public void Trace(string format, params object[] args) =>
            Trace(Settings.DefaultMessageTraceLevel, format, args);

        public void Trace(string message) =>
            Trace(Settings.DefaultMessageTraceLevel, message);

        public void Trace(TraceLevel level, string format, params object[] args) =>
            Trace(level, string.Format(format, args));

        public void Trace(TraceLevel level, string message)
        {
            if (MultiprocessSafe)
            {
                using (new CrossProcessLock(GetLockName()))
                {
                    TraceUnsafe(level, message);
                }
            }
            else if (ThreadSafe)
            {
                lock(_sync)
                {
                    TraceUnsafe(level, message);
                }
            }
            else
            {
                TraceUnsafe(level, message);
            }
        }

        public void TraceUnsafe(TraceLevel level, string message)
        {
            if (!IsOpened)
            {
                throw new InvalidOperationException("AphidTrace is not open.");
            }

            if (Settings.TraceTimestamp)
            {
                _writer.Write(DateTime.Now.ToString(Settings.TimestampFormat + " "));
            }

            _writer.WriteLine(string.Format("{0} {1}: {2}\r\n", Name, level, message));

            if (Settings.TraceCurrentStatement)
            {
                _writer.Write("Current statement: ");

                _writer.WriteLine(
                    Interpreter.CurrentStatement != null ?
                    Interpreter.CurrentStatement.ToString() :
                    "[null]");

                _writer.WriteLine();
            }

            if (Settings.TraceCurrentExpression)
            {
                _writer.Write("Current expression: ");

                _writer.WriteLine(
                    Interpreter.CurrentExpression != null ?
                    Interpreter.CurrentExpression.ToString() :
                    "[null]");

                _writer.WriteLine();
            }

            if (Settings.TraceAphidStack)
            {
                var stack = ExceptionHelper.StackTrace(Interpreter.GetStackTrace());
                _writer.WriteLine("Aphid stack trace:\r\n" + stack);
                _writer.WriteLine();
            }

            if (Settings.TraceClrStack)
            {
                _writer.WriteLine("CLR stack trace:\r\n" +
                    new StackTrace()
                        .GetFrames()
                        .Select(x => x.ToString())
                        .Join());

                _writer.WriteLine();
            }

            _writer.Flush();
        }

        public void TraceText(string format, params object[] args) =>
            TraceText(string.Format(format, args));

        public void TraceText(string message)
        {
            if (MultiprocessSafe)
            {
                using (new CrossProcessLock(GetLockName()))
                {
                    TraceTextUnsafe(message);
                }
            }
            else if (ThreadSafe)
            {
                lock(_sync)
                {
                    TraceTextUnsafe(message);
                }
            }
            else
            {
                TraceTextUnsafe(message);
            }
        }

        private void TraceTextUnsafe(string message) => _writer.Write(message);

        private string GetLockName()
        {
            return string.Format(
                "AphidTraceLock.{0}",
                OutputFile != null ? OutputFile.Replace('\\', '$') : (Name + ":Stream"));
        }

        public void Dispose()
        {
            lock (_sync)
            {
                if (_isDisposed)
                {
                    throw new InvalidOperationException("AphidTrace already disposed.");
                }

                if (_stream != null)
                {
                    _stream.Dispose();
                    _stream = null;
                    _writer = null;
                }

                _isDisposed = true;
            }
        }

        public void Flush() => _stream.Flush();
    }
}
