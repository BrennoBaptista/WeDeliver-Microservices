using Microsoft.EntityFrameworkCore.Migrations;

namespace WeDeliver.Microservices.RastreioMicroservice.Infra.DataAccess.Migrations
{
    public partial class update3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Rastreios",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar",
                oldMaxLength: 11);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Rastreios",
                type: "nvarchar",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
