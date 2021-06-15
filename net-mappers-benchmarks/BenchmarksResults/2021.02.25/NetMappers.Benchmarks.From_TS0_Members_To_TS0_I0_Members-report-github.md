``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1379 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.103
  [Host] : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 2,575.66 ns |  9.820 ns |  7.666 ns |
|   AgileMapperMap |   452.22 ns |  1.560 ns |  1.303 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   339.66 ns |  0.882 ns |  0.737 ns |
|       MapsterMap |    77.70 ns |  1.250 ns |  1.108 ns |
|     StaticsMapperMap |    41.54 ns |  0.329 ns |  0.308 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 6,167.34 ns | 71.876 ns | 63.716 ns |
|    SafeMapperMap |   230.85 ns |  1.607 ns |  1.503 ns |

Benchmarks with issues:
  From_TS0_Members_To_TS0_I0_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TS0_I0_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
