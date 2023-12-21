using CarBrands.WebApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using CarBrands.WebApi.Domain.Models;

namespace CarBrands.WebApi.Context
{
    public class CarBrandsContext : DbContext
    {
        public DbSet<CarBrand> CarBrands { get; set; } = null!;
        public DbSet<CarModel> CarModels { get; set; } = null!;
        public DbSet<CountryOfProduction> CountriesOfProduction { get; set; } = null!;
        public DbSet<Headquarter> Headquarters { get; set; } = null!;


        public CarBrandsContext(DbContextOptions<CarBrandsContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CarBrand porscheBrand = new()
            {
                Id = 1,
                Name = "Porsche",
                Description = @"Dr. Ing. h.c. F. Porsche AG, usually shortened to Porsche,
                                is a German automobile manufacturer specializing in high-performance sports cars, SUVs and sedans",
                DateCreated = new DateOnly(1931, 01, 01),
                Slogan = "There is no substitute.",
                HeadquarterId = 1
            };

            List<CarModel> porscheModels = new()
                    {
                        new()
                        {
                            Id = 1,
                            CarBrandId = 1,
                            Name = "Panamera",
                            Description = "The Porsche Panamera is a mid/full-sized luxury car (E-segment or F-segment for LWB in Europe) manufactured" +
                            " and marketed by German automobile manufacturer Porsche across two generations using a front-engine," +
                            " rear or all-wheel drive configuration.",
                            DateCreated = new DateOnly(2009, 4, 5),
                            NumberOfDoors = 4,
                            CoupeType = CoupeType.Limousine,
                            ProducedUnits = 30000
                        },
                        new()
                        {
                            Id = 2,
                            CarBrandId = 1,
                            Name = "911 - 992 Series",
                            Description = "The Porsche 911 (pronounced Nine Eleven or in German: Neunelf) is a two-door 2+2 high performance rear-engined sports car " +
                            "introduced in September 1964 by Porsche AG of Stuttgart, Germany. It has a rear-mounted flat-six engine and originally a torsion bar suspension." +
                            "The car has been continuously enhanced through the years but the basic concept has remained unchanged." +
                            "The engines were air-cooled until the introduction of the 996 series in 1998.",
                            DateCreated = new DateOnly(2019, 7, 30),
                            NumberOfDoors = 2,
                            CoupeType = CoupeType.Coupe,
                            ProducedUnits = 10000
                        }
            };

            Headquarter porscheHeadquarter = new()
            {
                Id = 1,
                CarBrandId = 1,
                Name = "Porsche Automobil Holding SE",
                Description = "Main headquarter for Porsche World.",
                Address = "Porscheplatz 1 in 70435 Stuttgart",
                DateCreated = new DateOnly(1931, 1, 1),
            };

            List<CountryOfProduction> countriesOfProduction = new()
            {
                new() {
                        Id = 1,
                        Name = "Germany",
                        Description = "Germany is a country located in the heart of Western Europe." +
                                       " It is bordered by Denmark, Poland, Czechia, Austria, Switzerland, France, Luxembourg, Belgium, Netherlands, the North Sea," +
                                       " and the Baltic Sea. Germany has a strategic location on the North European Plain and along the entrance to the Baltic Sea.",
                        ISO3166Code = "DE"
                      },
                new() {
                        Id = 2,
                        Name = "Italy",
                        Description = "Italy is a boot-shaped peninsula that juts out of southern Europe into the Adriatic Sea, Tyrrhenian Sea, Mediterranean Sea," +
                        " and other waters. Its location has played an important role in its history.",
                        ISO3166Code = "IT"
                      },
                new() {
                        Id = 3,
                        Name = "France",
                        Description = "France is one of the oldest nations on Earth and the most ethnically diverse country in Europe. These deep and broad influences have made" +
                        " France a world leader throughout history in nearly all aspects of culture, including cuisine" +
                        ", wine-making, politics, philosophy, music, art, film, fashion, literature, and sports.",
                        ISO3166Code = "FR"
                      },
                new() {
                        Id = 4,
                        Name = "United Kingdom",
                        Description = "The United Kingdom is a state made up of the historic countries of England, Wales and Scotland, as well as Northern Ireland." +
                        " It is known as the home of both modern parliamentary democracy and the Industrial Revolution.",
                        ISO3166Code = "GB"
                      },
            };

            modelBuilder.Entity<Headquarter>().HasData(porscheHeadquarter);
            modelBuilder.Entity<CarBrand>().HasData(porscheBrand);
            modelBuilder.Entity<CarModel>().HasData(porscheModels);
            modelBuilder.Entity<CountryOfProduction>().HasData(countriesOfProduction);

        }
    }
}

