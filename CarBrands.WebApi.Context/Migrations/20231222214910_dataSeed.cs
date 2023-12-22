using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBrands.WebApi.Data.Migrations
{
    public partial class dataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CountriesOfProduction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ISO3166Code = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountriesOfProduction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarBrandCountryOfProduction",
                columns: table => new
                {
                    CarBrandId = table.Column<int>(type: "INTEGER", nullable: false),
                    CountryOfProductionId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarBrandCountryOfProduction", x => new { x.CarBrandId, x.CountryOfProductionId });
                    table.ForeignKey(
                        name: "FK_CarBrandCountryOfProduction_CountriesOfProduction_CountryOfProductionId",
                        column: x => x.CountryOfProductionId,
                        principalTable: "CountriesOfProduction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateCreated = table.Column<DateOnly>(type: "TEXT", nullable: true),
                    Slogan = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    HeadquarterId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarBrands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateCreated = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    ProducedUnits = table.Column<int>(type: "INTEGER", nullable: false),
                    NumberOfDoors = table.Column<int>(type: "INTEGER", nullable: false),
                    CoupeType = table.Column<int>(type: "INTEGER", nullable: false),
                    CarBrandId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarModels_CarBrands_CarBrandId",
                        column: x => x.CarBrandId,
                        principalTable: "CarBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Headquarters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DateCreated = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    CarBrandId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Headquarters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Headquarters_CarBrands_CarBrandId",
                        column: x => x.CarBrandId,
                        principalTable: "CarBrands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CarBrands",
                columns: new[] { "Id", "DateCreated", "Description", "HeadquarterId", "Name", "Slogan" },
                values: new object[] { 1, new DateOnly(1931, 1, 1), "Dr. Ing. h.c. F. Porsche AG, usually shortened to Porsche,\r\n                                        is a German automobile manufacturer specializing in high-performance sports cars, SUVs and sedans", 1, "Porsche", "There is no substitute." });

            migrationBuilder.InsertData(
                table: "CountriesOfProduction",
                columns: new[] { "Id", "Description", "ISO3166Code", "Name" },
                values: new object[] { 1, "Germany is a country located in the heart of Western Europe. It is bordered by Denmark, Poland, Czechia, Austria, Switzerland, France, Luxembourg, Belgium, Netherlands, the North Sea, and the Baltic Sea. Germany has a strategic location on the North European Plain and along the entrance to the Baltic Sea.", "DE", "Germany" });

            migrationBuilder.InsertData(
                table: "CountriesOfProduction",
                columns: new[] { "Id", "Description", "ISO3166Code", "Name" },
                values: new object[] { 2, "Italy is a boot-shaped peninsula that juts out of southern Europe into the Adriatic Sea, Tyrrhenian Sea, Mediterranean Sea, and other waters. Its location has played an important role in its history.", "IT", "Italy" });

            migrationBuilder.InsertData(
                table: "CountriesOfProduction",
                columns: new[] { "Id", "Description", "ISO3166Code", "Name" },
                values: new object[] { 3, "France is one of the oldest nations on Earth and the most ethnically diverse country in Europe. These deep and broad influences have made France a world leader throughout history in nearly all aspects of culture, including cuisine, wine-making, politics, philosophy, music, art, film, fashion, literature, and sports.", "FR", "France" });

            migrationBuilder.InsertData(
                table: "CountriesOfProduction",
                columns: new[] { "Id", "Description", "ISO3166Code", "Name" },
                values: new object[] { 4, "The United Kingdom is a state made up of the historic countries of England, Wales and Scotland, as well as Northern Ireland. It is known as the home of both modern parliamentary democracy and the Industrial Revolution.", "GB", "United Kingdom" });

            migrationBuilder.InsertData(
                table: "Headquarters",
                columns: new[] { "Id", "Address", "CarBrandId", "DateCreated", "Description", "Name" },
                values: new object[] { 2, "Am Riesenfeld area of Munich", 0, new DateOnly(1972, 1, 1), "The building has served as the global corporate headquarters of German automaker BMW since 1973. It was declared a protected historic building in 1999, and it is often cited as one of the most notable examples of modern architecture in Munich. Extensive renovations commenced in 2004 and were completed in 2006.", "BMW Tower" });

            migrationBuilder.InsertData(
                table: "Headquarters",
                columns: new[] { "Id", "Address", "CarBrandId", "DateCreated", "Description", "Name" },
                values: new object[] { 3, "Mercedesstraße 120\r\n70372 Stuttgart-Untertürkheim", 0, new DateOnly(1926, 1, 1), "At the Headquarters of our international company at the location of Stuttgart, employees are working in various central functions and services and give the impetus for our way to a successful future.", "Mercedes-Benz Group Headquarters" });

            migrationBuilder.InsertData(
                table: "Headquarters",
                columns: new[] { "Id", "Address", "CarBrandId", "DateCreated", "Description", "Name" },
                values: new object[] { 4, "Berliner Ring 2, 38440 Wolfsburg", 0, new DateOnly(1938, 1, 1), "No information is provided.", "Volkswagen Group Tower" });

            migrationBuilder.InsertData(
                table: "CarBrands",
                columns: new[] { "Id", "DateCreated", "Description", "HeadquarterId", "Name", "Slogan" },
                values: new object[] { 2, new DateOnly(1916, 3, 7), "The BMW Group is the world's leading provider of premium cars and motorcycles and the home of the BMW, MINI,\r\n                        Rolls-Royce and BMW Motorrad brands. Our vehicles and products are tailored to the needs of our customers and constantly enhanced –\r\n                        with a clear focus on sustainability and the conservation of resources.", 2, "BMW", "Sheer Driving Pleasure" });

            migrationBuilder.InsertData(
                table: "CarBrands",
                columns: new[] { "Id", "DateCreated", "Description", "HeadquarterId", "Name", "Slogan" },
                values: new object[] { 3, new DateOnly(1927, 7, 28), "With Mercedes-Benz AG, we are one of the leading global suppliers of\r\n                        high-end passenger cars and premium vans.\r\n                                            Mercedes-Benz Mobility AG offers financing, leasing, car subscription and car rental,\r\n                        fleet management, digital services for charging and payment,\r\n                    insurance brokerage, as well as innovative mobility services.", 3, "Mercedes", null });

            migrationBuilder.InsertData(
                table: "CarBrands",
                columns: new[] { "Id", "DateCreated", "Description", "HeadquarterId", "Name", "Slogan" },
                values: new object[] { 4, new DateOnly(1937, 5, 28), "The Volkswagen brand is one of the largest car manufacturers in the world. For more than 70 years,\r\n                        we have been making innovative technologies, the highest quality and attractive designs accessible to many people – with the likes \r\n                        of bestsellers such as the Beetle, the Golf and the all-electric ID.", 4, "VW", null });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "CarBrandId", "CoupeType", "DateCreated", "Description", "Name", "NumberOfDoors", "ProducedUnits" },
                values: new object[] { 1, 1, 2, new DateOnly(2009, 4, 5), "The Porsche Panamera is a mid/full-sized luxury car (E-segment or F-segment for LWB in Europe) manufactured and marketed by German automobile manufacturer Porsche across two generations using a front-engine, rear or all-wheel drive configuration.", "Panamera", 4, 30000 });

            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "CarBrandId", "CoupeType", "DateCreated", "Description", "Name", "NumberOfDoors", "ProducedUnits" },
                values: new object[] { 2, 1, 11, new DateOnly(2019, 7, 30), "The Porsche 911 (pronounced Nine Eleven or in German: Neunelf) is a two-door 2+2 high performance rear-engined sports car introduced in September 1964 by Porsche AG of Stuttgart, Germany. It has a rear-mounted flat-six engine and originally a torsion bar suspension.The car has been continuously enhanced through the years but the basic concept has remained unchanged.The engines were air-cooled until the introduction of the 996 series in 1998.", "911 - 992 Series", 2, 10000 });

            migrationBuilder.CreateIndex(
                name: "IX_CarBrandCountryOfProduction_CountryOfProductionId",
                table: "CarBrandCountryOfProduction",
                column: "CountryOfProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_CarBrands_HeadquarterId",
                table: "CarBrands",
                column: "HeadquarterId");

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_CarBrandId",
                table: "CarModels",
                column: "CarBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Headquarters_CarBrandId",
                table: "Headquarters",
                column: "CarBrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarBrandCountryOfProduction_CarBrands_CarBrandId",
                table: "CarBrandCountryOfProduction",
                column: "CarBrandId",
                principalTable: "CarBrands",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CarBrands_Headquarters_HeadquarterId",
                table: "CarBrands",
                column: "HeadquarterId",
                principalTable: "Headquarters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Headquarters_CarBrands_CarBrandId",
                table: "Headquarters");

            migrationBuilder.DropTable(
                name: "CarBrandCountryOfProduction");

            migrationBuilder.DropTable(
                name: "CarModels");

            migrationBuilder.DropTable(
                name: "CountriesOfProduction");

            migrationBuilder.DropTable(
                name: "CarBrands");

            migrationBuilder.DropTable(
                name: "Headquarters");
        }
    }
}
