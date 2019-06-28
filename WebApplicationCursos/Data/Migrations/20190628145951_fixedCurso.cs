using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationCursos.Data.Migrations
{
    public partial class fixedCurso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Creditos",
                table: "Curso",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Creditos",
                table: "Curso");
        }
    }
}
