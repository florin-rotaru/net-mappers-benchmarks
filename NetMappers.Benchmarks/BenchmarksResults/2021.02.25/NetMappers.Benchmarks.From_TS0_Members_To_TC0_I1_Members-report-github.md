``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1379 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.103
  [Host] : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   671.33 ns |  6.641 ns |  5.887 ns |
|   AgileMapperMap |   486.42 ns |  7.920 ns |  6.614 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   404.49 ns |  5.758 ns |  5.386 ns |
|       MapsterMap |    85.44 ns |  0.244 ns |  0.229 ns |
|     AirMapperMap |    48.15 ns |  0.160 ns |  0.142 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 8,317.78 ns | 89.406 ns | 79.256 ns |
|    SafeMapperMap |   220.70 ns |  3.091 ns |  2.891 ns |

Benchmarks with issues:
  From_TS0_Members_To_TC0_I1_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TC0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
