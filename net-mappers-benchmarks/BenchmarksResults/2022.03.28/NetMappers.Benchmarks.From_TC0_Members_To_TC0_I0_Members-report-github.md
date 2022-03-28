``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.14393.5006 (1607/AnniversaryUpdate/Redstone1)
Intel Xeon CPU E5-2695 v3 2.30GHz, 1 CPU, 16 logical and 16 physical cores
.NET SDK=6.0.201
  [Host] : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|           Method |        Mean |     Error |    StdDev |
|----------------- |------------:|----------:|----------:|
| ExpressMapperMap |   168.34 ns |  1.197 ns |  1.061 ns |
|   AgileMapperMap |   273.10 ns |  3.209 ns |  3.002 ns |
|    TinyMapperMap |    54.06 ns |  0.482 ns |  0.451 ns |
|    AutoMapperMap |   149.66 ns |  1.516 ns |  1.418 ns |
|       MapsterMap |    53.07 ns |  1.090 ns |  1.071 ns |
| StaticsMapperMap |    27.23 ns |  0.171 ns |  0.160 ns |
|    FastMapperMap |   448.35 ns |  4.922 ns |  4.363 ns |
| ValueInjecterMap | 5,871.58 ns | 64.269 ns | 60.118 ns |
