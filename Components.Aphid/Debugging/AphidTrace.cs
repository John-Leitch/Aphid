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
        private Stream _outputStream;

        private StreamWriter _writer;

        private bool _isDisposed;

        private AphidTraceSettings _settings = AphidTraceSettings.Default;

        public AphidTraceSettings Settings
        {
            get { return _settings; }
            set { _settings = value; }
        }

        public string Name { get; private set; }

        public string OutputFile { get; private set; }

        public bool IsOpened { get; private set; }

        public AphidTrace(string name, string outputFile, AphidInterpreter interpreter)
            : this(name, interpreter)
        {
            OutputFile = Path.GetFullPath(outputFile);
        }

        public AphidTrace(string name, Stream outputStream, AphidInterpreter interpreter)
            : this(name, interpreter)
        {
            _writer = new StreamWriter(_outputStream = outputStream);
            IsOpened = true;
        }

        private AphidTrace(string name, AphidInterpreter interpreter)
            : base(interpreter)
        {
            Name = name;
        }

        public void Open()
        {
            lock (this)
            {
                if (IsOpened)
                {
                    throw new InvalidOperationException("AphidTrace already opened.");
                }

                _outputStream = File.Open(
                    OutputFile,
                    FileMode.OpenOrCreate,
                    FileAccess.Write,
                    FileShare.ReadWrite);

                _writer = new StreamWriter(_outputStream);
                IsOpened = true;
            }
        }

        public void Trace(string format, params object[] args)
        {
            Trace(Settings.DefaultMessageTraceLevel, format, args);
        }

        public void Trace(string message)
        {
            Trace(Settings.DefaultMessageTraceLevel, message);
        }

        public void Trace(TraceLevel level, string format, params object[] args)
        {
            Trace(level, string.Format(format, args));
        }

        public void Trace(TraceLevel level, string message)
        {
            using (new CrossProcessLock(GetLockName()))
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

            if (_settings.TraceTimestamp)
            {
                _writer.Write(DateTime.Now.ToString(_settings.TimestampFormat + " "));
            }

            _writer.WriteLine(string.Format("{0} {1}: {2}\r\n", Name, level, message));

            if (_settings.TraceCurrentStatement)
            {
                _writer.Write("Current statement: ");

                _writer.WriteLine(
                    Interpreter.CurrentStatement != null ?
                    Interpreter.CurrentStatement.ToString() :
                    "[null]");

                _writer.WriteLine();
            }

            if (_settings.TraceCurrentExpression)
            {
                _writer.Write("Current expression: ");

                _writer.WriteLine(
                    Interpreter.CurrentExpression != null ?
                    Interpreter.CurrentExpression.ToString() :
                    "[null]");

                _writer.WriteLine();
            }

            if (_settings.TraceAphidStack)
            {
                var stack = ExceptionHelper.StackTrace(Interpreter.GetStackTrace());
                _writer.WriteLine("Aphid stack trace:\r\n" + stack);
                _writer.WriteLine();
            }

            if (_settings.TraceClrStack)
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

        private string GetLockName()
        {
            return string.Format(
                "AphidTraceLock.{0}",
                OutputFile != null ? OutputFile.Replace('\\', '$') : (Name + ":Stream"));
        }

        public void Dispose()
        {
            lock (this)
            {
                if (_isDisposed)
                {
                    throw new InvalidOperationException("AphidTrace already disposed.");
                }

                if (_outputStream != null)
                {
                    _outputStream.Dispose();
                    _outputStream = null;
                    _writer = null;
                }

                _isDisposed = true;
            }
        }
    }
}
