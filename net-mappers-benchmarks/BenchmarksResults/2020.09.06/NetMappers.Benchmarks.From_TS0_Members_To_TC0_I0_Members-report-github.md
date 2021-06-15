``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1016 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.401
  [Host] : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |      Mean |     Error |    StdDev |
|----------------- |----------:|----------:|----------:|
| ExpressMapperMap | 841.16 ns | 14.534 ns | 13.595 ns |
|   AgileMapperMap | 502.16 ns |  1.137 ns |  0.949 ns |
|    TinyMapperMap |        NA |        NA |        NA |
|    AutoMapperMap | 372.31 ns |  6.254 ns |  5.850 ns |
|       MapsterMap |  97.54 ns |  1.785 ns |  1.669 ns |
|     StaticsMapperMap |  53.29 ns |  0.814 ns |  0.721 ns |
| HigLaboMapperMap | 156.23 ns |  2.136 ns |  1.893 ns |
|    FastMapperMap |        NA |        NA |        NA |

Benchmarks with issues:
  From_TS0_Members_To_TC0_I0_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TC0_I0_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
