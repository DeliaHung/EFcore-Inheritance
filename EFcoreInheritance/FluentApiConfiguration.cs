using EFcoreInheritance.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFcoreInheritance;

public class AnimalConfiguration : IEntityTypeConfiguration<Animal>
{
    public void Configure(EntityTypeBuilder<Animal> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Id).UseIdentityColumn(1, 1);//TPC模式記得拿掉
        builder.UseTptMappingStrategy();

        //TPT
        //builder.UseTptMappingStrategy();

        ////TPH(預設，所以可以不寫)
        //builder.UseTphMappingStrategy();

        ////識別器指定Type及Value。
        //builder.HasDiscriminator<int>("AnimalType")
        //    .HasValue<Cat>(1)
        //    .HasValue<Dog>(2)
        //    .HasValue<Human>(3);

        ////將識別器寫在類別中
        //builder.HasDiscriminator(d => d.AnimalType)
        //    .HasValue<Cat>(1)
        //    .HasValue<Dog>(2)
        //    .HasValue<Human>(3);

        //TPC
        //builder.UseTpcMappingStrategy();
    }
}