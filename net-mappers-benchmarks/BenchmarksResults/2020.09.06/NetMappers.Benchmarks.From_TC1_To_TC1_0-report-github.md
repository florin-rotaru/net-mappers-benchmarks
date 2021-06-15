``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1016 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.401
  [Host] : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   474.57 ns |  1.418 ns |  1.107 ns |
|   AgileMapperMap |   465.63 ns |  5.147 ns |  4.814 ns |
|    TinyMapperMap | 1,234.66 ns | 24.085 ns | 29.578 ns |
|    AutoMapperMap |   843.76 ns | 16.534 ns | 15.466 ns |
|       MapsterMap |   137.56 ns |  1.444 ns |  1.280 ns |
|     StaticsMapperMap |    96.06 ns |  1.998 ns |  1.869 ns |
| HigLaboMapperMap |   557.97 ns | 11.205 ns | 10.481 ns |
|    FastMapperMap |          NA |        NA |        NA |

Benchmarks with issues:
  From_TC1_To_TC1_0.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
