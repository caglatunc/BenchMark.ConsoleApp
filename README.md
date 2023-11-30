# BenchMark.ConsoleApp
Performance Measurement with BenchMark

Measurements were made in different scenarios.
In the measurement made between Foreach, For, While and HashSet, While and For were very close to each other in terms of speed. In some scenarios, While was fast, and in others, For. The next order continued as Foreach and HashSet. HashSet was always the slowest.

Another scenario I made was performance measurements on the database.
I created some scenarios using EntityFramework, Dapper, pure SQL code. Here, in terms of speed;
SQL>Dapper>EntityFramework

These results will vary depending on different scenarios.
Below are the images of the measurements I made.
![image](https://github.com/caglatunc/BenchMark.ConsoleApp/assets/95507765/5d78d16b-bbcf-4c23-b221-d6ec76d9939e)

![image](https://github.com/caglatunc/BenchMark.ConsoleApp/assets/95507765/7cf5373d-eefe-4d5b-b8ea-f827604c5fd3)
