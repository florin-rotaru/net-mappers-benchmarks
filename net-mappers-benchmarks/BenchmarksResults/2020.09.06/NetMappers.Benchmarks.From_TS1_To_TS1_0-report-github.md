``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1016 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.401
  [Host] : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |       Mean |    Error |   StdDev |
|----------------- |-----------:|---------:|---------:|
| ExpressMapperMap |   581.5 ns |  4.63 ns |  3.86 ns |
|   AgileMapperMap | 1,290.6 ns |  9.79 ns |  9.15 ns |
|    TinyMapperMap |         NA |       NA |       NA |
|    AutoMapperMap | 1,538.9 ns | 18.55 ns | 16.44 ns |
|       MapsterMap |   930.5 ns | 10.62 ns |  8.87 ns |
|     StaticsMapperMap |   226.1 ns |  2.83 ns |  2.51 ns |
| HigLaboMapperMap |   104.1 ns |  2.01 ns |  1.88 ns |
|    FastMapperMap |         NA |       NA |       NA |

Benchmarks with issues:
  From_TS1_To_TS1_0.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS1_To_TS1_0.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
