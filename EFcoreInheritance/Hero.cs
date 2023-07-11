using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreInheritance
{
    public abstract class Hero
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HP { get; set; }
    }

    public class HeroConfiguration : IEntityTypeConfiguration<Hero>
    {
        public void Configure(EntityTypeBuilder<Hero> builder)
        {
            //builder.ToTable(nameof(Hero));
            //builder.HasKey(t => t.Id);
            //builder.Property(t => t.Id).UseIdentityColumn(1, 1);

            //TPH
            //builder.UseTphMappingStrategy();

            //builder.HasDiscriminator<int>("HeroType")
            //    .HasValue<ManaHero>(1)
            //    .HasValue<EnergyHero>(2);

            //TPC
            builder.UseTpcMappingStrategy();
        }
    }
}
