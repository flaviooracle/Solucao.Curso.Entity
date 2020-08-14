using Microsoft.EntityFrameworkCore.Migrations;

namespace Solucao.Curso.Entity.Repository.Migrations
{
    public partial class Alterar_Campo_Identidade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "NomeReal",
                table: "IdentidadesSecretas",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "NomeReal",
                table: "IdentidadesSecretas",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
