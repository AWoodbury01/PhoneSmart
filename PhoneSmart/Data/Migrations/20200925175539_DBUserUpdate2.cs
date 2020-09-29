using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneSmart.Data.Migrations
{
    public partial class DBUserUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Phone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Phone_UserId1",
                table: "Phone",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Phone_AspNetUsers_UserId1",
                table: "Phone",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phone_AspNetUsers_UserId1",
                table: "Phone");

            migrationBuilder.DropIndex(
                name: "IX_Phone_UserId1",
                table: "Phone");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Phone");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
