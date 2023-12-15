﻿// <auto-generated />
using System;
using CarBrands.WebApi.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarBrands.WebApi.Data.Migrations
{
    [DbContext(typeof(CarBrandsContext))]
    [Migration("20231204085525_HeadquarterFKadded")]
    partial class HeadquarterFKadded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

            modelBuilder.Entity("CarBrandCountryOfProduction", b =>
                {
                    b.Property<int>("CarBrandId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CountriesOfProductionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CarBrandId", "CountriesOfProductionId");

                    b.HasIndex("CountriesOfProductionId");

                    b.ToTable("CarBrandCountryOfProduction");
                });

            modelBuilder.Entity("CarBrands.WebApi.Domain.Entities.CarBrand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly?>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<int>("HeadquartedId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Slogan")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CarBrands");
                });

            modelBuilder.Entity("CarBrands.WebApi.Domain.Entities.CarModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CarBrandId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CoupeType")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfDoors")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProducedUnits")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CarBrandId");

                    b.ToTable("CarModels");
                });

            modelBuilder.Entity("CarBrands.WebApi.Domain.Entities.CountryOfProduction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<string>("ISO3166Code")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("CountriesOfProduction");
                });

            modelBuilder.Entity("CarBrands.WebApi.Domain.Entities.Headquarter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CarBrandId")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly?>("DateCreated")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CarBrandId")
                        .IsUnique();

                    b.ToTable("Headquarters");
                });

            modelBuilder.Entity("CarBrandCountryOfProduction", b =>
                {
                    b.HasOne("CarBrands.WebApi.Domain.Entities.CarBrand", null)
                        .WithMany()
                        .HasForeignKey("CarBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarBrands.WebApi.Domain.Entities.CountryOfProduction", null)
                        .WithMany()
                        .HasForeignKey("CountriesOfProductionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CarBrands.WebApi.Domain.Entities.CarModel", b =>
                {
                    b.HasOne("CarBrands.WebApi.Domain.Entities.CarBrand", "CarBrand")
                        .WithMany("CarModels")
                        .HasForeignKey("CarBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarBrand");
                });

            modelBuilder.Entity("CarBrands.WebApi.Domain.Entities.Headquarter", b =>
                {
                    b.HasOne("CarBrands.WebApi.Domain.Entities.CarBrand", "CarBrand")
                        .WithOne("Headquarter")
                        .HasForeignKey("CarBrands.WebApi.Domain.Entities.Headquarter", "CarBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarBrand");
                });

            modelBuilder.Entity("CarBrands.WebApi.Domain.Entities.CarBrand", b =>
                {
                    b.Navigation("CarModels");

                    b.Navigation("Headquarter")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
