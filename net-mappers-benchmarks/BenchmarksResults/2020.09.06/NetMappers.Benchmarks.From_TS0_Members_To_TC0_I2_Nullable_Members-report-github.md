``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1016 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.401
  [Host] : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 1,014.04 ns | 16.328 ns | 17.470 ns |
|   AgileMapperMap |   577.15 ns | 10.811 ns |  9.028 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   680.61 ns | 11.737 ns | 10.979 ns |
|       MapsterMap |   137.06 ns |  2.137 ns |  1.999 ns |
|     StaticsMapperMap |    95.70 ns |  1.174 ns |  1.041 ns |
| HigLaboMapperMap |   572.42 ns |  7.673 ns |  7.178 ns |
|    FastMapperMap |          NA |        NA |        NA |

Benchmarks with issues:
  From_TS0_Members_To_TC0_I2_Nullable_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TC0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
