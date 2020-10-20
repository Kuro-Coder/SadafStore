using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SadafStore.DataLayer.Migrations
{
    public partial class TTorNews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Newses",
                columns: table => new
                {
                    IdForNews = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailForNews = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Newses", x => x.IdForNews);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ActiveCode", "RegisterDate" },
                values: new object[] { "1eded556-f035-4e5e-bb29-b986b36a9538", new DateTime(2020, 9, 26, 9, 54, 11, 963, DateTimeKind.Local).AddTicks(7680) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ActiveCode", "RegisterDate" },
                values: new object[] { "2a9e1575-2ce9-4dad-bbe3-65e6c9f77a6f", new DateTime(2020, 9, 26, 9, 54, 11, 967, DateTimeKind.Local).AddTicks(3179) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Newses");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ActiveCode", "RegisterDate" },
                values: new object[] { "6932df57-219c-4428-a297-284a5a6f39e7", new DateTime(2020, 9, 23, 11, 1, 19, 747, DateTimeKind.Local).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "ActiveCode", "RegisterDate" },
                values: new object[] { "10342d62-b47f-4dee-9074-79640d2cf1c7", new DateTime(2020, 9, 23, 11, 1, 19, 754, DateTimeKind.Local).AddTicks(2215) });
        }
    }
}
