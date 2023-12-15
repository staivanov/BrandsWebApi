using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBrands.WebApi.Data.Migrations
{
    public partial class HeadquarterFKadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HeadquartedId",
                table: "CarBrands",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HeadquartedId",
                table: "CarBrands");
        }
    }
}
