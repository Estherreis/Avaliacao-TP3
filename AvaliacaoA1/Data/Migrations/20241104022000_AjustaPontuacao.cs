using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvaliacaoA1.Data.Migrations
{
    /// <inheritdoc />
    public partial class AjustaPontuacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pontuacao_Membro_MembroId",
                table: "Pontuacao");

            migrationBuilder.AlterColumn<int>(
                name: "MembroId",
                table: "Pontuacao",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Pontuacao_Membro_MembroId",
                table: "Pontuacao",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pontuacao_Membro_MembroId",
                table: "Pontuacao");

            migrationBuilder.AlterColumn<int>(
                name: "MembroId",
                table: "Pontuacao",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pontuacao_Membro_MembroId",
                table: "Pontuacao",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
