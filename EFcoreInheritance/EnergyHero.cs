using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreInheritance
{
    public class EnergyHero : Hero
    {
        public int Energy { get; set; }
    }

    public class EnerhyHeroConfiguration : IEntityTypeConfiguration<EnergyHero>
    {
        public void Configure(EntityTypeBuilder<EnergyHero> builder)
        {
            builder.ToTable(nameof(EnergyHero));
        }
    }
}
