# Benchmarks Ensure.That syntax
The purpose of this is to show difference betwen having the `Param` be a `class` or a `struct` and it's only for the `Ensure.That` syntax, not `EnsureArg` or contextual, e.g. `Ensure.String`.

## Param being struct
``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.248)
Intel Core i7-4790K CPU 4.00GHz (Haswell), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3906243 Hz, Resolution=256.0005 ns, Timer=TSC
  [Host]     : .NET Framework 4.7 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2633.0
  DefaultJob : .NET Framework 4.7 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2633.0


```
|             Method |     Mean |     Error |    StdDev | Rank |  Gen 0 | Allocated |
|------------------- |---------:|----------:|----------:|-----:|-------:|----------:|
|          EnsureInt | 16.70 ns | 0.0900 ns | 0.0798 ns |    1 | 0.0028 |      12 B |
|       EnsureString | 16.76 ns | 0.0587 ns | 0.0550 ns |    2 |      - |       0 B |
|   EnsureListOfInts | 78.58 ns | 0.2938 ns | 0.2748 ns |    3 | 0.0056 |      24 B |
| EnsureListOfThings | 90.74 ns | 0.3245 ns | 0.2877 ns |    4 | 0.0056 |      24 B |


## Param being class
``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.248)
Intel Core i7-4790K CPU 4.00GHz (Haswell), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3906243 Hz, Resolution=256.0005 ns, Timer=TSC
  [Host]     : .NET Framework 4.7 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2633.0
  DefaultJob : .NET Framework 4.7 (CLR 4.0.30319.42000), 32bit LegacyJIT-v4.7.2633.0


```
|             Method |     Mean |     Error |    StdDev | Rank |  Gen 0 | Allocated |
|------------------- |---------:|----------:|----------:|-----:|-------:|----------:|
|       EnsureString | 17.19 ns | 0.0769 ns | 0.0719 ns |    1 | 0.0047 |      20 B |
|          EnsureInt | 18.78 ns | 0.0678 ns | 0.0566 ns |    2 | 0.0076 |      32 B |
|   EnsureListOfInts | 76.73 ns | 0.1902 ns | 0.1779 ns |    3 | 0.0151 |      64 B |
| EnsureListOfThings | 87.89 ns | 0.2034 ns | 0.1804 ns |    4 | 0.0151 |      64 B |


## Test
```csharp
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Columns;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using EnsureThat;

namespace Bench
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

        [Benchmark()]
        public void EnsureString()
        {
            Ensure.That("foo", "test").IsNotNullOrWhiteSpace();
        }

        [Benchmark()]
        public void EnsureInt()
        {
            Ensure.That(42, "test").Is(42);
        }

        [Benchmark()]
        public void EnsureListOfInts()
        {
            Ensure.That(_myInts, "test").HasItems();
            Ensure.That(_myInts, "test").HasAny(i => i == 2);
        }

        [Benchmark()]
        public void EnsureListOfThings()
        {
            Ensure.That(_myThings, "test").HasItems();
            Ensure.That(_myThings, "test").HasAny(i => i.MyInt == 2);
        }

        private class MyThing
        {
            public string MyString { get; set; }
            public int MyInt { get; set; }
        }
    }
}
```