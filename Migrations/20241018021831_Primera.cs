using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tar_5.Migrations
{
    /// <inheritdoc />
    public partial class Primera : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plataformas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Activa = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plataformas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Videojuegos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Desarrollador = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    PlataformaId = table.Column<int>(type: "INTEGER", nullable: false),
                    Genero = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    FechaLanzamiento = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ImagenPortada = table.Column<string>(type: "TEXT", nullable: false),
                    Descripcion = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videojuegos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Videojuegos_Plataformas_PlataformaId",
                        column: x => x.PlataformaId,
                        principalTable: "Plataformas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personajes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Alias = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    RolEnJuego = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    HabilidadEspecial = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    ArmaFavorita = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    NivelPoder = table.Column<int>(type: "INTEGER", nullable: false),
                    ImagenPersonaje = table.Column<string>(type: "TEXT", nullable: false),
                    VideojuegoId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personajes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personajes_Videojuegos_VideojuegoId",
                        column: x => x.VideojuegoId,
                        principalTable: "Videojuegos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personajes_VideojuegoId",
                table: "Personajes",
                column: "VideojuegoId");

            migrationBuilder.CreateIndex(
                name: "IX_Videojuegos_PlataformaId",
                table: "Videojuegos",
                column: "PlataformaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personajes");

            migrationBuilder.DropTable(
                name: "Videojuegos");

            migrationBuilder.DropTable(
                name: "Plataformas");
        }
    }
}
