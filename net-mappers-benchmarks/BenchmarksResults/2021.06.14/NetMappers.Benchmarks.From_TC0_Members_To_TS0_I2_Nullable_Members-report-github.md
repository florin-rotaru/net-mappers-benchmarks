``` ini

BenchmarkDotNet=v0.13.0, OS=Windows 10.0.19042.1052 (20H2/October2020Update)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.301
  [Host] : .NET 5.0.7 (5.0.721.25508), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 3,746.44 ns | 21.117 ns | 17.634 ns |
|   AgileMapperMap |   457.83 ns |  2.012 ns |  1.680 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   479.09 ns |  4.617 ns |  4.093 ns |
|       MapsterMap |   124.33 ns |  2.504 ns |  4.184 ns |
| StaticsMapperMap |    72.87 ns |  1.373 ns |  2.476 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 2,249.56 ns |  8.433 ns |  7.889 ns |
|    SafeMapperMap |   248.47 ns |  0.890 ns |  0.789 ns |

Benchmarks with issues:
  From_TC0_Members_To_TS0_I2_Nullable_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TC0_Members_To_TS0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
