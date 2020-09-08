``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1016 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.401
  [Host] : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 4,034.24 ns | 49.684 ns | 41.488 ns |
|   AgileMapperMap |   619.15 ns |  7.368 ns |  6.892 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   484.80 ns |  8.329 ns |  7.790 ns |
|       MapsterMap |   105.84 ns |  1.837 ns |  1.718 ns |
|     AirMapperMap |    50.53 ns |  0.782 ns |  0.731 ns |
| HigLaboMapperMap |   194.92 ns |  0.344 ns |  0.322 ns |
|    FastMapperMap |          NA |        NA |        NA |

Benchmarks with issues:
  From_TS0_Members_To_TS0_I1_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TS0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
