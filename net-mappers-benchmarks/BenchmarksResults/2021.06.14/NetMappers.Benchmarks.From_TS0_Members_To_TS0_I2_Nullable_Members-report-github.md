``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1052 (20H2/October2020Update)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.301
  [Host] : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 4,356.57 ns | 21.646 ns | 19.189 ns |
|   AgileMapperMap |   510.54 ns |  0.658 ns |  0.514 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   666.43 ns |  2.283 ns |  2.024 ns |
|       MapsterMap |   136.04 ns |  1.577 ns |  1.475 ns |
| StaticsMapperMap |    83.46 ns |  0.369 ns |  0.327 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 2,504.74 ns | 19.520 ns | 17.304 ns |
|    SafeMapperMap |   270.32 ns |  1.024 ns |  0.958 ns |

Benchmarks with issues:
  From_TS0_Members_To_TS0_I2_Nullable_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TS0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
