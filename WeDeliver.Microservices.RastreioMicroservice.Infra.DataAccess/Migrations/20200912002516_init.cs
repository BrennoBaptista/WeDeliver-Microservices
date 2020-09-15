using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeDeliver.Microservices.RastreioMicroservice.Infra.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rastreios",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Id_Postagem = table.Column<Guid>(nullable: false),
                    Id_Pacote = table.Column<Guid>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Localizacao = table.Column<string>(nullable: true),
                    UltimaAtualizacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rastreios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rastreios");
        }
    }
}
