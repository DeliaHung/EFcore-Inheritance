using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreInheritance
{
    public class ManaHero : Hero
    {
        public int Mana { get; set; }
    }

    public class ManaHeroConfiguration : IEntityTypeConfiguration<ManaHero>
    {
        public void Configure(EntityTypeBuilder<ManaHero> builder)
        {
            builder.ToTable(nameof(ManaHero));
        }
    }
}
