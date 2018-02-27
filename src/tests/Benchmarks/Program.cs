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
        [BenchmarkCategory("String")]
        public void EnsureString()
        {
            Ensure.That("foo", "test").IsNotNullOrWhiteSpace();
        }

        [Benchmark]
        [BenchmarkCategory("Strings")]
        public void EnsureStringViaEnforcer()
        {
            Ensure.String.IsNotNullOrWhiteSpace("foo", "test");
        }

        [Benchmark]
        [BenchmarkCategory("Int")]
        public void EnsureInt()
        {
            Ensure.That(42, "test").Is(42);
        }

        [Benchmark]
        [BenchmarkCategory("Int")]
        public void EnsureIntViaEnforcer()
        {
            Ensure.Comparable.Is(42, 42, "test");
        }

        [Benchmark]
        [BenchmarkCategory("ListOfInts")]
        public void EnsureListOfInts()
        {
            Ensure.That(_myInts, "test").HasItems();
            //Ensure.That(_myInts, "test").HasAny(i => i == 2);
        }

        [Benchmark]
        [BenchmarkCategory("ListOfInts")]
        public void EnsureListOfIntsViaEnforcer()
        {
            Ensure.Collection.HasItems(_myInts, "test"); ;
            //Ensure.Collection.HasAny(_myInts, i => i == 2, "test");
        }

        [Benchmark]
        [BenchmarkCategory("ListOfThings")]
        public void EnsureListOfThings()
        {
            Ensure.That(_myThings, "test").HasItems();
            //Ensure.That(_myThings, "test").HasAny(i => i.MyInt == 2);
        }

        [Benchmark]
        [BenchmarkCategory("ListOfThings")]
        public void EnsureListOfThingsViaEnforcer()
        {
            Ensure.Collection.HasItems(_myThings, "test");
            //Ensure.Collection.HasAny(_myThings, i => i.MyInt == 2, "test");
        }

        private class MyThing
        {
            public string MyString { get; set; }
            public int MyInt { get; set; }
        }
    }
}