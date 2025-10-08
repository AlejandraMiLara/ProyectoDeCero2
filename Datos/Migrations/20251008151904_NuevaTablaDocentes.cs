using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class NuevaTablaDocentes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    EmailDocente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docente", x => x.IdDocente);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Docente");
        }
    }
}
