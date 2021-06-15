``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1052 (20H2/October2020Update)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.301
  [Host] : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |      Median |
|----------------- |------------:|----------:|----------:|------------:|
| ExpressMapperMap |   281.67 ns |  0.613 ns |  0.479 ns |   281.60 ns |
|   AgileMapperMap |   288.88 ns |  3.300 ns |  3.087 ns |   290.59 ns |
|    TinyMapperMap | 1,059.74 ns |  8.305 ns |  7.769 ns | 1,060.95 ns |
|    AutoMapperMap |   391.23 ns |  7.025 ns |  6.227 ns |   390.84 ns |
|       MapsterMap |    88.26 ns |  1.741 ns |  4.105 ns |    86.17 ns |
| StaticsMapperMap |    61.50 ns |  0.953 ns |  0.845 ns |    61.72 ns |
|    FastMapperMap |          NA |        NA |        NA |          NA |
| ValueInjecterMap | 2,249.42 ns | 15.442 ns | 13.689 ns | 2,252.72 ns |
|    SafeMapperMap |   225.86 ns |  2.184 ns |  2.043 ns |   225.94 ns |

Benchmarks with issues:
  From_TC0_Members_To_TC0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
