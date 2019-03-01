using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Components;
using Components.External;
using System.Reflection;
using System.IO;
using System.Threading;
using Components.External.ConsolePlus;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using Components.Aphid.Interpreter;

namespace Aphid.Benchmarks
{

    [ClrJob,
        AsciiDocExporter,
        CsvExporter,
        CsvMeasurementsExporter,
        HtmlExporter,
        PlainExporter,
        RPlotExporter,
        JsonExporterAttribute.Brief,
        //JsonExporterAttribute.BriefCompressed,
        JsonExporterAttribute.Full,
        //JsonExporterAttribute.FullCompressed,
        //MarkdownExporterAttribute.Default,
        MarkdownExporterAttribute.GitHub,
        //MarkdownExporterAttribute.StackOverflow,
        //MarkdownExporterAttribute.Atlassian,
        //XmlExporterAttribute.Brief,
        //XmlExporterAttribute.BriefCompressed,
        //XmlExporterAttribute.Full,
        //XmlExporterAttribute.FullCompressed,
        KeepBenchmarkFiles,
        InnerIterationCount(100)]
    public class MemoizerBenchmarks
    {
        private Memoizer<string, bool> _memoizer = new Memoizer<string, bool>();

        private Components.Legacy.ArgLockingMemoizer<string, bool> _legacyArgLockingMemoizer = new Components.Legacy.ArgLockingMemoizer<string, bool>();

        private ArgLockingMemoizer<string, bool> _argLockingMemoizer = new ArgLockingMemoizer<string, bool>();

        private DirectArgLockingMemoizer<string, bool> _directMemoizer = new DirectArgLockingMemoizer<string, bool>();

        private string[] _values = Enumerable
            .Range(0x0, 0x100)
            .Select(x => new string((char)x, 0x1000))
            .ToArray();

        private int _valueIndex = -1;

        //public MemoizerBenchmarks()
        //{
        //    Cli.WriteHeader("New Benchmark");
        //}

        
        [IterationSetup]
        public void IterationSetup()
        {
            _memoizer.Clear();
            _legacyArgLockingMemoizer.Clear();            
            _argLockingMemoizer.Clear();
            _directMemoizer.Clear();
        }

        [GlobalSetup]
        public void Setup()
        {
        }

        private string NextValue()
        {
            lock (_values)
            {
                return _values[_valueIndex = ++_valueIndex != _values.Length ? _valueIndex : 0];
            }
        }

        [Benchmark(Baseline = true)]
        public void BenchmarkMemoizer() => ParallelInvoke(() => _memoizer.Call(File.Exists, NextValue()));

        [Benchmark]
        public void BenchmarkLegacyArgLockingMemoizer() => ParallelInvoke(() => _legacyArgLockingMemoizer.Call(File.Exists, NextValue()));

        [Benchmark]
        public void BenchmarkArgLockingMemoizer() => ParallelInvoke(() => _argLockingMemoizer.Call(File.Exists, NextValue()));        

        [Benchmark]
        public void BenchmarkDirectArgLockingMemoizer() => ParallelInvoke(() => _directMemoizer.Call(File.Exists, NextValue()));

        [GlobalCleanup]
        public void Cleanup()
        {
            
        }

        private void ParallelInvoke(Action action, int count = 0x100) =>
            Enumerable
                .Range(0, 8)
                .Select(x =>
                    new Thread(() =>
                    {
                        for (var i = 0; i < count; i++)
                        {
                            try
                            {
                                action();
                            }
                            catch (Exception e) when (!(e is ThreadAbortException))
                            {
                                Cli.WriteErrorMessage("Error: {0}", e);
                            }
                        }
                    }))
                .ToArray()
                .For(x => x.Start())
                .For(x => x.Join());               
    }
}
