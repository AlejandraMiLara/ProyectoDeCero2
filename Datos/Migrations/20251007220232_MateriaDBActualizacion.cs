using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Datos.Migrations
{
    /// <inheritdoc />
    public partial class MateriaDBActualizacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "E_MateriaIdMateria",
                table: "Materia",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materia_E_MateriaIdMateria",
                table: "Materia",
                column: "E_MateriaIdMateria");

            migrationBuilder.AddForeignKey(
                name: "FK_Materia_Materia_E_MateriaIdMateria",
                table: "Materia",
                column: "E_MateriaIdMateria",
                principalTable: "Materia",
                principalColumn: "IdMateria");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materia_Materia_E_MateriaIdMateria",
                table: "Materia");

            migrationBuilder.DropIndex(
                name: "IX_Materia_E_MateriaIdMateria",
                table: "Materia");

            migrationBuilder.DropColumn(
                name: "E_MateriaIdMateria",
                table: "Materia");
        }
    }
}
