using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeporteApi.Migrations
{
    /// <inheritdoc />
    public partial class Jugadores_Equipos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nacionalidad",
                table: "Jugadores",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "Equipos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nacionalidad",
                table: "Jugadores");

            migrationBuilder.DropColumn(
                name: "Pais",
                table: "Equipos");
        }
    }
}
