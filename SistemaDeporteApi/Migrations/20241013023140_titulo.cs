using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeporteApi.Migrations
{
    /// <inheritdoc />
    public partial class titulo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "Partidos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Titulo",
                table: "Equipos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "Partidos");

            migrationBuilder.DropColumn(
                name: "Titulo",
                table: "Equipos");
        }
    }
}
