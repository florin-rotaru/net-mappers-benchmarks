``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1082 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.402
  [Host] : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |       Mean |    Error |   StdDev |
|----------------- |-----------:|---------:|---------:|
| ExpressMapperMap | 4,556.9 ns | 59.64 ns | 49.80 ns |
|   AgileMapperMap |   695.3 ns | 13.69 ns | 16.81 ns |
|    TinyMapperMap |         NA |       NA |       NA |
|    AutoMapperMap |   778.1 ns | 15.38 ns | 16.46 ns |
|       MapsterMap |   149.4 ns |  0.39 ns |  0.35 ns |
|     StaticsMapperMap |   101.2 ns |  1.87 ns |  1.66 ns |
| HigLaboMapperMap |   630.4 ns |  9.67 ns |  9.04 ns |
|    FastMapperMap |         NA |       NA |       NA |
| ValueInjecterMap | 2,622.4 ns | 33.49 ns | 29.69 ns |
|   PowerMapperMap |   154.2 ns |  2.99 ns |  2.80 ns |
|    SafeMapperMap |   363.6 ns |  6.96 ns |  6.51 ns |

Benchmarks with issues:
  From_TS0_Members_To_TS0_I2_Nullable_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS0_Members_To_TS0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
