``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1052 (20H2/October2020Update)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.301
  [Host] : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 2,612.73 ns | 18.634 ns | 14.548 ns |
|   AgileMapperMap |   439.99 ns |  2.642 ns |  2.471 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   345.29 ns |  5.879 ns |  5.499 ns |
|       MapsterMap |    84.05 ns |  0.764 ns |  0.638 ns |
| StaticsMapperMap |    40.32 ns |  0.040 ns |  0.033 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 6,391.65 ns | 62.303 ns | 58.278 ns |
|    SafeMapperMap |   238.94 ns |  1.838 ns |  1.630 ns |

Benchmarks with issues:
  From_TS0_Members_To_TS0_I0_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TS0_I0_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
