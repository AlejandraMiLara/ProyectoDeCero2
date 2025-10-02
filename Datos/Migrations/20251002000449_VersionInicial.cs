using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class VersionInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Carrera",
                columns: table => new
                {
                    IdCarrera = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCoordinador = table.Column<int>(type: "int", nullable: false),
                    ClaveCarrera = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreCarrera = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AliasCarrera = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoCarrera = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrera", x => x.IdCarrera);
                });

            migrationBuilder.CreateTable(
                name: "PlanEstudio",
                columns: table => new
                {
                    IdPlanEstudio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanEstudio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalCreditos = table.Column<int>(type: "int", nullable: false),
                    CreditosOptativos = table.Column<int>(type: "int", nullable: false),
                    CreditosObligatorios = table.Column<int>(type: "int", nullable: false),
                    PerfilDeIngreso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PerfilDeEgreso = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampoOcupacional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comentarios = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoPlanEstudio = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanEstudio", x => x.IdPlanEstudio);
                });

            migrationBuilder.CreateTable(
                name: "CarreraPlanEstudio",
                columns: table => new
                {
                    CarrerasIdCarrera = table.Column<int>(type: "int", nullable: false),
                    PlanesDeEstudioIdPlanEstudio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarreraPlanEstudio", x => new { x.CarrerasIdCarrera, x.PlanesDeEstudioIdPlanEstudio });
                    table.ForeignKey(
                        name: "FK_CarreraPlanEstudio_Carrera_CarrerasIdCarrera",
                        column: x => x.CarrerasIdCarrera,
                        principalTable: "Carrera",
                        principalColumn: "IdCarrera",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarreraPlanEstudio_PlanEstudio_PlanesDeEstudioIdPlanEstudio",
                        column: x => x.PlanesDeEstudioIdPlanEstudio,
                        principalTable: "PlanEstudio",
                        principalColumn: "IdPlanEstudio",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarreraPlanEstudio_PlanesDeEstudioIdPlanEstudio",
                table: "CarreraPlanEstudio",
                column: "PlanesDeEstudioIdPlanEstudio");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarreraPlanEstudio");

            migrationBuilder.DropTable(
                name: "Carrera");

            migrationBuilder.DropTable(
                name: "PlanEstudio");
        }
    }
}
