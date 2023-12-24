using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBrands.WebApi.Data.Migrations
{
    public partial class carsBrandAndCountryOfProductionDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CountriesOfProduction",
                columns: new[] { "Id", "Description", "ISO3166Code", "Name" },
                values: new object[] { 5, "Japan is a part of the Ring of Fire, and spans an archipelago of 14,125 islands, with the five main islands being Hokkaido,\r\n                        Honshu (the \"mainland\"), Shikoku, Kyushu, and Okinawa. Tokyo is the nation's capital and largest city, followed by\r\n                        Yokohama, Osaka, Nagoya, Sapporo, Fukuoka, Kobe, and Kyoto.", "JP", "Japan" });

            migrationBuilder.InsertData(
                table: "CountriesOfProduction",
                columns: new[] { "Id", "Description", "ISO3166Code", "Name" },
                values: new object[] { 6, "South Korea, officially the Republic of Korea (ROK), is a country in East Asia. It constitutes the southern part of the \r\n                        Korean Peninsula and borders North Korea along the Korean Demilitarized Zone. The country's western border is formed by the Yellow Sea,\r\n                        while its eastern border is defined by the Sea of Japan.", "KR", "South Korea" });

            migrationBuilder.InsertData(
                table: "Headquarters",
                columns: new[] { "Id", "Address", "CarBrandId", "DateCreated", "Description", "Name" },
                values: new object[] { 1, "Porscheplatz 1 in 70435 Stuttgart", 0, new DateOnly(1931, 1, 1), "Main headquarter for Porsche World.", "Porsche Automobil Holding SE" });

            migrationBuilder.InsertData(
                table: "Headquarters",
                columns: new[] { "Id", "Address", "CarBrandId", "DateCreated", "Description", "Name" },
                values: new object[] { 5, "65423 Rüsselsheim am Main", 0, new DateOnly(1945, 1, 1), "No information is provided.", "Opel Russelsheim Facility" });

            migrationBuilder.InsertData(
                table: "Headquarters",
                columns: new[] { "Id", "Address", "CarBrandId", "DateCreated", "Description", "Name" },
                values: new object[] { 6, "AUDI AG Auto-Union-Str. 1 85057 Ingolstadt ", 0, new DateOnly(1949, 1, 1), "The plant in the center of Bavaria is not only the production site of AUDI AG, but also home to Group headquarters and Technical Development. The Audi A3, Audi A4 and Audi A5 model series as well as the Audi Q2 are produced here. In 2022, 332,981 cars will have rolled off the production line at the Ingolstadt site. With 40,118 employees, Audi is the largest employer in the region. The plant is preparing for the production start-up of the first all-electric model, Audi Q6 e-tron. A dedicated battery assembly line is currently being built for this purpose in front of the factory gates. Thanks to extensive flexibilization of the production lines, the site is ideally prepared for the gradual switch to electromobility and the production of further all-electric models.", "Audi Headquarter" });

            migrationBuilder.InsertData(
                table: "Headquarters",
                columns: new[] { "Id", "Address", "CarBrandId", "DateCreated", "Description", "Name" },
                values: new object[] { 7, "1 Toyota-Cho, Toyota City, Aichi Prefecture 471-8571", 0, new DateOnly(1976, 1, 1), "Headquarter of one of the biggest in the world comapnies for cars.", "Toyota Motor Corporation HQ" });

            migrationBuilder.InsertData(
                table: "Headquarters",
                columns: new[] { "Id", "Address", "CarBrandId", "DateCreated", "Description", "Name" },
                values: new object[] { 8, "2-1-1, Minami-Aoyama, Minato-ku", 0, new DateOnly(1978, 1, 1), "Honda main HQ is Minato. The city is a special ward in the Tokyo Metropolis in Japan. It is also called Minato City in English. It was formed in 1947 as a merger of Akasaka, Azabu and Shiba wards following Tokyo City's transformation into Tokyo Metropolis", "Honda Motor Co. Tower" });

            migrationBuilder.InsertData(
                table: "Headquarters",
                columns: new[] { "Id", "Address", "CarBrandId", "DateCreated", "Description", "Name" },
                values: new object[] { 9, "6565 Headquarters Dr, Plano, TX 75024", 0, new DateOnly(1989, 1, 1), "No information is provided.", "Lexus USA Headquarter" });

            migrationBuilder.InsertData(
                table: "Headquarters",
                columns: new[] { "Id", "Address", "CarBrandId", "DateCreated", "Description", "Name" },
                values: new object[] { 10, "59 Grigore Alexandrescu, HQ Victoriei Building", 0, new DateOnly(1931, 3, 10), "The head office opened March 1931 and continues to serve as a site for piston engine and transmission production.The facility is 55.1 hectares (136 acres) in size.", "Mazda Japan Co Headquarter" });

            migrationBuilder.InsertData(
                table: "CarBrands",
                columns: new[] { "Id", "DateCreated", "Description", "HeadquarterId", "Name", "Slogan" },
                values: new object[] { 5, new DateOnly(1862, 1, 21), "Opel AG, German automotive company, a wholly owned subsidiary of Stellantis NV, specializing in the manufacture of passenger\r\n                        cars and light vans. ", 5, "Opel", null });

            migrationBuilder.InsertData(
                table: "CarBrands",
                columns: new[] { "Id", "DateCreated", "Description", "HeadquarterId", "Name", "Slogan" },
                values: new object[] { 6, new DateOnly(1909, 7, 16), "Audi AG (Audi) a subsidiary of Volkswagen AG, is an automobile manufacturer. It designs, develops, \r\n                        manufactures, and commercializes premium cars, and motorcycles globally.", 6, "Audi", null });

            migrationBuilder.InsertData(
                table: "CarBrands",
                columns: new[] { "Id", "DateCreated", "Description", "HeadquarterId", "Name", "Slogan" },
                values: new object[] { 7, new DateOnly(1937, 8, 28), "Toyota Motor Corp (Toyota) is an automobile manufacturer. The company designs, manufactures and sells passenger cars, \r\n                        buses, minivans, trucks, specialty cars, recreational and sport-utility vehicles.", 7, "Toyota", null });

            migrationBuilder.InsertData(
                table: "CarBrands",
                columns: new[] { "Id", "DateCreated", "Description", "HeadquarterId", "Name", "Slogan" },
                values: new object[] { 8, new DateOnly(1948, 9, 24), "Honda is a mobility company powered by everyone’s dreams, creating mobility that helps and inspires people,\r\n                        in a wide range of fields such including motorcycles, automobiles, power products and aircraft.", 8, "Honda", null });

            migrationBuilder.InsertData(
                table: "CarBrands",
                columns: new[] { "Id", "DateCreated", "Description", "HeadquarterId", "Name", "Slogan" },
                values: new object[] { 9, new DateOnly(1989, 1, 18), "Lexus (レクサス, Rekusasu) is the luxury vehicle division of the Japanese automaker Toyota Motor Corporation.\r\n                        The Lexus brand is marketed in more than 90 countries and territories worldwide and is Japan's largest-selling make of premium cars.\r\n                        It has ranked among the 10 largest Japanese global brands in market value.", 9, "Lexus", null });

            migrationBuilder.InsertData(
                table: "CarBrands",
                columns: new[] { "Id", "DateCreated", "Description", "HeadquarterId", "Name", "Slogan" },
                values: new object[] { 10, new DateOnly(1920, 1, 30), "Mazda Motor Corporation (マツダ株式会社, Matsuda Kabushiki gaisha), also known as simply Mazda, is a Japanese multinational\r\n                        automotive manufacturer headquartered in Fuchū, Hiroshima, Japan.", 10, "Mazda", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CountriesOfProduction",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CountriesOfProduction",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Headquarters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Headquarters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Headquarters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Headquarters",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Headquarters",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Headquarters",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Headquarters",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
