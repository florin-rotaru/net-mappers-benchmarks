``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1052 (20H2/October2020Update)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.301
  [Host] : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 3,708.46 ns | 10.113 ns |  8.965 ns |
|   AgileMapperMap |   473.61 ns |  1.410 ns |  1.250 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   439.74 ns |  2.886 ns |  2.410 ns |
|       MapsterMap |    85.85 ns |  0.568 ns |  0.504 ns |
| StaticsMapperMap |    45.31 ns |  0.202 ns |  0.168 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 8,766.25 ns | 34.120 ns | 30.246 ns |
|    SafeMapperMap |   245.77 ns |  0.676 ns |  0.565 ns |

Benchmarks with issues:
  From_TS0_Members_To_TS0_I1_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TS0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
