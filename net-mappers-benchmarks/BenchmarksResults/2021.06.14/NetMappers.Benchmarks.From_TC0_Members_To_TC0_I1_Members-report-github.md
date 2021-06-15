``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1052 (20H2/October2020Update)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.301
  [Host] : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   152.57 ns |  2.158 ns |  2.018 ns |
|   AgileMapperMap |   226.98 ns |  2.181 ns |  1.933 ns |
|    TinyMapperMap |   122.92 ns |  0.791 ns |  0.617 ns |
|    AutoMapperMap |   130.15 ns |  1.229 ns |  1.026 ns |
|       MapsterMap |    49.47 ns |  0.402 ns |  0.336 ns |
| StaticsMapperMap |    23.91 ns |  0.366 ns |  0.342 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 7,915.70 ns | 91.490 ns | 85.580 ns |
|    SafeMapperMap |   188.17 ns |  1.728 ns |  1.349 ns |

Benchmarks with issues:
  From_TC0_Members_To_TC0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
