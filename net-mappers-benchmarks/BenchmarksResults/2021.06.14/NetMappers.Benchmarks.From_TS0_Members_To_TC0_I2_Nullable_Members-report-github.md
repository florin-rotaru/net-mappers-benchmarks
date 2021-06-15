``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1052 (20H2/October2020Update)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.301
  [Host] : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |    Error |   StdDev |
|----------------- |------------:|---------:|---------:|
| ExpressMapperMap |   870.59 ns | 2.856 ns | 2.672 ns |
|   AgileMapperMap |   533.57 ns | 2.676 ns | 2.503 ns |
|    TinyMapperMap |          NA |       NA |       NA |
|    AutoMapperMap |   578.78 ns | 0.825 ns | 0.772 ns |
|       MapsterMap |   124.55 ns | 0.954 ns | 0.893 ns |
| StaticsMapperMap |    90.00 ns | 0.411 ns | 0.385 ns |
|    FastMapperMap |          NA |       NA |       NA |
| ValueInjecterMap | 2,391.64 ns | 5.876 ns | 5.209 ns |
|    SafeMapperMap |   258.18 ns | 2.322 ns | 2.058 ns |

Benchmarks with issues:
  From_TS0_Members_To_TC0_I2_Nullable_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TC0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
