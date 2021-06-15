``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1082 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host] : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   474.53 ns |  6.162 ns |  5.145 ns |
|   AgileMapperMap |   273.06 ns |  3.753 ns |  3.510 ns |
|    TinyMapperMap | 1,276.15 ns |  9.185 ns |  7.670 ns |
|    AutoMapperMap |   848.17 ns | 13.632 ns | 12.084 ns |
|       MapsterMap |   147.35 ns |  2.334 ns |  2.183 ns |
|     StaticsMapperMap |    98.51 ns |  1.867 ns |  1.559 ns |
| HigLaboMapperMap |   557.93 ns | 11.151 ns | 12.394 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap |   449.42 ns |  7.246 ns |  6.778 ns |
|   PowerMapperMap |    64.32 ns |  1.258 ns |  2.269 ns |
|    SafeMapperMap |   322.32 ns |  5.685 ns |  5.318 ns |

Benchmarks with issues:
  From_TC1_To_TC1_0.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
