#if CHECKED
#define TRACE_CROSSPROCESS_LOCK
#endif
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Components
{
    public sealed class CrossProcessLock : IDisposable
    {
        public const string DefaultName = "Components.CrossProcessLock";

        public const bool DefaultInitialState = false;

#if TRACE_CROSSPROCESS_LOCK
        private string _name;

        private static int _depth;

        private static Dictionary<string, int> _nameDepths = new Dictionary<string, int>();

        private static List<string> _names = new List<string>();

        private static List<string> _partialNames = new List<string>();
#endif

        private static ArgLockingMemoizer<string, EventWaitHandle> _handleMemoizer = new ArgLockingMemoizer<string, EventWaitHandle>();

        public EventWaitHandle Handle { get; }

        public CrossProcessLock()
            : this(DefaultInitialState)
        {
        }

        public CrossProcessLock(string name)
            : this(name, DefaultInitialState)
        {
        }

        public CrossProcessLock(bool initialState)
            : this(DefaultName, initialState)
        {
        }

#if TRACE_CROSSPROCESS_LOCK
        private string UpdateDepth(string name, bool up) =>
            string.Format(
                "{0:x4} {1:x4}",
                up ? _depth++ : --_depth,
                up ? _nameDepths[name]++ : --_nameDepths[name]);
#endif

        public CrossProcessLock(string name, bool initialState)
        {
#if TRACE_CROSSPROCESS_LOCK
            lock (_nameDepths)
            {
                if (!_nameDepths.ContainsKey(name))
                {
                    _nameDepths.Add(name, 0);
                }

                Cli.WriteMessage(
                    ConsoleColor.Green,
                    '>',
                    $"{UpdateDepth(name, up: true)} Entered ~Cyan~{_name = name}~R~");

                void handleDupes(string sourceName)
                {
                    var dupes = _names.Count(x => x == sourceName);

                    if (dupes != 0)
                    {
                        Cli.WriteErrorMessage(
                            "                  " +
                            $"~Yellow~{sourceName} dupes~R~: {string.Join(", ", dupes)}");
                    }

                    _names.Add(sourceName);
                }

                handleDupes(_name);
                //handleDupes(_name.Split('_').Skip(1).Aggregate((x, y) => x + '_' + y), _partialNames);
            }
#endif
            bool isHandleNew = false;

            EventWaitHandle createHandle(string innerName) => new EventWaitHandle(
                initialState,
                EventResetMode.AutoReset,
                innerName,
                out isHandleNew);

            Handle = _handleMemoizer.Call(createHandle, name);

            if (!isHandleNew)
            {
                Handle.WaitOne();
            }
        }

        public void Dispose()
        {
            Handle.Set();
            //Handle.Dispose();

#if TRACE_CROSSPROCESS_LOCK
            lock (_nameDepths)
            {
                _names.Remove(_name);

                Cli.WriteMessage(
                    ConsoleColor.Yellow,
                    '<',
                    $"{UpdateDepth(_name, up: false)} Left    ~Cyan~{_name}~R~");
            }
#endif
        }
    }
}
