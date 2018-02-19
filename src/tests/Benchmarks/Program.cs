using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Diagnostics.Windows;
using BenchmarkDotNet.Environments;
using BenchmarkDotNet.Filters;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

using Benchmarks.ApiComparisons;

using MemoryDiagnoser = BenchmarkDotNet.Diagnosers.MemoryDiagnoser;

namespace Benchmarks
{
    internal static class Program
    {
        private static void Main()
        {
            var benchmarkConfig = DefaultConfig.Instance;

            // Run fewer iterations. Higher deviation but faster results.
            // omit for releasing 'official' numbers
            benchmarkConfig = benchmarkConfig.With(
                Job.ShortRun
                    .With(Platform.X64)
                    .With(Jit.LegacyJit));
            
            // Runs the MemoryDiagnoser, which adds test time but detects allocations/GC
            //benchmarkConfig = benchmarkConfig.With(MemoryDiagnoser.Default);

            // Runs the InliningDiagnoser, which explains why inlining did not happen, when it's blocked
            //benchmarkConfig = benchmarkConfig.With(new InliningDiagnoser());

            // Filter to just pass tests
            benchmarkConfig = benchmarkConfig.With(new CategoryFilter("Pass"));

            BenchmarkRunner.Run<StringEqualsApiComparisonBenchmark>(benchmarkConfig);
        }
    }
}
