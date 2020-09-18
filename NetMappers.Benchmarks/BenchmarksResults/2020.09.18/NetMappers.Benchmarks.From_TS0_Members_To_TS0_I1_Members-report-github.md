``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1082 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host] : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 3,946.68 ns | 27.521 ns | 22.981 ns |
|   AgileMapperMap |   536.94 ns |  7.852 ns |  6.961 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   547.17 ns | 10.754 ns | 10.562 ns |
|       MapsterMap |   115.45 ns |  1.772 ns |  1.571 ns |
|     AirMapperMap |    49.87 ns |  0.532 ns |  0.445 ns |
| HigLaboMapperMap |   205.65 ns |  3.438 ns |  3.216 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 9,985.00 ns | 85.729 ns | 80.191 ns |
|   PowerMapperMap |    94.39 ns |  1.731 ns |  1.619 ns |
|    SafeMapperMap |   289.69 ns |  5.010 ns |  4.686 ns |

Benchmarks with issues:
  From_TS0_Members_To_TS0_I1_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TS0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
