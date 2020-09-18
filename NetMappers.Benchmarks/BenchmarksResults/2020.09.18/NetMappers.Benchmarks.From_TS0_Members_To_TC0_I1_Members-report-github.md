``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1082 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host] : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |      Error |    StdDev |
|----------------- |------------:|-----------:|----------:|
| ExpressMapperMap |   828.50 ns |   7.920 ns |  7.408 ns |
|   AgileMapperMap |   448.08 ns |   1.189 ns |  0.993 ns |
|    TinyMapperMap |          NA |         NA |        NA |
|    AutoMapperMap |   437.04 ns |   3.464 ns |  3.240 ns |
|       MapsterMap |   106.45 ns |   2.181 ns |  1.933 ns |
|     AirMapperMap |    62.21 ns |   1.303 ns |  1.648 ns |
| HigLaboMapperMap |   168.83 ns |   1.314 ns |  1.229 ns |
|    FastMapperMap |          NA |         NA |        NA |
| ValueInjecterMap | 9,510.98 ns | 105.360 ns | 93.399 ns |
|   PowerMapperMap |   104.44 ns |   1.818 ns |  1.700 ns |
|    SafeMapperMap |   295.93 ns |   5.937 ns |  6.599 ns |

Benchmarks with issues:
  From_TS0_Members_To_TC0_I1_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TC0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
