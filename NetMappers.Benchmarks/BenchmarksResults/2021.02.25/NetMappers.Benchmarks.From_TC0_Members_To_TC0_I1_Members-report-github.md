``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1379 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.103
  [Host] : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   161.64 ns |  1.495 ns |  1.326 ns |
|   AgileMapperMap |   223.56 ns |  0.781 ns |  0.730 ns |
|    TinyMapperMap |   119.22 ns |  2.290 ns |  2.142 ns |
|    AutoMapperMap |   122.80 ns |  0.473 ns |  0.419 ns |
|       MapsterMap |    49.07 ns |  0.633 ns |  0.592 ns |
|     AirMapperMap |    23.66 ns |  0.168 ns |  0.157 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 7,886.14 ns | 71.459 ns | 59.671 ns |
|    SafeMapperMap |   192.85 ns |  2.506 ns |  2.221 ns |

Benchmarks with issues:
  From_TC0_Members_To_TC0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
