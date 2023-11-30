# BenchMark.ConsoleApp

This project utilizes the BenchMark library for performance measurements.

## About Performance Measurements

Measurements were conducted in different scenarios:

1. **Loop Comparison:**
   - `Foreach`
   - `For`
   - `While`
   - `HashSet`

   `While` and `For` loops were very close to each other in terms of speed. In some scenarios, `While` was faster, and in others, `For`. The next order continued as `Foreach` and `HashSet`. `HashSet` was always the slowest.

2. **Database Performance:**
   - `SQL`
   - `Dapper`
   - `EntityFramework`

   In terms of speed in database measurements, the order is as follows: `SQL > Dapper > EntityFramework`

These results may vary depending on different scenarios.

## Images from Measurements

![Measurement Image 1](https://github.com/caglatunc/BenchMark.ConsoleApp/assets/95507765/5d78d16b-bbcf-4c23-b221-d6ec76d9939e)

![Measurement Image 2](https://github.com/caglatunc/BenchMark.ConsoleApp/assets/95507765/7cf5373d-eefe-4d5b-b8ea-f827604c5fd3)

## Used Libraries

- **Benchmark Library:** For performance measurement
- **Bogus Library:** For loading fake data
- **Dapper and EntityFrameworkCore.SqlServer, EntityFrameworkCore.Tools:** For database measurements

