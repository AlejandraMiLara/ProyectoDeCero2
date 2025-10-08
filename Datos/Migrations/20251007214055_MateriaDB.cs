using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class MateriaDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Materia",
                columns: table => new
                {
                    IdMateria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstadoMateria = table.Column<int>(type: "int", nullable: false),
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
                    PerfilDocente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materia", x => x.IdMateria);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materia");
        }
    }
}
