using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
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
                name: "Docente",
                columns: table => new
                {
                    IdDocente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroEmpleadoDocente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreDocente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApPatDocente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApMatDocente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailDocente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoDocente = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docente", x => x.IdDocente);
                });

            migrationBuilder.CreateTable(
                name: "NivelAcademico",
                columns: table => new
                {
                    IdNivelAcademico = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreNivelAcademico = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NivelAcademico", x => x.IdNivelAcademico);
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
                name: "Materia",
                columns: table => new
                {
                    IdMateria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstadoMateria = table.Column<bool>(type: "bit", nullable: false),
                    ClaveMateria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HCMateria = table.Column<int>(type: "int", nullable: false),
                    HLMateria = table.Column<int>(type: "int", nullable: false),
                    HTMateria = table.Column<int>(type: "int", nullable: false),
                    HPCMateria = table.Column<int>(type: "int", nullable: false),
                    HCLMateria = table.Column<int>(type: "int", nullable: false),
                    HEMateria = table.Column<int>(type: "int", nullable: false),
                    CRMateria = table.Column<int>(type: "int", nullable: false),
                    PropositoMateria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompetenciaMateria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EvidenciaMateria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetodologiaMateria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CriteriosMateria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BibliografiaBasicaMateria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BibliografiaCompletenciaMateria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PathPUAMateria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PerfilDocente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdNivelAcademico = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materia", x => x.IdMateria);
                    table.ForeignKey(
                        name: "FK_Materia_NivelAcademico_IdNivelAcademico",
                        column: x => x.IdNivelAcademico,
                        principalTable: "NivelAcademico",
                        principalColumn: "IdNivelAcademico",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.CreateIndex(
                name: "IX_Materia_IdNivelAcademico",
                table: "Materia",
                column: "IdNivelAcademico");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarreraPlanEstudio");

            migrationBuilder.DropTable(
                name: "Docente");

            migrationBuilder.DropTable(
                name: "Materia");

            migrationBuilder.DropTable(
                name: "Carrera");

            migrationBuilder.DropTable(
                name: "PlanEstudio");

            migrationBuilder.DropTable(
                name: "NivelAcademico");
        }
    }
}
