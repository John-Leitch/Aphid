using Components.External;
using Components.External.ConsolePlus;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Components.Aphid.Debugging
{
    public sealed class FrameProfileBinaryWriter : IDisposable
    {
        private static readonly ArgLockingMemoizer<string, (BinaryWriter, BinaryWriter)> _writerMemoizer = new ArgLockingMemoizer<string, (BinaryWriter, BinaryWriter)>();

        private readonly List<string> _names = new List<string>(0x1000);

        private readonly BinaryWriter _frameWriter, _nameWriter;

        //private readonly Stack<FrameProfileInfo> _frames = new Stack<FrameProfileInfo>(0x100);
        private readonly Stack<Stopwatch> _frames = new Stack<Stopwatch>(0x100);


        public string NameFile { get; }

        public string TraceFile { get; }

        public FrameProfileBinaryWriter(string traceFile)
        {
            TraceFile = traceFile;
            NameFile = TraceFile + ".names";
#pragma warning disable CA2000 // Call dispose before reference leaves scope
            //_frameWriter = new BinaryWriter(File.Create(traceFile));
            //_nameWriter = new BinaryWriter(File.Create(NameFile));
            (_frameWriter, _nameWriter) = _writerMemoizer.Call(
                x => (
                    new BinaryWriter(File.Create(x)),
                    new BinaryWriter(File.Create(x + ".names"))),
                    traceFile);
#pragma warning restore CA2000 // Call dispose before reference leaves scope
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

        public void WriteEnter(string name)
        {
            //_frameWriter.Write(threadId);
            _frameWriter.Write(true);
            var i = GetNameIndex(name);
            _frameWriter.Write(i);
            var sw = new Stopwatch();
            //var frame = new FrameProfileInfo(threadId, i, sw);
            _frames.Push(sw);
            sw.Start();
        }

        public void WriteLeave()
        {
            var f = _frames.Pop();
            f.Stop();
            //_frameWriter.Write(f.ThreadId);
            _frameWriter.Write(false);
            _frameWriter.Write(f.ElapsedTicks);
        }

        public FrameProfileBinaryWriter CreateChild(out bool isExisting)
        {
            var writer = new FrameProfileBinaryWriter(
                //$"{TraceFile}.{Guid.NewGuid()}.{Thread.CurrentThread.ManagedThreadId}.thread");
                $"{TraceFile}.{Thread.CurrentThread.ManagedThreadId}.thread");


            if (writer._frameWriter.BaseStream.Position == 0)
            {
                isExisting = false;
                writer.WriteStart();
            }
            else
            {
                isExisting = true;
                //writer._frameWriter.Write(false);
                //writer._frameWriter.Write(0);

                //var c = writer._frames.Count;
                //for (var i = 0; i < c; i++)
                //{
                //    writer.WriteLeave();
                //}
            }

            return writer;
        }
    }
}
