using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using Components.Aphid.Interpreter;

namespace Aphid.Benchmarks
{

    [ClrJob,
        InnerIterationCount(InnerIterations),
        GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory),
        AsciiDocExporter,
        CsvExporter,
        CsvMeasurementsExporter,
        HtmlExporter,
        PlainExporter,
        RPlotExporter,
        JsonExporterAttribute.Brief,
        MarkdownExporterAttribute.GitHub,
        KeepBenchmarkFiles]
    public class AphidFramePushPopBenchmarks
    {
        public const int InnerIterations = 10000, FrameCount = 1000, NestedFrameCount = FrameCount;

        private AphidInterpreter _interpreter;

        [IterationSetup]
        public void IterationSetup() => _interpreter = new AphidInterpreter();

        [Benchmark(Baseline = true), BenchmarkCategory("FrameTest")]
        public int TestTryFinally()
        {
            var aphid = _interpreter;
            var i = 0;

            for (var x = 0; x < FrameCount; x++)
            {
                aphid.PushFrame("Test");

                try
                {
                    i++;
                }
                finally
                {
                    aphid.PopFrame();
                }
            }

            return aphid.GetFrameArray().Length + i;
        }

        [Benchmark, BenchmarkCategory("FrameTest")]
        public int TestTryCatchFinally()
        {
            var aphid = _interpreter;
            var i = 0;

            for (var x = 0; x < FrameCount; x++)
            {
                aphid.PushFrame("Test");

                try
                {
                    i++;
                }
                catch
                {
                    aphid.PopQueuedFrames();

                    throw;
                }
                finally
                {
                    aphid.PopFrame();
                }
            }

            return aphid.GetFrameArray().Length + i;
        }

        [Benchmark(Baseline = true), BenchmarkCategory("NestedFrameTest")]
        public int TestTryFinally2()
        {
            var aphid = _interpreter;
            var i = 0;

            for (var x = 0; x < NestedFrameCount; x++)
            {
                aphid.PushFrame("Test");
            }

            for (var x = 0; x < NestedFrameCount; x++)
            {

                try
                {
                    i++;
                }
                finally
                {
                    aphid.PopFrame();
                }
            }

            return aphid.GetFrameArray().Length + i;
        }

        [Benchmark, BenchmarkCategory("NestedFrameTest")]
        public int TestTryCatchFinally2()
        {
            var aphid = _interpreter;
            var i = 0;

            for (var x = 0; x < NestedFrameCount; x++)
            {
                aphid.PushFrame("Test");
            }

            for (var x = 0; x < NestedFrameCount; x++)
            {
                try
                {
                    i++;
                }
                catch
                {
                    aphid.PopQueuedFrames();

                    throw;
                }
                finally
                {
                    aphid.PopFrame();
                }
            }

            return aphid.GetFrameArray().Length + i;
        }
    }
}
