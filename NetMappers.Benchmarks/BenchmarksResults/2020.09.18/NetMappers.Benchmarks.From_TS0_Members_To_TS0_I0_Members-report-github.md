``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1082 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host] : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap | 2,837.70 ns | 11.237 ns |  9.383 ns |
|   AgileMapperMap |   488.16 ns |  1.840 ns |  1.537 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap |   418.92 ns |  6.634 ns |  5.540 ns |
|       MapsterMap |   105.49 ns |  0.875 ns |  0.776 ns |
|     AirMapperMap |    44.35 ns |  0.733 ns |  0.649 ns |
| HigLaboMapperMap |   175.41 ns |  0.312 ns |  0.276 ns |
|    FastMapperMap |          NA |        NA |        NA |
| ValueInjecterMap | 6,276.30 ns | 65.145 ns | 60.936 ns |
|   PowerMapperMap |    78.73 ns |  1.528 ns |  1.429 ns |
|    SafeMapperMap |   275.75 ns |  3.556 ns |  3.152 ns |

Benchmarks with issues:
  From_TS0_Members_To_TS0_I0_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TS0_I0_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
