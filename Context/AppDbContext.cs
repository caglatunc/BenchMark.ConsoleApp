using Bogus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchMark.ConsoleApp.Context;
public sealed class AppDbContext: DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=CAGLA\\SQLEXPRESS;Initial Catalog=BenchMarkTestDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }

    //public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<User> users = new ();
        var faker = new Faker();

        for(int i = 0; i < 10000;i++)
        {
            User user = new()
            {
                Id = i + 1,
                Name = faker.Name.FirstName(),
                Lastname = faker.Name.LastName(),
            };
            users.Add(user);
        }
        modelBuilder.Entity<User>().ToTable("Users");

        modelBuilder
            .Entity<User>()
            .HasData(users);
    }
}
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
}