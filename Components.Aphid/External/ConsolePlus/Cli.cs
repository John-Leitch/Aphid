//#define DEBUG_CONSOLE_OUT
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using Components.PInvoke;

namespace Components.External.ConsolePlus
{
    public static partial class Cli
    {
        public const int MessageCountStart = 0x10,
            //MaxMessageBufferLength = 0x1 << 0x1e;
            MaxMessageBufferLength = 0x1000;

        private const string _messageFormat = "[~{0}~{1}~R~] {2}",
            _nameHeader = "Name",
            _valueHeader = "Value";

        public const char QueryChar = '?',
          InfoChar = 'i',
          SuccessChar = '+',
          StringChar = 's',
          BinaryChar = 'b',
          ErrorChar = '-',
          FatalErrorChar = 'x';

        public const string DefaultHeaderStyle = "~|Blue~~White~";

        private static readonly int
            _maxNameLength = Environment.UserInteractive ? (int)Math.Floor(((double)BufferWidth - 3) / 2) : 100,
            _maxValueLength = Environment.UserInteractive ? (int)Math.Ceiling(((double)BufferWidth - 4) / 2) : 100;

        private static readonly object _syncObject = new object();

#if UNSAFE_CONSOLE
        private static object _messageSyncObject = new object();

        private static int _messageIndex;

        private static object[][] _argKeepAliveBuffer = new object[MessageCountStart][];

        private static CliWriteMessage[] _messageBuffer = new CliWriteMessage[MessageCountStart];

        private static Thread _cliThread;

        private static bool _isPumpRunning = true;
#endif

        private static bool _useTrace;

        public static bool UseTrace
        {
            get => _useTrace;
            set
            {
                _useTrace = value;

                if (value)
                {
                    WriteHandler = x => Trace.Write(x);
                    WriteLineHandler = x => Trace.WriteLine(x);
                }
                else
                {
                    WriteHandler = Console.Write;
                    WriteLineHandler = Console.WriteLine;
                }
            }
        }

        public static bool Async { get; set; }

        // Todo: some form of static analysis to validate console
        // buffer width/height are only accessed here due tothe 
        // exceptions they may cause when IO is redirected. Also 
        // wrap windo width/height.
        public static int BufferWidth
        {
            get
            {
                if (EnableUserBufferWidth)
                {
                    return UserBufferWidth;
                }

                try
                {
                    return Console.BufferWidth;
                }
                catch
                {
                    return 80;
                }
            }
        }

        public static int BufferHeight
        {
            get
            {
                if (EnableUserBufferHeight)
                {
                    return UserBufferHeight;
                }

                try
                {
                    return Console.BufferHeight;
                }
                catch
                {
                    return 40;
                }
            }
        }

        public static bool EnableUserBufferWidth { get; set; }

        public static int UserBufferWidth { get; set; } = BufferWidth;

        public static bool EnableUserBufferHeight { get; set; }

        public static int UserBufferHeight { get; set; } = BufferHeight;

        public static Action<string> WriteHandler { get; set; } =
            !Environment.UserInteractive ? x => { }
        : (Action<string>)Console.Write;

