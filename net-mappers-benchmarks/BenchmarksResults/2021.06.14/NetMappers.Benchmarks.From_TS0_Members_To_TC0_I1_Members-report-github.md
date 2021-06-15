``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1052 (20H2/October2020Update)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.301
  [Host] : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   738.86 ns |  5.297 ns |  4.695 ns |
|   AgileMapperMap |   478.02 ns |  2.295 ns |  2.034 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   393.92 ns |  2.679 ns |  2.237 ns |
|       MapsterMap |    85.30 ns |  0.273 ns |  0.213 ns |
| StaticsMapperMap |    48.62 ns |  0.291 ns |  0.272 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 8,251.03 ns | 32.475 ns | 28.788 ns |
|    SafeMapperMap |   228.66 ns |  0.786 ns |  0.697 ns |

Benchmarks with issues:
  From_TS0_Members_To_TC0_I1_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TC0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
