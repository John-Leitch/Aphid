using System.Diagnostics;

namespace Components.Aphid.Debugging
{
    public readonly struct FrameProfileInfo
    {
        public readonly int ThreadId;

        public readonly int NameId;

        public readonly Stopwatch Stopwatch;

        public FrameProfileInfo(int threadId, int nameId, Stopwatch stopwatch)
        {
            ThreadId = threadId;
            NameId = nameId;
            Stopwatch = stopwatch;
        }
    }
}
