``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1379 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.103
  [Host] : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 3,709.32 ns | 61.196 ns | 72.850 ns |
|   AgileMapperMap |   490.80 ns |  6.929 ns |  6.481 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   410.87 ns |  1.733 ns |  1.447 ns |
|       MapsterMap |    81.23 ns |  0.241 ns |  0.225 ns |
|     StaticsMapperMap |    44.49 ns |  0.695 ns |  0.650 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 8,369.02 ns | 29.450 ns | 27.548 ns |
|    SafeMapperMap |   227.43 ns |  3.335 ns |  3.120 ns |

Benchmarks with issues:
  From_TS0_Members_To_TS0_I1_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TS0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
