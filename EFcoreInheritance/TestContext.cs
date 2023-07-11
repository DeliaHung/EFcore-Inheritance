using EFcoreInheritance.Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EFcoreInheritance;

public class TestContext : DbContext
{
    public DbSet<Animal> Animals { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public DbSet<Cat> Cats { get; set; }
    public DbSet<Dog> Dogs { get; set; }
    public DbSet<Human> Humans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //可準備不同資料庫
        optionsBuilder.UseSqlServer("Data Source=DESKTOP-9F0J9EK;Initial Catalog=EFInheritanceTPC;Integrated Security=True;TrustServerCertificate=True");
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }
}
