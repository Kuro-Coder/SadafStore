using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SadafStore.DataLayer.Migrations
{
    public partial class DisCountTab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DisCounts",
                columns: table => new
                {
                    DiscountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisCountCode = table.Column<string>(maxLength: 50, nullable: false),
                    DisCountPercent = table.Column<int>(nullable: false),
                    UsableCount = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisCounts", x => x.DiscountId);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ActiveCode", "RegisterDate" },
                values: new object[] { "7a7fcdca-735c-46f6-bc04-585b889c7800", new DateTime(2020, 9, 13, 10, 19, 50, 131, DateTimeKind.Local).AddTicks(9270) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DisCounts");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ActiveCode", "RegisterDate" },
                values: new object[] { "b643730f-c1be-48e3-b908-c86d59efe2ed", new DateTime(2020, 9, 10, 10, 48, 52, 409, DateTimeKind.Local).AddTicks(8462) });
        }
    }
}
