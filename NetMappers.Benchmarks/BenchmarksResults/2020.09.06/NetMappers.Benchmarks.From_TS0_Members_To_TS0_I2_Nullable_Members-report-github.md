``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1016 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.401
  [Host] : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 4,506.85 ns | 77.075 ns | 72.096 ns |
|   AgileMapperMap |   722.72 ns |  1.096 ns |  0.856 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   773.30 ns | 11.223 ns |  9.949 ns |
|       MapsterMap |   155.38 ns |  1.588 ns |  1.485 ns |
|     AirMapperMap |    93.94 ns |  1.818 ns |  1.785 ns |
| HigLaboMapperMap |   632.21 ns |  7.358 ns |  6.523 ns |
|    FastMapperMap |          NA |        NA |        NA |

Benchmarks with issues:
  From_TS0_Members_To_TS0_I2_Nullable_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TS0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
