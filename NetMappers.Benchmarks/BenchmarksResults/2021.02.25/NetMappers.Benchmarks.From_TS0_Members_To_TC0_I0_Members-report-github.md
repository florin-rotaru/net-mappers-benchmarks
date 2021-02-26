``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1379 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.103
  [Host] : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |      Error |    StdDev |
|----------------- |------------:|-----------:|----------:|
| ExpressMapperMap |   683.48 ns |   1.901 ns |  1.587 ns |
|   AgileMapperMap |   444.46 ns |   1.743 ns |  1.361 ns |
|    TinyMapperMap |          NA |         NA |        NA |
|    AutoMapperMap |   315.50 ns |   1.808 ns |  1.509 ns |
|       MapsterMap |    83.22 ns |   0.491 ns |  0.410 ns |
|     AirMapperMap |    43.45 ns |   0.123 ns |  0.115 ns |
|    FastMapperMap |          NA |         NA |        NA |
| ValueInjecterMap | 6,128.48 ns | 113.051 ns | 88.263 ns |
|    SafeMapperMap |   229.76 ns |   4.554 ns |  4.473 ns |

Benchmarks with issues:
  From_TS0_Members_To_TC0_I0_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TC0_I0_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
