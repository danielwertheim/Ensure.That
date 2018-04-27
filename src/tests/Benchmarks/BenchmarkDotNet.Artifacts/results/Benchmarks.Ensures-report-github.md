``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.334)
Intel Core i7-4790K CPU 4.00GHz (Haswell), 1 CPU, 8 logical cores and 4 physical cores
Frequency=3906247 Hz, Resolution=256.0002 ns, Timer=TSC
.NET Core SDK=2.1.104
  [Host]     : .NET Core 2.0.6 (Framework 4.6.26212.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.6 (Framework 4.6.26212.01), 64bit RyuJIT


```
|                                 Method |                   Categories |       Mean |     Error |    StdDev | Scaled | ScaledSD | Rank |  Gen 0 | Allocated |
|--------------------------------------- |----------------------------- |-----------:|----------:|----------:|-------:|---------:|-----:|-------:|----------:|
|                         ThingIsNotNull |                Any.IsNotNull |  2.9958 ns | 0.0094 ns | 0.0079 ns |   1.00 |     0.00 |    1 | 0.0076 |      32 B |
|              ThingIsNotNullViaEnforcer |                Any.IsNotNull |  4.5552 ns | 0.0280 ns | 0.0219 ns |   1.52 |     0.01 |    2 | 0.0076 |      32 B |
|                  ThingIsNotNullViaThat |                Any.IsNotNull | 12.3884 ns | 0.0588 ns | 0.0550 ns |   4.14 |     0.02 |    3 | 0.0076 |      32 B |
|                                        |                              |            |           |           |        |          |      |        |           |
|                                  IntIs |                       Int.Is |  0.7862 ns | 0.0113 ns | 0.0105 ns |   1.00 |     0.00 |    1 |      - |       0 B |
|                           IntIsViaThat |                       Int.Is |  2.7818 ns | 0.0085 ns | 0.0075 ns |   3.54 |     0.05 |    2 |      - |       0 B |
|                       IntIsViaEnforcer |                       Int.Is |  2.8434 ns | 0.0184 ns | 0.0172 ns |   3.62 |     0.05 |    3 |      - |       0 B |
|                                        |                              |            |           |           |        |          |      |        |           |
|                                IntIsGt |                     Int.IsGt |  0.7856 ns | 0.0076 ns | 0.0059 ns |   1.00 |     0.00 |    1 |      - |       0 B |
|                     IntIsGtViaEnforcer |                     Int.IsGt |  2.3644 ns | 0.0108 ns | 0.0101 ns |   3.01 |     0.03 |    2 |      - |       0 B |
|                         IntIsGtViaThat |                     Int.IsGt |  2.5139 ns | 0.0189 ns | 0.0177 ns |   3.20 |     0.03 |    3 |      - |       0 B |
|                                        |                              |            |           |           |        |          |      |        |           |
|                           IntsHasItems |                Ints.HasItems |  0.7687 ns | 0.0106 ns | 0.0099 ns |   1.00 |     0.00 |    1 |      - |       0 B |
|                IntsHasItemsViaEnforcer |                Ints.HasItems |  3.7391 ns | 0.0201 ns | 0.0178 ns |   4.86 |     0.06 |    2 |      - |       0 B |
|                    IntsHasItemsViaThat |                Ints.HasItems | 14.0298 ns | 0.0684 ns | 0.0571 ns |  18.25 |     0.24 |    3 |      - |       0 B |
|                                        |                              |            |           |           |        |          |      |        |           |
|                        StringIsEqualTo |             String.IsEqualTo |  1.7682 ns | 0.0098 ns | 0.0092 ns |   1.00 |     0.00 |    1 |      - |       0 B |
|             StringIsEqualToViaEnforcer |             String.IsEqualTo |  1.7824 ns | 0.0115 ns | 0.0107 ns |   1.01 |     0.01 |    2 |      - |       0 B |
|                 StringIsEqualToViaThat |             String.IsEqualTo |  2.0212 ns | 0.0082 ns | 0.0077 ns |   1.14 |     0.01 |    3 |      - |       0 B |
|                                        |                              |            |           |           |        |          |      |        |           |
|            StringIsNotNullOrWhiteSpace | String.IsNotNullOrWhiteSpace |  3.4817 ns | 0.0258 ns | 0.0241 ns |   1.00 |     0.00 |    1 |      - |       0 B |
|     StringIsNotNullOrWhiteSpaceViaThat | String.IsNotNullOrWhiteSpace |  7.3463 ns | 0.0250 ns | 0.0221 ns |   2.11 |     0.02 |    2 |      - |       0 B |
| StringIsNotNullOrWhiteSpaceViaEnforcer | String.IsNotNullOrWhiteSpace |  7.4140 ns | 0.0368 ns | 0.0326 ns |   2.13 |     0.02 |    3 |      - |       0 B |
|                                        |                              |            |           |           |        |          |      |        |           |
|                        StringsHasItems |             Strings.HasItems |  0.7664 ns | 0.0078 ns | 0.0073 ns |   1.00 |     0.00 |    1 |      - |       0 B |
|             StringsHasItemsViaEnforcer |             Strings.HasItems |  4.6097 ns | 0.0214 ns | 0.0178 ns |   6.02 |     0.06 |    2 |      - |       0 B |
|                 StringsHasItemsViaThat |             Strings.HasItems | 12.8419 ns | 0.0618 ns | 0.0578 ns |  16.76 |     0.17 |    3 |      - |       0 B |
|                                        |                              |            |           |           |        |          |      |        |           |
|                         ThingsHasItems |              Things.HasItems |  0.7818 ns | 0.0071 ns | 0.0063 ns |   1.00 |     0.00 |    1 |      - |       0 B |
|              ThingsHasItemsViaEnforcer |              Things.HasItems |  4.4065 ns | 0.0164 ns | 0.0137 ns |   5.64 |     0.05 |    2 |      - |       0 B |
|                  ThingsHasItemsViaThat |              Things.HasItems | 12.8201 ns | 0.0942 ns | 0.0835 ns |  16.40 |     0.16 |    3 |      - |       0 B |
