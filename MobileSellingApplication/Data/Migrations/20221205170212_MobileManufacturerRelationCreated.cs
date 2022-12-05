using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileSellingApplication.Data.Migrations
{
    public partial class MobileManufacturerRelationCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManufacturerID",
                table: "Mobile",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Mobile_ManufacturerID",
                table: "Mobile",
                column: "ManufacturerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Mobile_Manufacturer_ManufacturerID",
                table: "Mobile",
                column: "ManufacturerID",
                principalTable: "Manufacturer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mobile_Manufacturer_ManufacturerID",
                table: "Mobile");

            migrationBuilder.DropIndex(
                name: "IX_Mobile_ManufacturerID",
                table: "Mobile");

            migrationBuilder.DropColumn(
                name: "ManufacturerID",
                table: "Mobile");
        }
    }
}
