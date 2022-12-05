using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileSellingApplication.Data.Migrations
{
    public partial class MobileEntityUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Mobile",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Mobile");
        }
    }
}
