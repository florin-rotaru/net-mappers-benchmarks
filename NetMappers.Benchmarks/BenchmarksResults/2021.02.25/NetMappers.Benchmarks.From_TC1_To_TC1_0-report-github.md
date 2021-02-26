``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1379 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.103
  [Host] : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |    Error |   StdDev |
|----------------- |------------:|---------:|---------:|
| ExpressMapperMap |   448.05 ns | 1.600 ns | 1.419 ns |
|   AgileMapperMap |   474.55 ns | 2.683 ns | 2.509 ns |
|    TinyMapperMap | 1,240.73 ns | 5.957 ns | 5.281 ns |
|    AutoMapperMap |   827.59 ns | 2.023 ns | 1.793 ns |
|       MapsterMap |   132.17 ns | 0.624 ns | 0.521 ns |
|     AirMapperMap |    97.03 ns | 1.925 ns | 1.707 ns |
|    FastMapperMap |          NA |       NA |       NA |
| ValueInjecterMap |   441.43 ns | 8.699 ns | 9.669 ns |
|    SafeMapperMap |   228.62 ns | 4.382 ns | 6.692 ns |

Benchmarks with issues:
  From_TC1_To_TC1_0.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
