using Microsoft.EntityFrameworkCore.Migrations;

namespace Mobile_Store_Catalog_wandio.Migrations
{
    public partial class SeedManufactors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Manufactors",
                columns: new[] { "ManufactorId", "ManufactorName" },
                values: new object[,]
                {
                    { 1, "Apple" },
                    { 2, "Samsung" },
                    { 3, "WindowsPhone" },
                    { 4, "Huawei" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Manufactors",
                keyColumn: "ManufactorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manufactors",
                keyColumn: "ManufactorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Manufactors",
                keyColumn: "ManufactorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Manufactors",
                keyColumn: "ManufactorId",
                keyValue: 4);
        }
    }
}
