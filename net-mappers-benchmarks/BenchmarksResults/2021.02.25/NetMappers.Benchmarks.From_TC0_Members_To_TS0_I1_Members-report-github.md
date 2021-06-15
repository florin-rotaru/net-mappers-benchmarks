``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1379 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.103
  [Host] : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 3,166.23 ns |  9.218 ns |  8.622 ns |
|   AgileMapperMap |   394.40 ns |  1.340 ns |  1.119 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   179.51 ns |  0.574 ns |  0.509 ns |
|       MapsterMap |    63.25 ns |  0.119 ns |  0.099 ns |
|     StaticsMapperMap |    32.27 ns |  0.330 ns |  0.293 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 8,242.87 ns | 86.586 ns | 72.303 ns |
|    SafeMapperMap |   215.70 ns |  0.941 ns |  0.734 ns |

Benchmarks with issues:
  From_TC0_Members_To_TS0_I1_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TC0_Members_To_TS0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
