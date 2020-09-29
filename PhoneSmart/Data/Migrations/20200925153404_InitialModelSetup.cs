using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneSmart.Data.Migrations
{
    public partial class InitialModelSetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Phone",
                columns: table => new
                {
                    PhoneId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Storage = table.Column<string>(nullable: true),
                    Condition = table.Column<string>(nullable: true),
                    PhoneModelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phone", x => x.PhoneId);
                });

            migrationBuilder.CreateTable(
                name: "PhoneModel",
                columns: table => new
                {
                    PhoneModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    OS = table.Column<string>(nullable: true),
                    Ram = table.Column<string>(nullable: true),
                    DisplayType = table.Column<string>(nullable: true),
                    DisplaySize = table.Column<double>(nullable: false),
                    RefreshRate = table.Column<string>(nullable: true),
                    Processor = table.Column<string>(nullable: true),
                    MainCam = table.Column<string>(nullable: true),
                    SecondaryCam = table.Column<string>(nullable: true),
                    FrontCam = table.Column<string>(nullable: true),
                    Battery = table.Column<string>(nullable: true),
                    Security = table.Column<string>(nullable: true),
                    isWirelessCharge = table.Column<bool>(nullable: false),
                    isWaterResist = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneModel", x => x.PhoneModelId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Phone");

            migrationBuilder.DropTable(
                name: "PhoneModel");
        }
    }
}
