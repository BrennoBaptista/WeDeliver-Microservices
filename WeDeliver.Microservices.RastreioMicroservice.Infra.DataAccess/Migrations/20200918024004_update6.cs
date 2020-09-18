using Microsoft.EntityFrameworkCore.Migrations;

namespace WeDeliver.Microservices.RastreioMicroservice.Infra.DataAccess.Migrations
{
    public partial class update6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "StatusEnvio",
                table: "Rastreios",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(12)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "StatusEnvio",
                table: "Rastreios",
                type: "nvarchar(12)",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
