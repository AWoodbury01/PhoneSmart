using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneSmart.Data.Migrations
{
    public partial class AddPhoneURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneURL",
                table: "PhoneModel",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Phone_PhoneModelId",
                table: "Phone",
                column: "PhoneModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Phone_PhoneModel_PhoneModelId",
                table: "Phone",
                column: "PhoneModelId",
                principalTable: "PhoneModel",
                principalColumn: "PhoneModelId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Phone_PhoneModel_PhoneModelId",
                table: "Phone");

            migrationBuilder.DropIndex(
                name: "IX_Phone_PhoneModelId",
                table: "Phone");

            migrationBuilder.DropColumn(
                name: "PhoneURL",
                table: "PhoneModel");
        }
    }
}
