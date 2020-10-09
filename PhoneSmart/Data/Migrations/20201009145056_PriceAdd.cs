using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneSmart.Data.Migrations
{
    public partial class PriceAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Phone",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Phone");
        }
    }
}
