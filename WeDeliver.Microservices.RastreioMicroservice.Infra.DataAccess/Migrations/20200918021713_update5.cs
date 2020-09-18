using Microsoft.EntityFrameworkCore.Migrations;

namespace WeDeliver.Microservices.RastreioMicroservice.Infra.DataAccess.Migrations
{
    public partial class update5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Rastreios");

            migrationBuilder.AddColumn<string>(
                name: "StatusEnvio",
                table: "Rastreios",
                type: "nvarchar(12)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StatusEnvio",
                table: "Rastreios");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Rastreios",
                type: "nvarchar",
                maxLength: 11,
                nullable: false,
                defaultValue: "");
        }
    }
}
