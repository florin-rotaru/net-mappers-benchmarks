``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1052 (20H2/October2020Update)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.301
  [Host] : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 3,294.26 ns | 18.658 ns | 15.581 ns |
|   AgileMapperMap |   392.35 ns |  2.947 ns |  2.756 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   189.14 ns |  2.692 ns |  2.518 ns |
|       MapsterMap |    70.22 ns |  0.258 ns |  0.228 ns |
| StaticsMapperMap |    35.50 ns |  0.460 ns |  0.408 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 8,312.91 ns | 44.936 ns | 35.083 ns |
|    SafeMapperMap |   208.30 ns |  2.215 ns |  1.850 ns |

Benchmarks with issues:
  From_TC0_Members_To_TS0_I1_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TC0_Members_To_TS0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
