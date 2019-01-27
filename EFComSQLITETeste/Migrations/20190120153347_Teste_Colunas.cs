using Microsoft.EntityFrameworkCore.Migrations;

namespace EFComSQLITETeste.Migrations
{
    public partial class Teste_Colunas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Contatos");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Visitantes",
                newName: "NomeCompleto");

            migrationBuilder.AddColumn<float>(
                name: "Email",
                table: "Contatos",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Contatos");

            migrationBuilder.RenameColumn(
                name: "NomeCompleto",
                table: "Visitantes",
                newName: "Nome");

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Contatos",
                nullable: true);
        }
    }
}
