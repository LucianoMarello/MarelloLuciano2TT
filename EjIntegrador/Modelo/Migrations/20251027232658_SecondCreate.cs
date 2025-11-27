using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo.Migrations
{
    /// <inheritdoc />
    public partial class SecondCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestamo_Libros_LibroId",
                table: "Prestamo");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestamo_Partidas_SocioId",
                table: "Prestamo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prestamo",
                table: "Prestamo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Partidas",
                table: "Partidas");

            migrationBuilder.RenameTable(
                name: "Prestamo",
                newName: "Prestamos");

            migrationBuilder.RenameTable(
                name: "Partidas",
                newName: "Socios");

            migrationBuilder.RenameIndex(
                name: "IX_Prestamo_SocioId",
                table: "Prestamos",
                newName: "IX_Prestamos_SocioId");

            migrationBuilder.RenameIndex(
                name: "IX_Prestamo_LibroId",
                table: "Prestamos",
                newName: "IX_Prestamos_LibroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prestamos",
                table: "Prestamos",
                column: "PrestamoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Socios",
                table: "Socios",
                column: "SocioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamos_Libros_LibroId",
                table: "Prestamos",
                column: "LibroId",
                principalTable: "Libros",
                principalColumn: "LibroId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamos_Socios_SocioId",
                table: "Prestamos",
                column: "SocioId",
                principalTable: "Socios",
                principalColumn: "SocioId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestamos_Libros_LibroId",
                table: "Prestamos");

            migrationBuilder.DropForeignKey(
                name: "FK_Prestamos_Socios_SocioId",
                table: "Prestamos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Socios",
                table: "Socios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prestamos",
                table: "Prestamos");

            migrationBuilder.RenameTable(
                name: "Socios",
                newName: "Partidas");

            migrationBuilder.RenameTable(
                name: "Prestamos",
                newName: "Prestamo");

            migrationBuilder.RenameIndex(
                name: "IX_Prestamos_SocioId",
                table: "Prestamo",
                newName: "IX_Prestamo_SocioId");

            migrationBuilder.RenameIndex(
                name: "IX_Prestamos_LibroId",
                table: "Prestamo",
                newName: "IX_Prestamo_LibroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Partidas",
                table: "Partidas",
                column: "SocioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prestamo",
                table: "Prestamo",
                column: "PrestamoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamo_Libros_LibroId",
                table: "Prestamo",
                column: "LibroId",
                principalTable: "Libros",
                principalColumn: "LibroId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamo_Partidas_SocioId",
                table: "Prestamo",
                column: "SocioId",
                principalTable: "Partidas",
                principalColumn: "SocioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
