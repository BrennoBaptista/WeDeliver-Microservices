using Microsoft.EntityFrameworkCore.Migrations;

namespace WeDeliver.Microservices.PostagemMicroservice.Infra.DataAccess.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Postagens",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cep",
                table: "Postagens",
                maxLength: 7,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Postagens",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "Postagens",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Postagens",
                maxLength: 25,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Logradouro",
                table: "Postagens",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lote",
                table: "Postagens",
                maxLength: 4,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
