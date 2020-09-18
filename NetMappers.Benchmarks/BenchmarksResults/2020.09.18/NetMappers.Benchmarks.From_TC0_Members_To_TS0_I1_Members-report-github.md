``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1082 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host] : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |      Error |     StdDev |
|----------------- |------------:|-----------:|-----------:|
| ExpressMapperMap | 3,331.69 ns |  66.422 ns |  93.114 ns |
|   AgileMapperMap |   352.34 ns |   6.563 ns |   5.818 ns |
|    TinyMapperMap |          NA |         NA |         NA |
|    AutoMapperMap |   266.61 ns |   5.168 ns |   4.581 ns |
|       MapsterMap |    87.14 ns |   1.548 ns |   1.448 ns |
|     AirMapperMap |    38.23 ns |   0.727 ns |   0.680 ns |
| HigLaboMapperMap |   135.61 ns |   0.704 ns |   0.588 ns |
|    FastMapperMap |          NA |         NA |         NA |
| ValueInjecterMap | 9,573.41 ns | 186.555 ns | 255.359 ns |
|   PowerMapperMap |    86.11 ns |   1.232 ns |   1.152 ns |
|    SafeMapperMap |   237.10 ns |   0.804 ns |   0.628 ns |

Benchmarks with issues:
  From_TC0_Members_To_TS0_I1_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TC0_Members_To_TS0_I1_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
