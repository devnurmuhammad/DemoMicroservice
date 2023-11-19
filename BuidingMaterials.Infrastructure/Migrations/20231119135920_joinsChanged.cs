using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BuildingMaterials.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class joinsChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Clients_ClientId",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Materials_ClientId",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Materials");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Materials",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materials_ClientId",
                table: "Materials",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Clients_ClientId",
                table: "Materials",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");
        }
    }
}
