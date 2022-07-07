using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LagerSystem.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Count", "Description", "Name", "Orderdate", "Price", "Shelf" },
                values: new object[,]
                {
                    { 1, "FOOD", 100, "", "SWEETS", new DateTime(1995, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "2" },
                    { 2, "SHOPPING", 100, "", "T-SHIRT", new DateTime(1995, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "2" },
                    { 3, "SHOPPING", 100, "", "TROUSER", new DateTime(1995, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "2" },
                    { 4, "FOOD", 100, "", "MEAT", new DateTime(1995, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
