```

BenchmarkDotNet v0.13.10, Windows 11 (10.0.22621.2715/22H2/2022Update/SunValley2)
12th Gen Intel Core i7-12700H, 1 CPU, 20 logical and 14 physical cores
.NET SDK 7.0.306
  [Host]   : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method               | Mean      | Error     | StdDev    | Ratio        | RatioSD |
|--------------------- |----------:|----------:|----------:|-------------:|--------:|
| ToList               |  7.789 ms | 1.0861 ms | 0.0595 ms |     baseline |         |
| FromSqlRaw           |  7.975 ms | 2.7090 ms | 0.1485 ms | 1.02x slower |   0.01x |
| SqlQueryRaw          |        NA |        NA |        NA |            ? |       ? |
| ToListAsync          | 12.143 ms | 4.7946 ms | 0.2628 ms | 1.56x slower |   0.02x |
| FromSqlRawAsync      | 11.645 ms | 1.5849 ms | 0.0869 ms | 1.50x slower |   0.02x |
| SqlQueryRawAsync     |        NA |        NA |        NA |            ? |       ? |
| ExecuteNonQuery      |  3.779 ms | 1.9024 ms | 0.1043 ms | 2.06x faster |   0.04x |
| ExecuteNonQueryAsync |  3.841 ms | 0.9061 ms | 0.0497 ms | 2.03x faster |   0.02x |
| DapperSqlQuery       |  3.921 ms | 1.7165 ms | 0.0941 ms | 1.99x faster |   0.06x |
| DapperSqlQueryAsync  |  5.304 ms | 1.1619 ms | 0.0637 ms | 1.47x faster |   0.03x |

Benchmarks with issues:
  BenchMarkService.SqlQueryRaw: ShortRun(IterationCount=3, LaunchCount=1, WarmupCount=3)
  BenchMarkService.SqlQueryRawAsync: ShortRun(IterationCount=3, LaunchCount=1, WarmupCount=3)
