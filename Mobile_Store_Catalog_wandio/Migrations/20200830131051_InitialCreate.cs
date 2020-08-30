using Microsoft.EntityFrameworkCore.Migrations;

namespace Mobile_Store_Catalog_wandio.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OperationSystems",
                columns: new[] { "OperationSystemId", "OperationSystemName" },
                values: new object[,]
                {
                    { 1, "IOS7" },
                    { 2, "IOS8" },
                    { 3, "IOS9" },
                    { 4, "IOS10" },
                    { 5, "IOS13" },
                    { 6, "Windows Phone 7" },
                    { 7, "Windows Phone 7.5" },
                    { 8, "Windows Phone 8" },
                    { 9, "Android 4.1 Jelly Bean" },
                    { 10, "Android 4.4 KitKat" },
                    { 11, "Android 5.0 Lollipop" },
                    { 12, "Android 6.0" },
                    { 13, "Android 7.0" },
                    { 14, "Android 8.0" },
                    { 15, "Android 9" },
                    { 16, "Android 11" }
                });

            migrationBuilder.InsertData(
                table: "Phones",
                columns: new[] { "PhoneId", "ManufactorId", "Memory", "OperationSystemId", "PhoneName", "Processor", "ScreenResolution", "Size", "VideoPath", "Wight" },
                values: new object[,]
                {
                    { 1, 1, "16GB, 1GB RAM", 1, "iphone 5", "A7", "1334 - by - 750 - pixel", 4.0, "F:\\PhoneVideos\\Iphone5", 4.0499999999999998 },
                    { 2, 1, "32GB, 2GB RAM", 2, "iphone 6", "A8", "1600-by-850-pixel", 4.7000000000000002, "F:\\PhoneVideos\\Iphone6", 4.5499999999999998 },
                    { 3, 1, "32GB, 2GB RAM", 3, "iphone 7", "A9", "1700-by-850-pixel", 4.7000000000000002, "F:\\PhoneVideos\\Iphone7", 4.5499999999999998 },
                    { 4, 1, "32GB, 3GB RAM", 3, "iphone 8", "A9", "1700-by-850-pixel", 4.7000000000000002, "F:\\PhoneVideos\\Iphone8", 4.5499999999999998 },
                    { 5, 1, "64GB, 3GB RAM", 4, "iphone X", "A10", "2300-by-1000-pixel", 5.0, "F:\\PhoneVideos\\IphoneX", 4.7000000000000002 },
                    { 6, 1, "128GB, 4GB RAM", 5, "iphone 11", "A11", "2300-by-1000-pixel", 5.2000000000000002, "F:\\PhoneVideos\\Iphone11", 5.0 },
                    { 11, 3, "16GB, 2GB RAM", 6, "Windows Lumia R10", "Dual-core 480p", "1800-by-850-pixel", 4.7999999999999998, "F:\\PhoneVideos\\WindowLumiaR10", 5.2000000000000002 },
                    { 12, 3, "32GB, 2GB RAM", 8, "Windows Lumia R15", "Quad-core 1080p", "2000-by-950-pixel", 4.7999999999999998, "F:\\PhoneVideos\\WindowLumiaR15", 5.2000000000000002 },
                    { 7, 2, "16GB, 1GB RAM", 9, "Samsung A21", "Exynos 5 Octa", "1334-by-750-pixel", 4.2000000000000002, "F:\\PhoneVideos\\SamsungA21", 4.5499999999999998 },
                    { 8, 2, "16GB, 2GB RAM", 10, "Samsung Note2", "Exynos 7 Octa", "1700-by-750-pixel", 5.5999999999999996, "F:\\PhoneVideos\\SamsungNote2", 5.5499999999999998 },
                    { 9, 2, "32GB, 2GB RAM", 11, "Samsung Note3", "Exynos 8 Octa", "1800-by-850-pixel", 5.5999999999999996, "F:\\PhoneVideos\\SamsungNote3", 5.5499999999999998 },
                    { 10, 2, "64GB, 3GB RAM", 12, "Samsung Galaxy7", "Exynos 8 Octa", "1800-by-850-pixel", 4.7999999999999998, "F:\\PhoneVideos\\SamsungGalaxy7", 4.7000000000000002 },
                    { 14, 4, "64GB, 3GB RAM", 15, "Huawei P30", "Quad-core 1080p", "2000-by-950-pixel", 5.4000000000000004, "F:\\PhoneVideos\\HuaweiP30", 5.2000000000000002 },
                    { 13, 4, "64GB, 4GB RAM", 16, "Huawei P40", "Quad-core 1080p", "2000-by-950-pixel", 5.4000000000000004, "F:\\PhoneVideos\\HuaweiP40", 5.2000000000000002 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OperationSystems",
                keyColumn: "OperationSystemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OperationSystems",
                keyColumn: "OperationSystemId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "OperationSystems",
                keyColumn: "OperationSystemId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Phones",
                keyColumn: "PhoneId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OperationSystems",
                keyColumn: "OperationSystemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OperationSystems",
                keyColumn: "OperationSystemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OperationSystems",
                keyColumn: "OperationSystemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OperationSystems",
                keyColumn: "OperationSystemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OperationSystems",
                keyColumn: "OperationSystemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OperationSystems",
                keyColumn: "OperationSystemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OperationSystems",
                keyColumn: "OperationSystemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OperationSystems",
                keyColumn: "OperationSystemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OperationSystems",
                keyColumn: "OperationSystemId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OperationSystems",
                keyColumn: "OperationSystemId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OperationSystems",
                keyColumn: "OperationSystemId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OperationSystems",
                keyColumn: "OperationSystemId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OperationSystems",
                keyColumn: "OperationSystemId",
                keyValue: 16);
        }
    }
}