        public static Action<string> WriteLineHandler { get; set; } =
            !Environment.UserInteractive ? x => { }
        : (Action<string>)Console.WriteLine;

#if !LOW_SECURITY
        public static bool HasConsole =>
            Kernel32.GetConsoleWindow() != IntPtr.Zero;
#else
        public static bool HasConsole
        {
            get
            {
                try
                {
                    var x = Console.WindowWidth;
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
#endif

        /// <summary>
        /// Writes a format string to the console.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <param name="arg">The arguments.</param>
#if !DEBUG_CONSOLE_OUT
        [DebuggerStepThrough]
#endif
        public static void Write(string format, params object[] arg) => WriteCore(format, false, arg);

#if !DEBUG_CONSOLE_OUT
        [DebuggerStepThrough]
#endif
        public static void Write(string message) => WriteCore(message, false, null);

        /// <summary>
        /// Writes a format string and a new line to the console.
        /// </summary>
        /// <param name="format">The format string.</param>
        /// <param name="arg">The arguments.</param>
#if !DEBUG_CONSOLE_OUT
        [DebuggerStepThrough]
#endif
        public static void WriteLine(string format, params object[] arg) => WriteCore(format, true, arg);

#if !DEBUG_CONSOLE_OUT
        [DebuggerStepThrough]
#endif
        public static void WriteLine(string message) => WriteCore(message, true, null);

#if !DEBUG_CONSOLE_OUT
        [DebuggerStepThrough]
#endif
        public static void WriteLine() => WriteLineHandler("");

        public static void DumpTable(IEnumerable<KeyValuePair<string, string>> nameValuePairs)
        {
            if (!nameValuePairs.Any())
            {
                return;
            }

            const int paddingSize = 0;
            var longestNameLength = nameValuePairs.OrderByDescending(x => x.Key.Length).First().Key.Length;

            if (longestNameLength < _nameHeader.Length)
            {
                longestNameLength = _nameHeader.Length;
            }
            else if (longestNameLength > _maxNameLength)
            {
                longestNameLength = _maxNameLength;
            }

            var longestValueLength = nameValuePairs.OrderByDescending(x => x.Value.Length).First().Value.Length;

            if (longestValueLength < _valueHeader.Length)
            {
                longestValueLength = _valueHeader.Length;
            }
            else if (longestValueLength > _maxValueLength)
            {
                longestValueLength = _maxValueLength;

                if (longestNameLength < _maxNameLength)
                {
                    longestValueLength += _maxNameLength - longestNameLength;
                }
            }

            var padding = new string(' ', paddingSize);

            const string headerColor = "~White~~|DarkGray~";

            var totalLength = (paddingSize * 4) + 3 + longestNameLength + longestValueLength;

            //var newLine = totalLength == BufferWidth ? "" : "\r\n";
            const string newLine = "\r\n";

            string createRow(string name, string value, bool header)
            {
                if (name.Length > _maxNameLength)
                {
                    name = name.Remove(_maxNameLength - 3) + "~Yellow~...~R~";
                }

                if (value.Length > longestValueLength)
                {
                    value = value.Remove(longestValueLength - 3) + "~Yellow~...~R~";
                }

                var delim = "║" + (header ? headerColor : "") + padding;
                var reset = (header ? "~R~" : "");
                return delim + name.PadRight(longestNameLength + paddingSize) + reset +
                    delim + value.PadRight(longestValueLength + paddingSize) + reset + "║";
            }

            var divider = new string('═', totalLength - 2).ToCharArray();
            var verticalRuleOffset = longestNameLength + (paddingSize * 2);
            divider[verticalRuleOffset] = '╦';
            var hrTop = "╔" + new string(divider) + "╗";
            divider[verticalRuleOffset] = '╬';
            var hrMiddle = "╠" + new string(divider) + "╣";
            divider[verticalRuleOffset] = '╩';
            var hrBottom = "╚" + new string(divider) + "╝";

            var rows = nameValuePairs
                .Select(x => createRow(x.Key, x.Value, false))
                .Aggregate((x, y) => x + newLine + y);

            WriteLine(hrTop + newLine +
                createRow(_nameHeader, _valueHeader, true) + newLine +
                hrMiddle + newLine +
                rows + newLine +
                hrBottom);
        }

        private static void DumpDetails(IEnumerable<KeyValuePair<string, string>> nameValuePairs)
        {
            foreach (var nvp in nameValuePairs)
            {
                WriteLine(
                    "~{0}~~|{1}~{2}~R~\r\n{3}\r\n",
                    ConsoleColor.White,
                    ConsoleColor.Blue,
                    nvp.Key,
                    nvp.Value);
            }
        }

        public static IEnumerable<KeyValuePair<string, string>> CreateTable(object obj, bool escapeLines)
        {
            string tryGet(dynamic x)
            {
                try
                {
#if NET35
                    return (x.GetValue(obj, null) ?? "null").ToString();
#else
                    return (x.GetValue(obj) ?? "null").ToString();
#endif
                }
                catch (Exception e)
                {
                    return string.Format("Error getting value: {0}", e);
                }
            }
            var t = obj.GetType();
            return t
                .GetMembers(
                    BindingFlags.Public |
                    BindingFlags.Instance |
                    BindingFlags.Static |
                    BindingFlags.FlattenHierarchy)
                .Where(x =>
                    x.MemberType == MemberTypes.Field ||
                    x.MemberType == MemberTypes.Property)
                .Select(x => new KeyValuePair<string, string>(
                    x.Name,
                    escapeLines ?
                        tryGet(x).Replace("\r", "\\r").Replace("\n", "\\n") :
                        tryGet(x)
                ));
        }

        public static void Dump<T>(T obj, DumpMode mode)
        {
            var nvps = CreateTable(obj, mode == DumpMode.Table);

            if (mode == DumpMode.Table)
            {
                DumpTable(nvps);
            }
            else if (mode == DumpMode.Details)
            {
                DumpDetails(nvps);
            }
            else
            {
                throw new ArgumentException("Invalid mode.");
            }
        }

        public static void Dump<T>(T obj) => Dump(obj, DumpMode.Table);

#if NET35
        public static void WriteHeader(string format)
        {
            WriteHeader(format, "");
        }

        public static void WriteHeader(string format, string style)
#else
        public static void WriteHeader(string text, string style = DefaultHeaderStyle)
#endif
        {
            var divider = new string('═', BufferWidth - 3).ToCharArray();
            var hrTop = "╔" + new string(divider) + "╗\r\n";
            var hrMiddle = "║" + style + " " + text.PadRight(BufferWidth - 4).Replace("~", "~~") + "~R~║\r\n";
            var hrBottom = "╚" + new string(divider) + "╝\r\n";
            Write(hrTop + hrMiddle + hrBottom);
        }

        public static void WriteSubheader(string text, string style = DefaultHeaderStyle) => WriteLine(
                "{0}  {1}{2}{3}",
                style,
                Escape(text),
                new string(' ', BufferWidth - text.Length - 3),
                "~R~");

#if UNSAFE_CONSOLE
        private unsafe static void WriteCore(string format, bool newLine, params object[] arg)
        {
            if (Async)
            {
                while (true)
                {
                    lock (_messageSyncObject)
                    {
                        if (_cliThread == null)
                        {
                            AppDomain.CurrentDomain.ProcessExit +=
                                (o, e) => _isPumpRunning = false;

                            _cliThread = new Thread(RunMessagePumpLoop)
                            {
                                IsBackground = false,
                            };

                            _cliThread.Start();
                        }

                        if (_messageIndex < _messageBuffer.Length || GrowMessageBuffer())
                        {
                            _argKeepAliveBuffer[_messageIndex] = arg;
                            var tr = __makeref(arg);
                            var p = **(IntPtr**)(&tr);

                            _messageBuffer[_messageIndex++] = new CliWriteMessage
                            {
                                Format = format,
                                NewLine = newLine,
                                ArgsPointer = p,
                            };

                            return;
                        }
                    }

                    Thread.Sleep(1);
                }
            }
            else
            {
                WriteCoreWorker(format, newLine, arg);
            }
        }

        private static bool GrowMessageBuffer()
        {
            return false;

            if (_messageBuffer.Length == MaxMessageBufferLength)
            {
                return false;
            }
            else
            {
                var count = _messageBuffer.Length << 0x1;
                Array.Resize(ref _messageBuffer, count);
                Array.Resize(ref _argKeepAliveBuffer, count);

                return true;
            }
        }

        private static unsafe void RunMessagePumpLoop()
        {
            CliWriteMessage[] messages = default(CliWriteMessage[]);
            int count;
            var messages2 = stackalloc byte[0x4000];

            //// Todo: use fill patterns to detect value offsets in
            //// memory, detect new modules via checksum and update
            //// offsets appropriately.
            //for (var i = 0; i < 0x10; i++)
            //{
            //    messages2[i] = 0x52;
            //}

            while (_isPumpRunning)
            {
                Monitor.Enter(_messageSyncObject);

                if ((count = _messageIndex) <= 0)
                {
                    Monitor.Exit(_messageSyncObject);
                    Thread.Sleep(1);
                    continue;
                }
                else
                {
                    var padding = 0x10;
                    var len = (count * CliWriteMessage.Size) + padding;
                    var dst = (void*)messages2;
                    var r = __makeref(_messageBuffer);
                    var src = &((byte*)**(IntPtr**)(&r))[0];
                    Buffer.MemoryCopy(src, dst, len, len);
                    var r2 = __makeref(messages);
                    **(IntPtr**)(&r2) = (IntPtr)(&messages2[0]);
                    _messageIndex = 0;
                    Monitor.Exit(_messageSyncObject);
                }

                for (var i = 0; i < count; i++)
                {
                    var msg = messages[i];
                    var args = default(object[]);
                    var tr = __makeref(args);
                    **(IntPtr**)(&tr) = msg.ArgsPointer;
                    //args = __refvalue( tr, object[]);
                    WriteCoreWorker(msg.Format, msg.NewLine, args);
                }
            }
        }
#else
        private static void WriteCore(string format, bool newLine, params object[] arg)
        {
            if (Async)
            {
                ThreadPool.QueueUserWorkItem(x => WriteCoreWorker(format, newLine, arg));
            }
            else
            {
                WriteCoreWorker(format, newLine, arg);
            }
        }
#endif

        /// <summary>
        /// The core console write function.
        /// </summary>
        /// <param name="formatOrMsg">The format string.</param>
        /// <param name="newLine">Determines whether to print the message with a new line or not.</param>
        /// <param name="arg">The arguments.</param>
#if !DEBUG_CONSOLE_OUT
        [DebuggerStepThrough]
#endif
        private static void WriteCoreWorker(string formatOrMsg, bool newLine, params object[] arg)
        {
            lock (_syncObject)
            {
                var msg = arg != null ? string.Format(formatOrMsg, arg) : formatOrMsg;
                var state = CliLexerState.ReadingText;

                var buffer = new StringBuilder();

                for (var i = 0; i < msg.Length; i++)
                {
                    var c = msg[i];

                    if (state == CliLexerState.ReadingText)
                    {
                        if (c == '~')
                        {
                            state = CliLexerState.ReadingToken;

                            if (buffer.Length != 0)
                            {
                                WriteHandler(buffer.ToString());

#if NET35
                                buffer = new StringBuilder();
#else
                                buffer.Clear();
#endif
                            }

                            continue;
                        }
                    }
                    else if (state == CliLexerState.ReadingToken)
                    {
                        if (c == '~')
                        {
                            if (buffer.Length == 0)
                            {
                                buffer.Append('~');
                                state = CliLexerState.ReadingText;
                                continue;
                            }

                            var token = buffer.ToString();

#if NET35
                                buffer = new StringBuilder();
#else
                            buffer.Clear();
#endif

                            if (token == "R")
                            {
                                Console.ResetColor();
                            }
                            else
                            {
                                var isBackgroundColor = token[0] == '|';

                                var color = (ConsoleColor)Enum.Parse(
                                    typeof(ConsoleColor),
                                    isBackgroundColor ? token.Substring(1) : token);

                                if (isBackgroundColor)
                                {
                                    Console.BackgroundColor = color;
                                }
                                else
                                {
                                    Console.ForegroundColor = color;
                                }
                            }

                            state = CliLexerState.ReadingText;

                            continue;
                        }
                    }

                    buffer.Append(c);
                }

                if (state == CliLexerState.ReadingToken)
                {
                    throw new ArgumentException("Invalid token in format string");
                }

                if (newLine)
                {
                    WriteLineHandler(buffer.ToString());
                }
                else
                {
                    WriteHandler(buffer.ToString());
                }
            }
        }

        public static string Escape(string value) =>
            !string.IsNullOrEmpty(value) ?
                        //(VT100.IsEnabled ?
                        //    VT100.Escape(
                        //        value
                        //            .Replace("{", "{{")
                        //            .Replace("}", "}}")
                        //            .Replace("~", "~~")) :
                        value
                            .Replace("{", "{{")
                            .Replace("}", "}}")
                            .Replace("~", "~~")/*)*/ :
                value;

        public static string FormatEscape(string value) => value.Replace("{", "{{").Replace("}", "}}");

        public static string FormatEscape(object value) => FormatEscape(value.ToString());

        public static string StyleEscape(object value) => StyleEscape(value.ToString());

        public static string StyleEscape(string value) =>
            !string.IsNullOrEmpty(value) ? value.Replace("~", "~~") :
            //(VT100.IsEnabled ? VT100.Escape(value.Replace("~", "~~")) : value.Replace("~", "~~")) :
            value;

#if !DEBUG_CONSOLE_OUT
        [DebuggerStepThrough]
#endif
        public static string EraseStyles(string text)
        {
            var aggr = new StringBuilder();
            EraseStyles(text, aggr.Append);

            return aggr.ToString();
        }

#if !DEBUG_CONSOLE_OUT
        [DebuggerStepThrough]
#endif
        public static void EraseStyles(
            string text,
            Func<StringBuilder, StringBuilder> callback)
        {
            {
                var buffer = new StringBuilder();
                var state = CliLexerState.ReadingText;

                for (var i = 0; i < text.Length; i++)
                {
                    var c = text[i];

                    switch (state)
                    {
                        case CliLexerState.ReadingText:
                            if (c == '~')
                            {
                                state = CliLexerState.ReadingTokenBeginning;

                                if (buffer.Length != 0)
                                {
                                    callback(buffer);
                                    buffer = new StringBuilder();
                                }
                            }
                            else
                            {
                                buffer.Append(c);
                            }

                            break;

                        case CliLexerState.ReadingTokenBeginning:
                            if (c == '~')
                            {
                                buffer.Append('~');
                                state = CliLexerState.ReadingText;
                            }
                            else
                            {
                                state = CliLexerState.ReadingToken;
                            }

                            break;

                        case CliLexerState.ReadingToken:
                            if (c == '~')
                            {
                                state = CliLexerState.ReadingText;
                            }

                            break;

                        default:
                            throw new NotImplementedException();
                    }
                }

                if (state == CliLexerState.ReadingToken)
                {
                    throw new ArgumentException("Invalid token in format string");
                }

                if (buffer.Length != 0)
                {
                    callback(buffer);
                }
            }
        }

        public static void WriteMessage(ConsoleColor tokenColor, char token, string format, params object[] arg) => WriteLine(
                string.Format(_messageFormat, tokenColor, token, format),
                arg);

        public static void WriteInfoMessage(string format, params object[] arg) => WriteMessage(
                ConsoleColor.White,
                InfoChar,
                format,
                arg);

        public static void WriteQueryMessage(string format, params object[] arg) => WriteMessage(
                ConsoleColor.White,
                QueryChar,
                format,
                arg);

        public static void WriteSuccessMessage(string format, params object[] arg) => WriteMessage(
                ConsoleColor.Green,
                SuccessChar,
                format,
                arg);

        public static void WriteErrorMessage(string format, params object[] arg) => WriteMessage(
                ConsoleColor.Red,
                ErrorChar,
                format,
                arg);

        public static void WriteCriticalErrorMessage(string format, params object[] arg) => WriteMessage(
                ConsoleColor.Red,
                FatalErrorChar,
                format,
                arg);

        public static void Clear()
        {
            lock (_syncObject)
            {
                Console.Clear();
            }
        }

        public static void Lock(Action action)
        {
            lock (_syncObject)
            {
                action();
            }
        }
    }
}
