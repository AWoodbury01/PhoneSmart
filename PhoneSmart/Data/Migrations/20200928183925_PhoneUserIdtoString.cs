using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneSmart.Data.Migrations
{
    public partial class PhoneUserIdtoString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Phone",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Phone_UserId",
                table: "Phone",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Phone_AspNetUsers_UserId",
                table: "Phone",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phone_AspNetUsers_UserId",
                table: "Phone");

            migrationBuilder.DropIndex(
                name: "IX_Phone_UserId",
                table: "Phone");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Phone",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Phone",
                type: "nvarchar(450)",
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
    }
}
