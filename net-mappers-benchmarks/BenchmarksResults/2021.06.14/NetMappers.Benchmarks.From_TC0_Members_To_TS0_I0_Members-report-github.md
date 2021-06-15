``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1052 (20H2/October2020Update)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.301
  [Host] : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 2,171.74 ns | 34.602 ns | 32.367 ns |
|   AgileMapperMap |   299.35 ns |  1.319 ns |  1.101 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   156.77 ns |  0.351 ns |  0.328 ns |
|       MapsterMap |    52.18 ns |  0.171 ns |  0.152 ns |
| StaticsMapperMap |    20.64 ns |  0.052 ns |  0.048 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 5,779.97 ns | 33.298 ns | 27.805 ns |
|    SafeMapperMap |   206.59 ns |  2.662 ns |  2.490 ns |

Benchmarks with issues:
  From_TC0_Members_To_TS0_I0_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TC0_Members_To_TS0_I0_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
