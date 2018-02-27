``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.248)
Intel Core i7-4790K CPU 4.00GHz (Haswell), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3906245 Hz, Resolution=256.0003 ns, Timer=TSC
.NET Core SDK=2.1.4
  [Host]     : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.5 (Framework 4.6.26020.03), 64bit RyuJIT


```
|                        Method |      Mean |     Error |    StdDev | Rank | Allocated |
|------------------------------ |----------:|----------:|----------:|-----:|----------:|
|   EnsureListOfIntsViaEnforcer |  6.010 ns | 0.0156 ns | 0.0139 ns |    1 |       0 B |
| EnsureListOfThingsViaEnforcer |  6.253 ns | 0.0305 ns | 0.0271 ns |    2 |       0 B |
|        EnsureIntIsViaEnforcer |  7.576 ns | 0.0441 ns | 0.0413 ns |    3 |       0 B |
|       EnsureStringViaEnforcer |  7.613 ns | 0.0409 ns | 0.0363 ns |    4 |       0 B |
|                   EnsureIntIs |  8.131 ns | 0.0302 ns | 0.0267 ns |    5 |       0 B |
|     EnsureStringIsViaEnforcer | 10.042 ns | 0.0586 ns | 0.0490 ns |    6 |       0 B |
|              EnsureListOfInts | 13.893 ns | 0.0626 ns | 0.0585 ns |    7 |       0 B |
|            EnsureListOfThings | 14.112 ns | 0.0473 ns | 0.0442 ns |    8 |       0 B |
|                  EnsureString | 15.431 ns | 0.0658 ns | 0.0583 ns |    9 |       0 B |
|                EnsureStringIs | 19.678 ns | 0.0873 ns | 0.0774 ns |   10 |       0 B |
