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
            List<CarBrand> brands = new()
            {
                new()
                    {
                        Id = 1,
                        Name = "Porsche",
                        Description = @"Dr. Ing. h.c. F. Porsche AG, usually shortened to Porsche,
                                        is a German automobile manufacturer specializing in high-performance sports cars, SUVs and sedans",
                        DateCreated = new DateOnly(1931, 01, 01),
                        Slogan = "There is no substitute.",
                        HeadquarterId = 1,
                 },
                new()
                 {
                     Id = 2,
                     Name = "BMW",
                     Description = @"The BMW Group is the world's leading provider of premium cars and motorcycles and the home of the BMW, MINI,
                        Rolls-Royce and BMW Motorrad brands. Our vehicles and products are tailored to the needs of our customers and constantly enhanced –
                        with a clear focus on sustainability and the conservation of resources.",
                     DateCreated = new DateOnly(1916, 3, 7),
                     Slogan = "Sheer Driving Pleasure",
                     HeadquarterId = 2,
                 },
                new()
                {
                    Id = 3,
                    Name = "Mercedes",
                    Description = @"With Mercedes-Benz AG, we are one of the leading global suppliers of
                        high-end passenger cars and premium vans.
                                            Mercedes-Benz Mobility AG offers financing, leasing, car subscription and car rental,
                        fleet management, digital services for charging and payment,
                    insurance brokerage, as well as innovative mobility services.",
                    DateCreated = new DateOnly(1927, 7, 28),
                    HeadquarterId = 3
                },
                new()
                {
                    Id = 4,
                    Name = "VW",
                    Description = @"The Volkswagen brand is one of the largest car manufacturers in the world. For more than 70 years,
                        we have been making innovative technologies, the highest quality and attractive designs accessible to many people – with the likes 
                        of bestsellers such as the Beetle, the Golf and the all-electric ID.",
                    DateCreated = new DateOnly(1937, 5, 28),
                    HeadquarterId = 4
                },

            };

            List<CarModel> carModels = new()
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

            Headquarter[] headquarters =
            {
                //new(1, "Porsche Automobil Holding SE", "Main headquarter for Porsche World.",
                //"Porscheplatz 1 in 70435 Stuttgart", new DateOnly(1931, 1, 1)),
                new(2, "BMW Tower", "The building has served as the global corporate headquarters of German automaker BMW since 1973." +
                " It was declared a protected historic building in 1999, and it is often cited as one of " +
                "the most notable examples of modern architecture in Munich. " +
                "Extensive renovations commenced in 2004 and were completed in 2006.", "Am Riesenfeld area of Munich", new DateOnly(1972, 1,1)),
                new(3, "Mercedes-Benz Group Headquarters", "At the Headquarters of our international company at the location of Stuttgart," +
                " employees are working in various central functions and services and give " +
                "the impetus for our way to a successful future.", "Mercedesstraße 120\r\n70372 Stuttgart-Untertürkheim", new DateOnly(1926, 1,1)),
                new(4, "Volkswagen Group Tower", "No information is provided.", "Berliner Ring 2, 38440 Wolfsburg", new DateOnly(1938,1,1)),
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

            modelBuilder.Entity<Headquarter>().HasData(headquarters);
            modelBuilder.Entity<CarBrand>().HasData(brands);
            modelBuilder.Entity<CarModel>().HasData(carModels);
            modelBuilder.Entity<CountryOfProduction>().HasData(countriesOfProduction);
            modelBuilder.Entity<CarBrand>()
                .HasMany(c => c.CountriesOfProduction)
                .WithMany(b => b.CarBrand)
                .UsingEntity<CarBrandCountryOfProduction>();
        }
    }
}

