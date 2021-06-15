``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1016 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.401
  [Host] : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 3,308.71 ns | 51.976 ns | 46.075 ns |
|   AgileMapperMap |   439.11 ns |  2.391 ns |  2.236 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   240.00 ns |  3.058 ns |  2.711 ns |
|       MapsterMap |    81.59 ns |  1.625 ns |  1.739 ns |
|     StaticsMapperMap |    37.75 ns |  0.752 ns |  0.704 ns |
| HigLaboMapperMap |   133.30 ns |  2.668 ns |  2.621 ns |
|    FastMapperMap |          NA |        NA |        NA |

Benchmarks with issues:
  From_TC0_Members_To_TS0_I1_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TC0_Members_To_TS0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
