``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1082 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host] : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   527.91 ns |  9.071 ns |  8.485 ns |
|   AgileMapperMap |   995.13 ns | 16.663 ns | 33.660 ns |
|    AutoMapperMap | 1,426.98 ns | 23.522 ns | 22.003 ns |
|       MapsterMap |   886.27 ns |  4.971 ns |  4.407 ns |
|     AirMapperMap |   162.82 ns |  3.291 ns |  3.078 ns |
| HigLaboMapperMap |    82.95 ns |  1.475 ns |  1.379 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap |   456.64 ns |  5.568 ns |  5.209 ns |
|   PowerMapperMap |    66.10 ns |  1.006 ns |  0.941 ns |
|    SafeMapperMap |   357.80 ns |  6.078 ns |  5.685 ns |

Benchmarks with issues:
  From_TS1_To_TC1_0.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
