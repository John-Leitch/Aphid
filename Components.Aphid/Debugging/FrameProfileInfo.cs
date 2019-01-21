using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Debugging
{
    public class FrameProfileInfo
    {
        public int ThreadId { get; }

        public int NameId { get; }

        public Stopwatch Stopwatch { get; }

        public FrameProfileInfo(int threadId, int nameId, Stopwatch stopwatch)
        {
            ThreadId = threadId;
            NameId = nameId;
            Stopwatch = stopwatch;
        }
    }
}
