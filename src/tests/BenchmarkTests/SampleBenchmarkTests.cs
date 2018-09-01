namespace BenchmarkTests
{
    using System;
    using System.Diagnostics;
    using System.Linq;
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Configs;
    using BenchmarkDotNet.Jobs;
    using BenchmarkDotNet.Running;
    using BenchmarkDotNet.Toolchains.InProcess;
    using BenchmarkDotNet.Validators;
    using EnsureThat;
    using Xunit;
    using Xunit.Abstractions;

    /// <summary>
    /// Just a sample, for making more benchmark-based tests
    /// </summary>
    public class SampleBenchmarkTests
    {
        private class Config : ManualConfig
        {
            public Config()
            {
                Add(Job.ShortRun
                    .With(InProcessToolchain.Instance));
                
                Add(JitOptimizationsValidator.DontFailOnError);
                Add(ExecutionValidator.DontFailOnError);
            }
        }

        private ITestOutputHelper Helper { get; }

        // Needed for the XUnit
        public SampleBenchmarkTests(ITestOutputHelper helper)
        {
            this.Helper = helper;
        }

        [Fact]
        public void TestCase()
        {
            var results = BenchmarkRunner.Run<Benchmarks>(
                new Config()
                );

            if (results.ValidationErrors.Any(err => err.IsCritical))
            {
                // TODO: Inconclusive in Xunit
                Assert.False(true,
                    string.Join(
                        "\r\n",
                        results.ValidationErrors.Select(v => v.Message)));
            }

            // TODO: Error check - if the runtime isn't installed it might not throw validation but will fail to get Results in the Reports property
            Debugger.Break();

            results.Reports
                    // TODO: Nito Comparers to compare the whole parameter collection instead of just parameter 1

                .GroupBy(report => report.BenchmarkCase.Parameters.Items.FirstOrDefault())
                
                .ToList()
                .ForEach(
                    reportsForParameterCollection =>
                    {
                        var baseline = reportsForParameterCollection.Single(report => report.BenchmarkCase.IsBaseline());
                        var compareTo = reportsForParameterCollection.Single(report => !report.BenchmarkCase.IsBaseline());

                        Helper.WriteLine($"Comparing {baseline.ResultStatistics.Mean:g3} +/- {baseline.ResultStatistics.StandardDeviation:g1} to {compareTo.ResultStatistics.Mean:g3} +/- {compareTo.ResultStatistics.StandardDeviation:g1}");

                        // TODO: Real statistical test
                        if (compareTo.ResultStatistics.Mean - compareTo.ResultStatistics.StandardDeviation > baseline.ResultStatistics.Mean + baseline.ResultStatistics.StandardDeviation)
                        {   
                            // TODO: Clarify this assert to not be false(true)
                            Assert.False(
                                true,
                                $"The treatment is slower than the baseline. {compareTo.ResultStatistics.Mean:g3} +/- {compareTo.ResultStatistics.StandardDeviation:g3} vs {baseline.ResultStatistics.Mean:g3} +/- {baseline.ResultStatistics.StandardDeviation:g3}");
                        }

                        // TODO: Should only alert if MUCH smaller
                        if (compareTo.ResultStatistics.Mean + compareTo.ResultStatistics.StandardDeviation < baseline.ResultStatistics.Mean - baseline.ResultStatistics.StandardDeviation)
                        {
                            // TODO: Clarify this assert to not be false(true)
                            Assert.False(
                                true,
                                $"The treatment is faster than the baseline. While this may be fine, it can suggest programming bugs like the method is not doing anything or not being compared to the ACTUAL equivalent (e.g. one case the BCL was looking up a localized string but the treatment was using a hardcoded English string - essentially comparing apples to oranges [which, if you're curious, oranges are better])."
                                + $" {compareTo.ResultStatistics.Mean:g3} +/- {compareTo.ResultStatistics.StandardDeviation:g3} vs {baseline.ResultStatistics.Mean:g3} +/- {baseline.ResultStatistics.StandardDeviation:g3}");
                        }
                    });
        }

        public class Benchmarks
        {
            [Params(null, "test")] public string Value { get; set; }

            [Benchmark]
            public void Treatment()
            {
                try
                {
                    Ensure.That(Value, nameof(Value)).IsNotNull();
                }
                catch (ArgumentNullException ane)
                {
                    // Expected
                }
            }

            [Benchmark(Baseline = true)]
            public void Baseline()
            {
                try
                {
                    if (Value == null)
                    {
                        throw new ArgumentNullException(nameof(Value));
                    }
                }
                catch (ArgumentNullException ane)
                {
                    // Expected
                }
            }
        }
    }
}