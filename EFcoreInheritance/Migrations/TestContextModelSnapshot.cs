﻿// <auto-generated />
using System;
using EFcoreInheritance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFcoreInheritance.Migrations
{
    [DbContext(typeof(TestContext))]
    partial class TestContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFcoreInheritance.Entity.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Animals");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Animal");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("HumanPet", b =>
                {
                    b.Property<int>("HumansId")
                        .HasColumnType("int");

                    b.Property<int>("PetsId")
                        .HasColumnType("int");

                    b.HasKey("HumansId", "PetsId");

                    b.HasIndex("PetsId");

                    b.ToTable("HumanPet");
                });

            modelBuilder.Entity("EFcoreInheritance.Entity.Human", b =>
                {
                    b.HasBaseType("EFcoreInheritance.Entity.Animal");

                    b.Property<int?>("FavoriteAnimalId")
                        .HasColumnType("int");

                    b.HasIndex("FavoriteAnimalId");

                    b.HasDiscriminator().HasValue("Human");
                });

            modelBuilder.Entity("EFcoreInheritance.Entity.Pet", b =>
                {
                    b.HasBaseType("EFcoreInheritance.Entity.Animal");

                    b.Property<string>("Vet")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Pet");
                });

            modelBuilder.Entity("EFcoreInheritance.Entity.Cat", b =>
                {
                    b.HasBaseType("EFcoreInheritance.Entity.Pet");

                    b.Property<int>("EducationLevel")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Cat");
                });

            modelBuilder.Entity("EFcoreInheritance.Entity.Dog", b =>
                {
                    b.HasBaseType("EFcoreInheritance.Entity.Pet");

                    b.Property<string>("FavoriteToy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Dog");
                });

            modelBuilder.Entity("HumanPet", b =>
                {
                    b.HasOne("EFcoreInheritance.Entity.Human", null)
                        .WithMany()
                        .HasForeignKey("HumansId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("EFcoreInheritance.Entity.Pet", null)
                        .WithMany()
                        .HasForeignKey("PetsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFcoreInheritance.Entity.Human", b =>
                {
                    b.HasOne("EFcoreInheritance.Entity.Animal", "FavoriteAnimal")
                        .WithMany()
                        .HasForeignKey("FavoriteAnimalId");

                    b.Navigation("FavoriteAnimal");
                });
#pragma warning restore 612, 618
        }
    }
}
