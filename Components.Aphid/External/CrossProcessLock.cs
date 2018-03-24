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
        public EventWaitHandle Handle { get; private set; }

        public CrossProcessLock(string name)
        {
            bool isHandleNew;

            Handle = new EventWaitHandle(
                false,
                EventResetMode.AutoReset,
                name,
                out isHandleNew);

            if (!isHandleNew)
            {
                Handle.WaitOne();
            }
        }

        public CrossProcessLock()
            : this("Components.CrossProcessLock")
        {
        }

        public void Dispose()
        {
            Handle.Set();
            Handle.Dispose();
        }
    }
}
