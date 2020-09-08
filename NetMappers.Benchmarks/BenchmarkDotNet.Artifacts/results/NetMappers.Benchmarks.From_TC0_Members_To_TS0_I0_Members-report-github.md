``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1016 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.401
  [Host] : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 2,281.05 ns | 31.429 ns | 29.398 ns |
|   AgileMapperMap |   357.30 ns |  0.580 ns |  0.514 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   211.65 ns |  4.261 ns |  3.986 ns |
|       MapsterMap |    67.18 ns |  0.685 ns |  0.640 ns |
|     AirMapperMap |    30.15 ns |  0.478 ns |  0.424 ns |
| HigLaboMapperMap |   111.46 ns |  1.867 ns |  1.746 ns |
|    FastMapperMap |          NA |        NA |        NA |

Benchmarks with issues:
  From_TC0_Members_To_TS0_I0_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TC0_Members_To_TS0_I0_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
