``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1082 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host] : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |      Error |     StdDev |
|----------------- |------------:|-----------:|-----------:|
| ExpressMapperMap | 2,275.27 ns |  23.884 ns |  21.173 ns |
|   AgileMapperMap |   366.88 ns |   7.022 ns |   6.569 ns |
|    TinyMapperMap |          NA |         NA |         NA |
|    AutoMapperMap |   210.45 ns |   3.954 ns |   3.699 ns |
|       MapsterMap |    70.11 ns |   1.286 ns |   1.203 ns |
|     AirMapperMap |    33.87 ns |   0.492 ns |   0.461 ns |
| HigLaboMapperMap |   112.45 ns |   1.796 ns |   1.680 ns |
|    FastMapperMap |          NA |         NA |         NA |
| ValueInjecterMap | 6,375.26 ns | 126.478 ns | 207.807 ns |
|   PowerMapperMap |    66.54 ns |   1.156 ns |   1.025 ns |
|    SafeMapperMap |   221.98 ns |   4.449 ns |   5.463 ns |

Benchmarks with issues:
  From_TC0_Members_To_TS0_I0_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TC0_Members_To_TS0_I0_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
