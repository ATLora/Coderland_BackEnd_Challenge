using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Coderland_BackEnd_Challenge.Migrations
{
    /// <inheritdoc />
    public partial class RenameTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CarBrands",
                table: "CarBrands");

            migrationBuilder.RenameTable(
                name: "CarBrands",
                newName: "MarcasAutos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MarcasAutos",
                table: "MarcasAutos",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MarcasAutos",
                table: "MarcasAutos");

            migrationBuilder.RenameTable(
                name: "MarcasAutos",
                newName: "CarBrands");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarBrands",
                table: "CarBrands",
                column: "Id");
        }
    }
}
