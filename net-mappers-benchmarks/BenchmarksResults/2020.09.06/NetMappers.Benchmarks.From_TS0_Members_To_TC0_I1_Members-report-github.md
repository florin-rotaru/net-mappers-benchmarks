``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1016 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.401
  [Host] : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |      Mean |    Error |   StdDev |
|----------------- |----------:|---------:|---------:|
| ExpressMapperMap | 863.01 ns | 9.745 ns | 9.116 ns |
|   AgileMapperMap | 539.79 ns | 3.732 ns | 3.491 ns |
|    TinyMapperMap |        NA |       NA |       NA |
|    AutoMapperMap | 431.85 ns | 8.145 ns | 7.619 ns |
|       MapsterMap | 102.38 ns | 1.049 ns | 0.982 ns |
|     StaticsMapperMap |  59.30 ns | 1.210 ns | 1.132 ns |
| HigLaboMapperMap | 160.57 ns | 1.655 ns | 1.548 ns |
|    FastMapperMap |        NA |       NA |       NA |

Benchmarks with issues:
  From_TS0_Members_To_TC0_I1_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TC0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
