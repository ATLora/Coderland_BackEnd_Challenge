using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Coderland_BackEnd_Challenge.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarBrands",
                columns: new[] { "Id", "CountryOfOrigin", "FoundationYear", "Name" },
                values: new object[,]
                {
                    { 1, "Japan", new DateTime(1937, 8, 28, 0, 0, 0, DateTimeKind.Utc), "Toyota" },
                    { 2, "USA", new DateTime(1937, 8, 28, 0, 0, 0, DateTimeKind.Utc), "Ford" },
                    { 3, "USA", new DateTime(1911, 11, 3, 0, 0, 0, DateTimeKind.Utc), "Chevrolet" },
                    { 4, "Japan", new DateTime(1933, 12, 26, 0, 0, 0, DateTimeKind.Utc), "Nissan" },
                    { 5, "Germany", new DateTime(1913, 10, 27, 0, 0, 0, DateTimeKind.Utc), "BMW" },
                    { 6, "China", new DateTime(1862, 11, 3, 0, 0, 0, DateTimeKind.Utc), "Changan" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CarBrands",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
