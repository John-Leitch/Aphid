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

        public EventWaitHandle Handle { get; private set; }

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

        public CrossProcessLock(string name, bool initialState)
        {
            bool isHandleNew;

            Handle = new EventWaitHandle(
                initialState,
                EventResetMode.AutoReset,
                name,
                out isHandleNew);

            if (!isHandleNew)
            {
                Handle.WaitOne();
            }
        }

        public void Dispose()
        {
            Handle.Set();
            Handle.Dispose();
        }
    }
}
