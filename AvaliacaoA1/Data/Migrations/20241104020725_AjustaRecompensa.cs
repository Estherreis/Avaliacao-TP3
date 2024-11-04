using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvaliacaoA1.Data.Migrations
{
    /// <inheritdoc />
    public partial class AjustaRecompensa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recompensa_Membro_MembroId",
                table: "Recompensa");

            migrationBuilder.DropIndex(
                name: "IX_Recompensa_MembroId",
                table: "Recompensa");

            migrationBuilder.DropColumn(
                name: "MembroId",
                table: "Recompensa");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MembroId",
                table: "Recompensa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Recompensa_MembroId",
                table: "Recompensa",
                column: "MembroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recompensa_Membro_MembroId",
                table: "Recompensa",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
