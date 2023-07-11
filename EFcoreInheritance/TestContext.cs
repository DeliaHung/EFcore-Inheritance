using EFcoreInheritance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Reflection;

namespace EFcoreConcurrency
{
    public class TestContext : DbContext
    {
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<ManaHero> ManaHeroes { get; set; }
        public DbSet<EnergyHero> EnergyHeroes { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EFInheritance;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")
                .LogTo((message) => Console.WriteLine("【TestContext:】" + message + "\r\n"), LogLevel.Information)
                ;
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
