using System;
using System.Collections.Generic;
using System.Linq;


namespace Components
{
    public static class ParallelEnumerableExtension
    {
        public static ParallelQuery<TSource> ForceUnbufferedPerProcessorParallelism<TSource>(
            this IEnumerable<TSource> source,
            int processorCountMultiplier,
            int minDegreesOfParallelism) =>
            source
                .AsParallel()
                .WithDegreeOfParallelism(
                    Math.Max(
                        Environment.ProcessorCount * processorCountMultiplier,
                        minDegreesOfParallelism))
                .WithMergeOptions(ParallelMergeOptions.NotBuffered)
                .WithExecutionMode(ParallelExecutionMode.ForceParallelism);

        public static ParallelQuery<TSource> ForceUnbufferedPerProcessorParallelism<TSource>(
            this IEnumerable<TSource> source,
            int processorCountMultiplier) =>
            source.ForceUnbufferedPerProcessorParallelism(processorCountMultiplier, 4);

        public static ParallelQuery<TSource> ForceUnbufferedPerProcessorParallelism<TSource>(
            this IEnumerable<TSource> source) =>
            source.ForceUnbufferedPerProcessorParallelism(1);
    }
}
