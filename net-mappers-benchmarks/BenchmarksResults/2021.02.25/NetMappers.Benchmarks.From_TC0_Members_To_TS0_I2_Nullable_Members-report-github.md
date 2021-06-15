``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1379 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=5.0.103
  [Host] : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |    Error |   StdDev |
|----------------- |------------:|---------:|---------:|
| ExpressMapperMap | 3,864.93 ns | 8.692 ns | 7.706 ns |
|   AgileMapperMap |   469.58 ns | 3.665 ns | 3.249 ns |
|    TinyMapperMap |          NA |       NA |       NA |
|    AutoMapperMap |   486.95 ns | 8.192 ns | 7.663 ns |
|       MapsterMap |   113.59 ns | 0.449 ns | 0.398 ns |
|     StaticsMapperMap |    70.37 ns | 0.449 ns | 0.375 ns |
|    FastMapperMap |          NA |       NA |       NA |
| ValueInjecterMap | 2,245.93 ns | 8.674 ns | 7.689 ns |
|    SafeMapperMap |   242.78 ns | 3.878 ns | 3.628 ns |

Benchmarks with issues:
  From_TC0_Members_To_TS0_I2_Nullable_Members.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TC0_Members_To_TS0_I2_Nullable_Members.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
