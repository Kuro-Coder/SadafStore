using Microsoft.EntityFrameworkCore.Migrations;

namespace SadafStore.DataLayer.Migrations
{
    public partial class ForgotProductNumberColemn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductNumber",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductNumber",
                table: "Products");
        }
    }
}
