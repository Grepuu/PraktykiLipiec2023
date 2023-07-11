using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PraktykiLipiec2023.Data.Migrations
{
    /// <inheritdoc />
    public partial class addingbasemodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MarketLanes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Order = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketLanes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarketLaneShelfs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Level = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarketLaneShelfs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Prize = table.Column<float>(type: "REAL", nullable: false),
                    Amount = table.Column<float>(type: "REAL", nullable: false),
                    HasPlaceOnMarket = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "MarketLanes",
                columns: new[] { "Id", "Description", "Name", "Order" },
                values: new object[,]
                {
                    { 1, "do uzupełnienia", "Alejka główna", 0f },
                    { 2, "do uzupełnienia", "Alejka druga", 0f },
                    { 3, "do uzupełnienia", "Alejka kas", 0f }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "opis kategorii - do uzupełnienia", "Spożywcze" },
                    { 2, "opis kategorii - do uzupełnienia", "Elektronika" },
                    { 3, "opis kategorii - do uzupełnienia", "Napoje" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarketLanes");

            migrationBuilder.DropTable(
                name: "MarketLaneShelfs");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
