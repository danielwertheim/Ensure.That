﻿using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Attributes.Filters;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using EnsureThat;

namespace Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<Ensures>();
        }
    }

    public static class BaseLines
    {
        public static void StringIsNotNullOrWhiteSpace(string value)
        {
            if (value == null)
                throw new ArgumentNullException(nameof(value));

            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Some message 1.", nameof(value));
        }

        public static void StringIsEqualTo(string value, string expected)
        {
            if (!string.Equals(value, expected))
                throw new ArgumentException("Some message 2.", nameof(value));
        }

        public static void StringsHasItems(List<string> strings)
        {
            if (strings.Count == 0)
                throw new ArgumentException("Some message 3.", nameof(strings));
        }

        public static void IntIs(int value, int expected)
        {
            if (value != expected)
                throw new ArgumentOutOfRangeException(nameof(value), value, "Some message 4.");
        }

        public static void IntIsGt(int value, int limit)
        {
            if (value <= limit)
                throw new ArgumentOutOfRangeException(nameof(value), value, "Some message 5.");
        }

        public static void IntsHasItems(List<int> ints)
        {
            if (ints.Count == 0)
                throw new ArgumentException("Some message 6.", nameof(ints));
        }

        public static void ThingIsNotNullViaThat<T>(T thing) where T : class
        {
            if (thing == null)
                throw new ArgumentNullException(nameof(thing));
        }

        public static void ThingsHasItems<T>(List<T> things) where T : class
        {
            if (things.Count == 0)
                throw new ArgumentException("Some message 7.", nameof(things));
        }
    }

    [OrderProvider(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    [MemoryDiagnoser]
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory)]
    [CategoriesColumn]
    //[CategoryFilter("Things.HasItems")]
    public class Ensures
    {
        private readonly List<string> _strings = new List<string> { "test1", "TEST2", "Test3" };
        private readonly List<int> _ints = new List<int> { 1, 2, 3 };
        private readonly List<MyThing> _things = new List<MyThing>
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

        [Benchmark(Baseline = true)]
        [BenchmarkCategory("String.IsNotNullOrWhiteSpace")]
        public void StringIsNotNullOrWhiteSpace()
            => BaseLines.StringIsNotNullOrWhiteSpace("foo");

        [Benchmark]
        [BenchmarkCategory("String.IsNotNullOrWhiteSpace")]
        public void StringIsNotNullOrWhiteSpaceViaThat()
            => Ensure.That("foo", "test").IsNotNullOrWhiteSpace();

        [Benchmark]
        [BenchmarkCategory("String.IsNotNullOrWhiteSpace")]
        public void StringIsNotNullOrWhiteSpaceViaEnforcer()
            => Ensure.String.IsNotNullOrWhiteSpace("foo", "test");

        [Benchmark(Baseline = true)]
        [BenchmarkCategory("String.IsEqualTo")]
        public void StringIsEqualTo()
            => BaseLines.StringIsEqualTo("foo", "foo");

        [Benchmark]
        [BenchmarkCategory("String.IsEqualTo")]
        public void StringIsEqualToViaThat()
            => Ensure.That("foo", "test").IsEqualTo("foo");

        [Benchmark]
        [BenchmarkCategory("String.IsEqualTo")]
        public void StringIsEqualToViaEnforcer()
            => Ensure.String.IsEqualTo("foo", "foo", "test");

        [Benchmark(Baseline = true)]
        [BenchmarkCategory("Strings.HasItems")]
        public void StringsHasItems()
            => BaseLines.StringsHasItems(_strings);

        [Benchmark]
        [BenchmarkCategory("Strings.HasItems")]
        public void StringsHasItemsViaThat()
            => Ensure.That(_strings, "test").HasItems();

        [Benchmark]
        [BenchmarkCategory("Strings.HasItems")]
        public void StringsHasItemsViaEnforcer()
            => Ensure.Collection.HasItems(_strings, "test");

        [Benchmark(Baseline = true)]
        [BenchmarkCategory("Int.Is")]
        public void IntIs()
            => BaseLines.IntIs(42, 42);

        [Benchmark]
        [BenchmarkCategory("Int.Is")]
        public void IntIsViaThat()
            => Ensure.That(42, "test").Is(42);

        [Benchmark]
        [BenchmarkCategory("Int.Is")]
        public void IntIsViaEnforcer()
            => Ensure.Comparable.Is(42, 42, "test");

        [Benchmark(Baseline = true)]
        [BenchmarkCategory("Int.IsGt")]
        public void IntIsGt()
            => BaseLines.IntIsGt(42, 41);

        [Benchmark]
        [BenchmarkCategory("Int.IsGt")]
        public void IntIsGtViaThat()
            => Ensure.That(42, "test").IsGt(41);

        [Benchmark]
        [BenchmarkCategory("Int.IsGt")]
        public void IntIsGtViaEnforcer()
            => Ensure.Comparable.IsGt(42, 41, "test");

        [Benchmark(Baseline = true)]
        [BenchmarkCategory("Ints.HasItems")]
        public void IntsHasItems()
            => BaseLines.IntsHasItems(_ints);

        [Benchmark]
        [BenchmarkCategory("Ints.HasItems")]
        public void IntsHasItemsViaThat()
            => Ensure.That(_ints, "test").HasItems();

        [Benchmark]
        [BenchmarkCategory("Ints.HasItems")]
        public void IntsHasItemsViaEnforcer()
            => Ensure.Collection.HasItems(_ints, "test");

        [Benchmark(Baseline = true)]
        [BenchmarkCategory("Any.IsNotNull")]
        public void ThingIsNotNull()
            => BaseLines.ThingIsNotNullViaThat(new MyThing());

        [Benchmark]
        [BenchmarkCategory("Any.IsNotNull")]
        public void ThingIsNotNullViaThat()
            => Ensure.That(new MyThing(), "test").IsNotNull();

        [Benchmark]
        [BenchmarkCategory("Any.IsNotNull")]
        public void ThingIsNotNullViaEnforcer()
            => Ensure.Any.IsNotNull(new MyThing(), "test");

        [Benchmark(Baseline = true)]
        [BenchmarkCategory("Things.HasItems")]
        public void ThingsHasItems()
            => BaseLines.ThingsHasItems(_things);

        [Benchmark]
        [BenchmarkCategory("Things.HasItems")]
        public void ThingsHasItemsViaThat()
            => Ensure.That(_things, "test").HasItems();

        [Benchmark]
        [BenchmarkCategory("Things.HasItems")]
        public void ThingsHasItemsViaEnforcer()
            => Ensure.Collection.HasItems(_things, "test");

        private class MyThing
        {
            public string MyString { get; set; }
            public int MyInt { get; set; }
        }
    }
}