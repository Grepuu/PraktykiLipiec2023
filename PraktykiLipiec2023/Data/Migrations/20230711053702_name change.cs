using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PraktykiLipiec2023.Data.Migrations
{
    /// <inheritdoc />
    public partial class namechange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MarketLaneShelfs",
                table: "MarketLaneShelfs");

            migrationBuilder.RenameTable(
                name: "MarketLaneShelfs",
                newName: "MarketLaneShelfes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MarketLaneShelfes",
                table: "MarketLaneShelfes",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MarketLaneShelfes",
                table: "MarketLaneShelfes");

            migrationBuilder.RenameTable(
                name: "MarketLaneShelfes",
                newName: "MarketLaneShelfs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MarketLaneShelfs",
                table: "MarketLaneShelfs",
                column: "Id");
        }
    }
}
