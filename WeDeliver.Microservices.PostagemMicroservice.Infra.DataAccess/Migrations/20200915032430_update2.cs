using Microsoft.EntityFrameworkCore.Migrations;

namespace WeDeliver.Microservices.PostagemMicroservice.Infra.DataAccess.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Postagens");

            migrationBuilder.DropColumn(
                name: "Cep",
                table: "Postagens");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Postagens");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "Postagens");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Postagens");

            migrationBuilder.DropColumn(
                name: "Logradouro",
                table: "Postagens");

            migrationBuilder.DropColumn(
                name: "Lote",
                table: "Postagens");

            migrationBuilder.AddColumn<string>(
                name: "Destino",
                table: "Postagens",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Destino",
                table: "Postagens");

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Postagens",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "Postagens",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Postagens",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "Postagens",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Postagens",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Logradouro",
                table: "Postagens",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lote",
                table: "Postagens",
                type: "nvarchar(4)",
                maxLength: 4,
                nullable: true);
        }
    }
}
