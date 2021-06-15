``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.1016 (1909/November2018Update/19H2)
Intel Core i7-6820HQ CPU 2.70GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.401
  [Host] : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   523.27 ns |  6.940 ns |  6.152 ns |
|   AgileMapperMap | 1,223.16 ns |  4.561 ns |  4.043 ns |
|    TinyMapperMap |          NA |        NA |        NA |
|    AutoMapperMap | 1,393.64 ns | 16.368 ns | 15.310 ns |
|       MapsterMap |   853.54 ns |  0.928 ns |  0.868 ns |
|     StaticsMapperMap |   153.39 ns |  2.809 ns |  2.628 ns |
| HigLaboMapperMap |    84.82 ns |  0.984 ns |  0.822 ns |
|    FastMapperMap |          NA |        NA |        NA |

Benchmarks with issues:
  From_TS1_To_TC1_0.TinyMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
  From_TS1_To_TC1_0.FastMapperMap: InProcess(Toolchain=InProcessEmitToolchain)
