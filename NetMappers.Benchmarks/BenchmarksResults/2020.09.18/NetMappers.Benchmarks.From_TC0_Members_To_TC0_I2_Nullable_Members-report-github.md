``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1082 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host] : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   324.57 ns |  6.113 ns |  6.278 ns |
|   AgileMapperMap |   272.25 ns |  4.407 ns |  4.122 ns |
|    TinyMapperMap | 1,085.97 ns | 16.175 ns | 15.130 ns |
|    AutoMapperMap |   420.02 ns |  0.373 ns |  0.312 ns |
|       MapsterMap |   100.61 ns |  0.911 ns |  0.853 ns |
|     AirMapperMap |    59.35 ns |  1.251 ns |  1.170 ns |
| HigLaboMapperMap |   498.16 ns |  9.673 ns |  9.500 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 2,336.34 ns | 26.902 ns | 25.164 ns |
|   PowerMapperMap |   112.81 ns |  2.249 ns |  2.104 ns |
|    SafeMapperMap |   277.14 ns |  4.867 ns |  4.552 ns |

Benchmarks with issues:
  From_TC0_Members_To_TC0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
