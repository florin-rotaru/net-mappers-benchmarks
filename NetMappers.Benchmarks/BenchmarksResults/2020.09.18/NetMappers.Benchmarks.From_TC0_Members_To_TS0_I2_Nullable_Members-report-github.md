``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1082 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host] : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |      Median |
|----------------- |------------:|----------:|----------:|------------:|
| ExpressMapperMap | 4,016.08 ns | 40.428 ns | 37.816 ns | 4,026.16 ns |
|   AgileMapperMap |   471.37 ns |  7.496 ns |  5.852 ns |   473.64 ns |
|    TinyMapperMap |          NA |        NA |        NA |          NA |
|    AutoMapperMap |   550.93 ns | 10.862 ns | 12.509 ns |   542.63 ns |
|       MapsterMap |   131.27 ns |  0.354 ns |  0.276 ns |   131.20 ns |
|     AirMapperMap |    87.52 ns |  1.543 ns |  1.443 ns |    88.32 ns |
| HigLaboMapperMap |   609.99 ns |  1.884 ns |  1.762 ns |   609.68 ns |
|    FastMapperMap |          NA |        NA |        NA |          NA |
| ValueInjecterMap | 2,436.28 ns | 36.979 ns | 34.590 ns | 2,452.54 ns |
|   PowerMapperMap |   142.11 ns |  2.862 ns |  2.677 ns |   142.01 ns |
|    SafeMapperMap |   365.85 ns |  4.999 ns |  4.676 ns |   365.87 ns |

Benchmarks with issues:
  From_TC0_Members_To_TS0_I2_Nullable_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TC0_Members_To_TS0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
