using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SadafStore.DataLayer.Migrations
{
    public partial class UserUsedDiscountCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserDiscountCodes",
                columns: table => new
                {
                    UD_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    DiscountId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDiscountCodes", x => x.UD_Id);
                    table.ForeignKey(
                        name: "FK_UserDiscountCodes_DisCounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "DisCounts",
                        principalColumn: "DiscountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserDiscountCodes_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ActiveCode", "RegisterDate" },
                values: new object[] { "1767c92b-1bec-4af9-9601-72aed92ed5f1", new DateTime(2020, 9, 17, 15, 47, 16, 69, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.CreateIndex(
                name: "IX_UserDiscountCodes_DiscountId",
                table: "UserDiscountCodes",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDiscountCodes_UserId",
                table: "UserDiscountCodes",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDiscountCodes");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "ActiveCode", "RegisterDate" },
                values: new object[] { "7a7fcdca-735c-46f6-bc04-585b889c7800", new DateTime(2020, 9, 13, 10, 19, 50, 131, DateTimeKind.Local).AddTicks(9270) });
        }
    }
}
