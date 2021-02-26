``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1379 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.103
  [Host] : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 2,089.19 ns |  9.948 ns |  7.767 ns |
|   AgileMapperMap |   314.54 ns |  0.958 ns |  0.849 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   148.37 ns |  1.105 ns |  1.034 ns |
|       MapsterMap |    51.51 ns |  0.613 ns |  0.573 ns |
|     AirMapperMap |    21.27 ns |  0.056 ns |  0.053 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 5,961.99 ns | 24.820 ns | 23.216 ns |
|    SafeMapperMap |   197.78 ns |  0.570 ns |  0.505 ns |

Benchmarks with issues:
  From_TC0_Members_To_TS0_I0_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TC0_Members_To_TS0_I0_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
