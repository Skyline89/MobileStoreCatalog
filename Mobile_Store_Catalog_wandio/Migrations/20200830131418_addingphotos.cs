using Microsoft.EntityFrameworkCore.Migrations;

namespace Mobile_Store_Catalog_wandio.Migrations
{
    public partial class addingphotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "PhotoId", "PhoneId", "PhotoPath" },
                values: new object[] { 1, 1, "F:\\PhonePhotos\\Iphone5_1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoId",
                keyValue: 1);
        }
    }
}
