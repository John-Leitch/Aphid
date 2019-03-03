using Components.External;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.Aphid.Debugging
{
    public sealed class FrameProfileBinaryWriter : IDisposable
    {
        private readonly List<string> _names = new List<string>(0x1000);

        private readonly BinaryWriter _frameWriter, _nameWriter;

        private readonly Stack<FrameProfileInfo> _frames = new Stack<FrameProfileInfo>(0x100);

        public string NameFile { get; }

        public string TraceFile { get; }

        public FrameProfileBinaryWriter(string traceFile)
        {
            TraceFile = traceFile;
            NameFile = TraceFile + ".names";
            _frameWriter = new BinaryWriter(File.Create(traceFile));
            _nameWriter = new BinaryWriter(File.Create(NameFile));
        }

        public FrameProfileBinaryWriter(Guid traceGuid)
            : this(
                PathHelper.GetExecutingPath(
                    string.Format(
                        "AphidFramePerformance.{0}.dat",
                        traceGuid)))
        {
        }

        public void Dispose()
        {
            _frameWriter.Dispose();
            _nameWriter.Dispose();
        }

        public void WriteStart()
        {
            var frameStart = string.Format(
                "Tracing frame performance beginning at:\r\n{0}\r\n\r\n",
                new StackTrace(1));

            _frameWriter.Write(frameStart);
        }

        private int GetNameIndex(string name)
        {
            lock (_names)
            {
                var i = _names.IndexOf(name);

                if (i == -1)
                {
                    i = _names.Count;
                    _nameWriter.Write(name);
                    _names.Add(name);
                }

                return i;
            }
        }

        public void WriteEnter(int threadId, string name)
        {
            _frameWriter.Write(threadId);
            _frameWriter.Write(true);
            var i = GetNameIndex(name);
            _frameWriter.Write(i);
            var sw = new Stopwatch();
            var frame = new FrameProfileInfo(threadId, i, sw);
            _frames.Push(frame);
            sw.Start();
        }

        public void WriteLeave()
        {
            var f = _frames.Pop();
            f.Stopwatch.Stop();
            _frameWriter.Write(f.ThreadId);
            _frameWriter.Write(false);
            _frameWriter.Write(f.Stopwatch.ElapsedTicks);
        }
    }
}
