``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1379 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.103
  [Host] : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   824.58 ns |  2.844 ns |  2.521 ns |
|   AgileMapperMap |   534.91 ns |  3.940 ns |  3.493 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   580.66 ns |  4.197 ns |  3.720 ns |
|       MapsterMap |   122.80 ns |  0.281 ns |  0.249 ns |
|     AirMapperMap |    84.89 ns |  0.370 ns |  0.309 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 2,482.71 ns | 28.363 ns | 26.531 ns |
|    SafeMapperMap |   255.19 ns |  0.649 ns |  0.575 ns |

Benchmarks with issues:
  From_TS0_Members_To_TC0_I2_Nullable_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TC0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
