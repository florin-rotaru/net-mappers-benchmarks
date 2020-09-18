``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1082 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host] : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   556.51 ns |  4.098 ns |  3.834 ns |
|   AgileMapperMap |   392.26 ns |  5.152 ns |  4.567 ns |
|    AutoMapperMap | 1,007.49 ns | 16.909 ns | 15.817 ns |
|       MapsterMap |   250.58 ns |  3.488 ns |  2.912 ns |
|     AirMapperMap |   188.97 ns |  3.071 ns |  2.722 ns |
| HigLaboMapperMap |   106.55 ns |  1.204 ns |  1.006 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap |   508.31 ns |  3.872 ns |  3.433 ns |
|   PowerMapperMap |    88.24 ns |  1.249 ns |  1.043 ns |
|    SafeMapperMap |   391.99 ns |  5.839 ns |  5.462 ns |

Benchmarks with issues:
  From_TC1_To_TS1_0.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
