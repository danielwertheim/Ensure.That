using System;

using BenchmarkDotNet.Attributes;

using EnsureThat;

namespace Benchmarks.ApiComparisons
{
    public class StringEqualsApiComparisonBenchmark
    {
        /// <summary>
        /// If able to introduce interfaces for the Test project, will reuse those here for
        /// full testing rather than Func based (which naturally only tests 1 method)
        /// </summary>
        [Params("EnsureArg", "Ensure.That", "Ensure.String", "Standard")]
        public string EnsureFlavor;

        private Action<string, string> ensureIsEqualToFunc;

        [GlobalSetup]
        public void Setup()
        {
            switch (EnsureFlavor)
            {
                case "EnsureArg":
                    this.ensureIsEqualToFunc =
                        (target, input) => EnsureArg.IsEqualTo(target, input, nameof(target));
                    break;
                case "Ensure.That":
                    this.ensureIsEqualToFunc =
                        (target, input) => Ensure.That(target, nameof(target)).IsEqualTo(input);
                    break;
                case "Ensure.String":
                    this.ensureIsEqualToFunc =
                        (target, input) => Ensure.String.IsEqualTo(target, input, nameof(target));
                    break;
                case "Standard":
                    this.ensureIsEqualToFunc =
                        (target, input) =>
                        {
                            if (!string.Equals(target, input))
                            {
                                throw new ArgumentException("Must be equal", nameof(target));
                            }
                        };
                    break;
            }
        }

        [Benchmark]
        [BenchmarkCategory("Pass", "String", "IsEqualTo")]
        public void EnsureIsEqualTo_AreEqual()
        {
            this.ensureIsEqualToFunc("input", "input");
        }

        /// <summary>
        /// The results of this test will be very large, and have high deviation.
        /// This is because of the exception.
        /// This cannot be avoided with custom exception, because the cost is in the 'throw' statement.
        /// </summary>
        [Benchmark]
        [BenchmarkCategory("Failure", "String", "IsEqualTo")]
        public void EnsureIsEqualTo_AreNotEqual()
        {
            try
            {
                this.ensureIsEqualToFunc("input", "other");
            }
            catch
            {
                // Swallow
            }
        }
    }
}
