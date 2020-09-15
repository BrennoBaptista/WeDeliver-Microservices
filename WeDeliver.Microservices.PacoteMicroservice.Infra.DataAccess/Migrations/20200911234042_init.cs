using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeDeliver.Microservices.PacoteMicroservice.Infra.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pacotes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Id_Cliente = table.Column<Guid>(nullable: false),
                    Peso = table.Column<double>(nullable: false),
                    Altura = table.Column<double>(nullable: false),
                    Largura = table.Column<double>(nullable: false),
                    Profundidade = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacotes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pacotes");
        }
    }
}
