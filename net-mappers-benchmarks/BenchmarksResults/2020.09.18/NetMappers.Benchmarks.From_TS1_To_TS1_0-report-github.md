``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1082 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host] : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   599.88 ns |  9.298 ns |  8.698 ns |
|   AgileMapperMap | 1,077.69 ns |  9.797 ns |  9.164 ns |
|    AutoMapperMap | 1,552.69 ns | 26.885 ns | 25.148 ns |
|       MapsterMap |   969.29 ns | 18.596 ns | 17.394 ns |
|     StaticsMapperMap |   225.72 ns |  3.593 ns |  3.361 ns |
| HigLaboMapperMap |   106.74 ns |  0.647 ns |  0.605 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap |   524.64 ns |  7.949 ns |  7.047 ns |
|   PowerMapperMap |    85.87 ns |  1.106 ns |  0.981 ns |
|    SafeMapperMap |   402.43 ns |  5.445 ns |  5.093 ns |

Benchmarks with issues:
  From_TS1_To_TS1_0.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
