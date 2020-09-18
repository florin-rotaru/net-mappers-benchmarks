``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1082 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host] : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 1,018.87 ns |  9.850 ns |  8.732 ns |
|   AgileMapperMap |   508.12 ns |  9.927 ns | 12.908 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   678.45 ns |  8.907 ns |  7.895 ns |
|       MapsterMap |   141.30 ns |  2.697 ns |  2.252 ns |
|     AirMapperMap |    98.18 ns |  1.874 ns |  1.753 ns |
| HigLaboMapperMap |   595.87 ns | 11.896 ns | 11.684 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 2,402.51 ns | 14.363 ns | 12.733 ns |
|   PowerMapperMap |   147.08 ns |  2.990 ns |  3.443 ns |
|    SafeMapperMap |   351.81 ns |  3.886 ns |  3.635 ns |

Benchmarks with issues:
  From_TS0_Members_To_TC0_I2_Nullable_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TC0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
