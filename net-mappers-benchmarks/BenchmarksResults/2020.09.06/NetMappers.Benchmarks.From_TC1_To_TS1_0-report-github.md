``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1016 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.401
  [Host] : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |     Mean |    Error |   StdDev |
|----------------- |---------:|---------:|---------:|
| ExpressMapperMap | 531.4 ns |  3.22 ns |  2.85 ns |
|   AgileMapperMap | 596.2 ns |  5.95 ns |  5.57 ns |
|    TinyMapperMap |       NA |       NA |       NA |
|    AutoMapperMap | 967.7 ns | 17.13 ns | 16.02 ns |
|       MapsterMap | 291.9 ns |  5.11 ns |  4.78 ns |
|     StaticsMapperMap | 203.8 ns |  2.95 ns |  2.76 ns |
| HigLaboMapperMap | 102.2 ns |  0.19 ns |  0.18 ns |
|    FastMapperMap |       NA |       NA |       NA |

Benchmarks with issues:
  From_TC1_To_TS1_0.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TC1_To_TS1_0.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
