``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1082 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host] : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   822.76 ns | 16.287 ns | 22.293 ns |
|   AgileMapperMap |   416.88 ns |  6.330 ns |  4.942 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   365.15 ns |  1.247 ns |  0.973 ns |
|       MapsterMap |    99.94 ns |  1.723 ns |  1.612 ns |
|     StaticsMapperMap |    52.99 ns |  1.093 ns |  1.022 ns |
| HigLaboMapperMap |   156.02 ns |  1.613 ns |  1.509 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 6,625.73 ns | 90.447 ns | 84.604 ns |
|   PowerMapperMap |    94.00 ns |  0.832 ns |  0.695 ns |
|    SafeMapperMap |   258.61 ns |  3.797 ns |  3.552 ns |

Benchmarks with issues:
  From_TS0_Members_To_TC0_I0_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TC0_I0_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
