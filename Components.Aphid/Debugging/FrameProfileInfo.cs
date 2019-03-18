using System.Diagnostics;

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
