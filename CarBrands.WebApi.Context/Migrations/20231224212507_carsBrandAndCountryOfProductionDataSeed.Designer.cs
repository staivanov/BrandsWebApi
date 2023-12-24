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
    [Migration("20231224212507_carsBrandAndCountryOfProductionDataSeed")]
    partial class carsBrandAndCountryOfProductionDataSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

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

                    b.Property<int>("HeadquarterId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("Slogan")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("HeadquarterId");

                    b.ToTable("CarBrands");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateCreated = new DateOnly(1931, 1, 1),
                            Description = "Dr. Ing. h.c. F. Porsche AG, usually shortened to Porsche,\r\n                                        is a German automobile manufacturer specializing in high-performance sports cars, SUVs and sedans",
                            HeadquarterId = 1,
                            Name = "Porsche",
                            Slogan = "There is no substitute."
                        },
                        new
                        {
                            Id = 2,
                            DateCreated = new DateOnly(1916, 3, 7),
                            Description = "The BMW Group is the world's leading provider of premium cars and motorcycles and the home of the BMW, MINI,\r\n                        Rolls-Royce and BMW Motorrad brands. Our vehicles and products are tailored to the needs of our customers and constantly enhanced –\r\n                        with a clear focus on sustainability and the conservation of resources.",
                            HeadquarterId = 2,
                            Name = "BMW",
                            Slogan = "Sheer Driving Pleasure"
                        },
                        new
                        {
                            Id = 3,
                            DateCreated = new DateOnly(1927, 7, 28),
                            Description = "With Mercedes-Benz AG, we are one of the leading global suppliers of\r\n                        high-end passenger cars and premium vans.\r\n                                            Mercedes-Benz Mobility AG offers financing, leasing, car subscription and car rental,\r\n                        fleet management, digital services for charging and payment,\r\n                    insurance brokerage, as well as innovative mobility services.",
                            HeadquarterId = 3,
                            Name = "Mercedes"
                        },
                        new
                        {
                            Id = 4,
                            DateCreated = new DateOnly(1937, 5, 28),
                            Description = "The Volkswagen brand is one of the largest car manufacturers in the world. For more than 70 years,\r\n                        we have been making innovative technologies, the highest quality and attractive designs accessible to many people – with the likes \r\n                        of bestsellers such as the Beetle, the Golf and the all-electric ID.",
                            HeadquarterId = 4,
                            Name = "VW"
                        },
                        new
                        {
                            Id = 5,
                            DateCreated = new DateOnly(1862, 1, 21),
                            Description = "Opel AG, German automotive company, a wholly owned subsidiary of Stellantis NV, specializing in the manufacture of passenger\r\n                        cars and light vans. ",
                            HeadquarterId = 5,
                            Name = "Opel"
                        },
                        new
                        {
                            Id = 6,
                            DateCreated = new DateOnly(1909, 7, 16),
                            Description = "Audi AG (Audi) a subsidiary of Volkswagen AG, is an automobile manufacturer. It designs, develops, \r\n                        manufactures, and commercializes premium cars, and motorcycles globally.",
                            HeadquarterId = 6,
                            Name = "Audi"
                        },
                        new
                        {
                            Id = 7,
                            DateCreated = new DateOnly(1937, 8, 28),
                            Description = "Toyota Motor Corp (Toyota) is an automobile manufacturer. The company designs, manufactures and sells passenger cars, \r\n                        buses, minivans, trucks, specialty cars, recreational and sport-utility vehicles.",
                            HeadquarterId = 7,
                            Name = "Toyota"
                        },
                        new
                        {
                            Id = 8,
                            DateCreated = new DateOnly(1948, 9, 24),
                            Description = "Honda is a mobility company powered by everyone’s dreams, creating mobility that helps and inspires people,\r\n                        in a wide range of fields such including motorcycles, automobiles, power products and aircraft.",
                            HeadquarterId = 8,
                            Name = "Honda"
                        },
                        new
                        {
                            Id = 9,
                            DateCreated = new DateOnly(1989, 1, 18),
                            Description = "Lexus (レクサス, Rekusasu) is the luxury vehicle division of the Japanese automaker Toyota Motor Corporation.\r\n                        The Lexus brand is marketed in more than 90 countries and territories worldwide and is Japan's largest-selling make of premium cars.\r\n                        It has ranked among the 10 largest Japanese global brands in market value.",
                            HeadquarterId = 9,
                            Name = "Lexus"
                        },
                        new
                        {
                            Id = 10,
                            DateCreated = new DateOnly(1920, 1, 30),
                            Description = "Mazda Motor Corporation (マツダ株式会社, Matsuda Kabushiki gaisha), also known as simply Mazda, is a Japanese multinational\r\n                        automotive manufacturer headquartered in Fuchū, Hiroshima, Japan.",
                            HeadquarterId = 10,
                            Name = "Mazda"
                        });
                });

            modelBuilder.Entity("CarBrands.WebApi.Domain.Entities.CarBrandCountryOfProduction", b =>
                {
                    b.Property<int>("CarBrandId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("CountryOfProductionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CarBrandId", "CountryOfProductionId");

                    b.HasIndex("CountryOfProductionId");

                    b.ToTable("CarBrandCountryOfProduction");
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarBrandId = 1,
                            CoupeType = 2,
                            DateCreated = new DateOnly(2009, 4, 5),
                            Description = "The Porsche Panamera is a mid/full-sized luxury car (E-segment or F-segment for LWB in Europe) manufactured and marketed by German automobile manufacturer Porsche across two generations using a front-engine, rear or all-wheel drive configuration.",
                            Name = "Panamera",
                            NumberOfDoors = 4,
                            ProducedUnits = 30000
                        },
                        new
                        {
                            Id = 2,
                            CarBrandId = 1,
                            CoupeType = 11,
                            DateCreated = new DateOnly(2019, 7, 30),
                            Description = "The Porsche 911 (pronounced Nine Eleven or in German: Neunelf) is a two-door 2+2 high performance rear-engined sports car introduced in September 1964 by Porsche AG of Stuttgart, Germany. It has a rear-mounted flat-six engine and originally a torsion bar suspension.The car has been continuously enhanced through the years but the basic concept has remained unchanged.The engines were air-cooled until the introduction of the 996 series in 1998.",
                            Name = "911 - 992 Series",
                            NumberOfDoors = 2,
                            ProducedUnits = 10000
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Germany is a country located in the heart of Western Europe. It is bordered by Denmark, Poland, Czechia, Austria, Switzerland, France, Luxembourg, Belgium, Netherlands, the North Sea, and the Baltic Sea. Germany has a strategic location on the North European Plain and along the entrance to the Baltic Sea.",
                            ISO3166Code = "DE",
                            Name = "Germany"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Italy is a boot-shaped peninsula that juts out of southern Europe into the Adriatic Sea, Tyrrhenian Sea, Mediterranean Sea, and other waters. Its location has played an important role in its history.",
                            ISO3166Code = "IT",
                            Name = "Italy"
                        },
                        new
                        {
                            Id = 3,
                            Description = "France is one of the oldest nations on Earth and the most ethnically diverse country in Europe. These deep and broad influences have made France a world leader throughout history in nearly all aspects of culture, including cuisine, wine-making, politics, philosophy, music, art, film, fashion, literature, and sports.",
                            ISO3166Code = "FR",
                            Name = "France"
                        },
                        new
                        {
                            Id = 4,
                            Description = "The United Kingdom is a state made up of the historic countries of England, Wales and Scotland, as well as Northern Ireland. It is known as the home of both modern parliamentary democracy and the Industrial Revolution.",
                            ISO3166Code = "GB",
                            Name = "United Kingdom"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Japan is a part of the Ring of Fire, and spans an archipelago of 14,125 islands, with the five main islands being Hokkaido,\r\n                        Honshu (the \"mainland\"), Shikoku, Kyushu, and Okinawa. Tokyo is the nation's capital and largest city, followed by\r\n                        Yokohama, Osaka, Nagoya, Sapporo, Fukuoka, Kobe, and Kyoto.",
                            ISO3166Code = "JP",
                            Name = "Japan"
                        },
                        new
                        {
                            Id = 6,
                            Description = "South Korea, officially the Republic of Korea (ROK), is a country in East Asia. It constitutes the southern part of the \r\n                        Korean Peninsula and borders North Korea along the Korean Demilitarized Zone. The country's western border is formed by the Yellow Sea,\r\n                        while its eastern border is defined by the Sea of Japan.",
                            ISO3166Code = "KR",
                            Name = "South Korea"
                        });
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

                    b.HasKey("Id");

                    b.HasIndex("CarBrandId");

                    b.ToTable("Headquarters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Porscheplatz 1 in 70435 Stuttgart",
                            CarBrandId = 0,
                            DateCreated = new DateOnly(1931, 1, 1),
                            Description = "Main headquarter for Porsche World.",
                            Name = "Porsche Automobil Holding SE"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Am Riesenfeld area of Munich",
                            CarBrandId = 0,
                            DateCreated = new DateOnly(1972, 1, 1),
                            Description = "The building has served as the global corporate headquarters of German automaker BMW since 1973. It was declared a protected historic building in 1999, and it is often cited as one of the most notable examples of modern architecture in Munich. Extensive renovations commenced in 2004 and were completed in 2006.",
                            Name = "BMW Tower"
                        },
                        new
                        {
                            Id = 3,
                            Address = "Mercedesstraße 120\r\n70372 Stuttgart-Untertürkheim",
                            CarBrandId = 0,
                            DateCreated = new DateOnly(1926, 1, 1),
                            Description = "At the Headquarters of our international company at the location of Stuttgart, employees are working in various central functions and services and give the impetus for our way to a successful future.",
                            Name = "Mercedes-Benz Group Headquarters"
                        },
                        new
                        {
                            Id = 4,
                            Address = "Berliner Ring 2, 38440 Wolfsburg",
                            CarBrandId = 0,
                            DateCreated = new DateOnly(1938, 1, 1),
                            Description = "No information is provided.",
                            Name = "Volkswagen Group Tower"
                        },
                        new
                        {
                            Id = 5,
                            Address = "65423 Rüsselsheim am Main",
                            CarBrandId = 0,
                            DateCreated = new DateOnly(1945, 1, 1),
                            Description = "No information is provided.",
                            Name = "Opel Russelsheim Facility"
                        },
                        new
                        {
                            Id = 6,
                            Address = "AUDI AG Auto-Union-Str. 1 85057 Ingolstadt ",
                            CarBrandId = 0,
                            DateCreated = new DateOnly(1949, 1, 1),
                            Description = "The plant in the center of Bavaria is not only the production site of AUDI AG, but also home to Group headquarters and Technical Development. The Audi A3, Audi A4 and Audi A5 model series as well as the Audi Q2 are produced here. In 2022, 332,981 cars will have rolled off the production line at the Ingolstadt site. With 40,118 employees, Audi is the largest employer in the region. The plant is preparing for the production start-up of the first all-electric model, Audi Q6 e-tron. A dedicated battery assembly line is currently being built for this purpose in front of the factory gates. Thanks to extensive flexibilization of the production lines, the site is ideally prepared for the gradual switch to electromobility and the production of further all-electric models.",
                            Name = "Audi Headquarter"
                        },
                        new
                        {
                            Id = 7,
                            Address = "1 Toyota-Cho, Toyota City, Aichi Prefecture 471-8571",
                            CarBrandId = 0,
                            DateCreated = new DateOnly(1976, 1, 1),
                            Description = "Headquarter of one of the biggest in the world comapnies for cars.",
                            Name = "Toyota Motor Corporation HQ"
                        },
                        new
                        {
                            Id = 8,
                            Address = "2-1-1, Minami-Aoyama, Minato-ku",
                            CarBrandId = 0,
                            DateCreated = new DateOnly(1978, 1, 1),
                            Description = "Honda main HQ is Minato. The city is a special ward in the Tokyo Metropolis in Japan. It is also called Minato City in English. It was formed in 1947 as a merger of Akasaka, Azabu and Shiba wards following Tokyo City's transformation into Tokyo Metropolis",
                            Name = "Honda Motor Co. Tower"
                        },
                        new
                        {
                            Id = 9,
                            Address = "6565 Headquarters Dr, Plano, TX 75024",
                            CarBrandId = 0,
                            DateCreated = new DateOnly(1989, 1, 1),
                            Description = "No information is provided.",
                            Name = "Lexus USA Headquarter"
                        },
                        new
                        {
                            Id = 10,
                            Address = "59 Grigore Alexandrescu, HQ Victoriei Building",
                            CarBrandId = 0,
                            DateCreated = new DateOnly(1931, 3, 10),
                            Description = "The head office opened March 1931 and continues to serve as a site for piston engine and transmission production.The facility is 55.1 hectares (136 acres) in size.",
                            Name = "Mazda Japan Co Headquarter"
                        });
                });

            modelBuilder.Entity("CarBrands.WebApi.Domain.Entities.CarBrand", b =>
                {
                    b.HasOne("CarBrands.WebApi.Domain.Entities.Headquarter", "Headquarter")
                        .WithMany()
                        .HasForeignKey("HeadquarterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Headquarter");
                });

            modelBuilder.Entity("CarBrands.WebApi.Domain.Entities.CarBrandCountryOfProduction", b =>
                {
                    b.HasOne("CarBrands.WebApi.Domain.Entities.CarBrand", null)
                        .WithMany("CarBrandCountryOfProductions")
                        .HasForeignKey("CarBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CarBrands.WebApi.Domain.Entities.CountryOfProduction", null)
                        .WithMany("CarBrandCountryOfProductions")
                        .HasForeignKey("CountryOfProductionId")
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
                        .WithMany()
                        .HasForeignKey("CarBrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CarBrand");
                });

            modelBuilder.Entity("CarBrands.WebApi.Domain.Entities.CarBrand", b =>
                {
                    b.Navigation("CarBrandCountryOfProductions");

                    b.Navigation("CarModels");
                });

            modelBuilder.Entity("CarBrands.WebApi.Domain.Entities.CountryOfProduction", b =>
                {
                    b.Navigation("CarBrandCountryOfProductions");
                });
#pragma warning restore 612, 618
        }
    }
}
