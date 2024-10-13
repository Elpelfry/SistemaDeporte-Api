using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaDeporteApi.Migrations
{
    /// <inheritdoc />
    public partial class ajustespartidoactual : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PartidoActual",
                table: "Ajustes",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PartidoActual",
                table: "Ajustes");
        }
    }
}
