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

                void handleDupes(string sourceName, List<string> nameList)
                {
                    var dupes = nameList.Count(x => x == sourceName);

                    if (dupes != 0)
                    {
                        Cli.WriteErrorMessage($"                  ~Yellow~{sourceName} dupes~R~: {string.Join(", ", dupes)}");
                    }

                    nameList.Add(sourceName);
                }

                handleDupes(_name, _names);
                handleDupes(_name.Split('_').Skip(1).Aggregate((x, y) => x + '_' + y), _partialNames);
            }
#endif

            Handle = new EventWaitHandle(
                initialState,
                EventResetMode.AutoReset,
                name,
                out var isHandleNew);

            if (!isHandleNew)
            {
                Handle.WaitOne();
            }
        }

        public void Dispose()
        {
            Handle.Set();
            Handle.Dispose();

#if TRACE_CROSSPROCESS_LOCK
            lock (_nameDepths)
            {
                Cli.WriteMessage(
                    ConsoleColor.Yellow,
                    '<',
                    $"{UpdateDepth(_name, up: false)} Left    ~Cyan~{_name}~R~");
            }
#endif
        }
    }
}
