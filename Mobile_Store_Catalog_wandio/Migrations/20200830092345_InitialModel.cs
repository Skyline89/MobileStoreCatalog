using Microsoft.EntityFrameworkCore.Migrations;

namespace Mobile_Store_Catalog_wandio.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Manufactors",
                columns: table => new
                {
                    ManufactorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManufactorName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufactors", x => x.ManufactorId);
                });

            migrationBuilder.CreateTable(
                name: "OperationSystems",
                columns: table => new
                {
                    OperationSystemId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationSystemName = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationSystems", x => x.OperationSystemId);
                });

            migrationBuilder.CreateTable(
                name: "Phones",
                columns: table => new
                {
                    PhoneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ManufactorId = table.Column<int>(nullable: false),
                    OperationSystemId = table.Column<int>(nullable: false),
                    PhoneName = table.Column<string>(maxLength: 100, nullable: false),
                    Size = table.Column<double>(nullable: false),
                    Wight = table.Column<double>(nullable: false),
                    ScreenResolution = table.Column<string>(maxLength: 100, nullable: false),
                    Processor = table.Column<string>(maxLength: 100, nullable: false),
                    Memory = table.Column<string>(nullable: false),
                    VideoPath = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phones", x => x.PhoneId);
                    table.ForeignKey(
                        name: "FK_Phones_Manufactors_ManufactorId",
                        column: x => x.ManufactorId,
                        principalTable: "Manufactors",
                        principalColumn: "ManufactorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Phones_OperationSystems_OperationSystemId",
                        column: x => x.OperationSystemId,
                        principalTable: "OperationSystems",
                        principalColumn: "OperationSystemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    PhotoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneId = table.Column<int>(nullable: false),
                    PhotoPath = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.PhotoId);
                    table.ForeignKey(
                        name: "FK_Photos_Phones_PhoneId",
                        column: x => x.PhoneId,
                        principalTable: "Phones",
                        principalColumn: "PhoneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Phones_ManufactorId",
                table: "Phones",
                column: "ManufactorId");

            migrationBuilder.CreateIndex(
                name: "IX_Phones_OperationSystemId",
                table: "Phones",
                column: "OperationSystemId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_PhoneId",
                table: "Photos",
                column: "PhoneId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Phones");

            migrationBuilder.DropTable(
                name: "Manufactors");

            migrationBuilder.DropTable(
                name: "OperationSystems");
        }
    }
}
