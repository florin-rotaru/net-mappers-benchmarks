``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1016 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.401
  [Host] : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |      Mean |    Error |   StdDev |
|----------------- |----------:|---------:|---------:|
| ExpressMapperMap | 180.41 ns | 1.121 ns | 0.936 ns |
|   AgileMapperMap | 232.62 ns | 3.840 ns | 3.592 ns |
|    TinyMapperMap | 126.04 ns | 1.344 ns | 1.191 ns |
|    AutoMapperMap | 170.12 ns | 2.209 ns | 2.066 ns |
|       MapsterMap |  59.20 ns | 1.151 ns | 0.899 ns |
|     AirMapperMap |  30.08 ns | 0.655 ns | 0.701 ns |
| HigLaboMapperMap |  93.73 ns | 1.891 ns | 1.857 ns |
|    FastMapperMap |        NA |       NA |       NA |

Benchmarks with issues:
  From_TC0_Members_To_TC0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
