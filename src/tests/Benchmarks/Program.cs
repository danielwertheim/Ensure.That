using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using EnsureThat;

namespace Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<Ensures>();
        }
    }

    [OrderProvider(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    [MemoryDiagnoser]
    public class Ensures
    {
        private readonly List<int> _myInts = new List<int> { 1, 2, 3 };
        private readonly List<MyThing> _myThings = new List<MyThing>
        {
            new MyThing
            {
                MyInt = 1,
                MyString = "A"
            },
            new MyThing
            {
                MyInt = 2,
                MyString = "B"
            },
            new MyThing
            {
                MyInt = 3,
                MyString = "C"
            }
        };

        [Benchmark]
        [BenchmarkCategory("Strin_IsNotNullOrWhiteSpace")]
        public void EnsureString()
        {
            Ensure.That("foo", "test").IsNotNullOrWhiteSpace();
        }

        [Benchmark]
        [BenchmarkCategory("String_IsNotNullOrWhiteSpace")]
        public void EnsureStringViaEnforcer()
        {
            Ensure.String.IsNotNullOrWhiteSpace("foo", "test");
        }

        [Benchmark]
        [BenchmarkCategory("Int_Is")]
        public void EnsureIntIs()
        {
            Ensure.That(42, "test").Is(42);
        }

        [Benchmark]
        [BenchmarkCategory("Int_Is")]
        public void EnsureIntIsViaEnforcer()
        {
            Ensure.Comparable.Is(42, 42, "test");
        }

        [Benchmark]
        [BenchmarkCategory("String_Is")]
        public void EnsureStringIs()
        {
            Ensure.That("foo", "test").Is("foo");
        }

        [Benchmark]
        [BenchmarkCategory("String_Is")]
        public void EnsureStringIsViaEnforcer()
        {
            Ensure.Comparable.Is("foo", "foo", "test");
        }

        [Benchmark]
        [BenchmarkCategory("ListOfInts_HasItems")]
        public void EnsureListOfInts()
        {
            Ensure.That(_myInts, "test").HasItems();
        }

        [Benchmark]
        [BenchmarkCategory("ListOfInts_HasItems")]
        public void EnsureListOfIntsViaEnforcer()
        {
            Ensure.Collection.HasItems(_myInts, "test"); ;
        }

        [Benchmark]
        [BenchmarkCategory("ListOfThings_HasItems")]
        public void EnsureListOfThings()
        {
            Ensure.That(_myThings, "test").HasItems();
        }

        [Benchmark]
        [BenchmarkCategory("ListOfThings_HasItems")]
        public void EnsureListOfThingsViaEnforcer()
        {
            Ensure.Collection.HasItems(_myThings, "test");
        }

        private class MyThing
        {
            public string MyString { get; set; }
            public int MyInt { get; set; }
        }
    }
}