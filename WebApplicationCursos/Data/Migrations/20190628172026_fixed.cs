using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationCursos.Data.Migrations
{
    public partial class @fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Asignacion_CursoID",
                table: "Asignacion",
                column: "CursoID");

            migrationBuilder.CreateIndex(
                name: "IX_Asignacion_InstructorID",
                table: "Asignacion",
                column: "InstructorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Asignacion_Curso_CursoID",
                table: "Asignacion",
                column: "CursoID",
                principalTable: "Curso",
                principalColumn: "CursoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Asignacion_Persona_InstructorID",
                table: "Asignacion",
                column: "InstructorID",
                principalTable: "Persona",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asignacion_Curso_CursoID",
                table: "Asignacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Asignacion_Persona_InstructorID",
                table: "Asignacion");

            migrationBuilder.DropIndex(
                name: "IX_Asignacion_CursoID",
                table: "Asignacion");

            migrationBuilder.DropIndex(
                name: "IX_Asignacion_InstructorID",
                table: "Asignacion");
        }
    }
}
