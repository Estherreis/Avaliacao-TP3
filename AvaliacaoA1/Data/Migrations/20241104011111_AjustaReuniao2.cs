using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvaliacaoA1.Data.Migrations
{
    /// <inheritdoc />
    public partial class AjustaReuniao2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MembroReuniao_Membro_MembroId",
                table: "MembroReuniao");

            migrationBuilder.DropForeignKey(
                name: "FK_MembroReuniao_Reuniao_ReuniaoId",
                table: "MembroReuniao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MembroReuniao",
                table: "MembroReuniao");

            migrationBuilder.RenameTable(
                name: "MembroReuniao",
                newName: "MembroReunioes");

            migrationBuilder.RenameIndex(
                name: "IX_MembroReuniao_ReuniaoId",
                table: "MembroReunioes",
                newName: "IX_MembroReunioes_ReuniaoId");

            migrationBuilder.RenameIndex(
                name: "IX_MembroReuniao_MembroId",
                table: "MembroReunioes",
                newName: "IX_MembroReunioes_MembroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MembroReunioes",
                table: "MembroReunioes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MembroReunioes_Membro_MembroId",
                table: "MembroReunioes",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MembroReunioes_Reuniao_ReuniaoId",
                table: "MembroReunioes",
                column: "ReuniaoId",
                principalTable: "Reuniao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MembroReunioes_Membro_MembroId",
                table: "MembroReunioes");

            migrationBuilder.DropForeignKey(
                name: "FK_MembroReunioes_Reuniao_ReuniaoId",
                table: "MembroReunioes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MembroReunioes",
                table: "MembroReunioes");

            migrationBuilder.RenameTable(
                name: "MembroReunioes",
                newName: "MembroReuniao");

            migrationBuilder.RenameIndex(
                name: "IX_MembroReunioes_ReuniaoId",
                table: "MembroReuniao",
                newName: "IX_MembroReuniao_ReuniaoId");

            migrationBuilder.RenameIndex(
                name: "IX_MembroReunioes_MembroId",
                table: "MembroReuniao",
                newName: "IX_MembroReuniao_MembroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MembroReuniao",
                table: "MembroReuniao",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MembroReuniao_Membro_MembroId",
                table: "MembroReuniao",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MembroReuniao_Reuniao_ReuniaoId",
                table: "MembroReuniao",
                column: "ReuniaoId",
                principalTable: "Reuniao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
