using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationCursos.Data.Migrations
{
    public partial class arreglandoerror : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Categoria",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Categoria");
        }
    }
}
