using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AvaliacaoA1.Data.Migrations
{
    /// <inheritdoc />
    public partial class Ajustes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lembretes_Membros_MembroId",
                table: "Lembretes");

            migrationBuilder.DropForeignKey(
                name: "FK_MembroReunioes_Membros_MembroId",
                table: "MembroReunioes");

            migrationBuilder.DropForeignKey(
                name: "FK_MembroReunioes_Reunioes_ReuniaoId",
                table: "MembroReunioes");

            migrationBuilder.DropForeignKey(
                name: "FK_MembroTarefas_Membros_MembroId",
                table: "MembroTarefas");

            migrationBuilder.DropForeignKey(
                name: "FK_MembroTarefas_Tarefas_TarefaId",
                table: "MembroTarefas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pontuacoes_Membros_MembroId",
                table: "Pontuacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Pontuacoes_Tarefas_TarefaId",
                table: "Pontuacoes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recompensas_Membros_MembroId",
                table: "Recompensas");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tarefas",
                table: "Tarefas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reunioes",
                table: "Reunioes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recompensas",
                table: "Recompensas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pontuacoes",
                table: "Pontuacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MembroTarefas",
                table: "MembroTarefas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Membros",
                table: "Membros");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MembroReunioes",
                table: "MembroReunioes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lembretes",
                table: "Lembretes");

            migrationBuilder.RenameTable(
                name: "Tarefas",
                newName: "Tarefa");

            migrationBuilder.RenameTable(
                name: "Reunioes",
                newName: "Reuniao");

            migrationBuilder.RenameTable(
                name: "Recompensas",
                newName: "Recompensa");

            migrationBuilder.RenameTable(
                name: "Pontuacoes",
                newName: "Pontuacao");

            migrationBuilder.RenameTable(
                name: "MembroTarefas",
                newName: "MembroTarefa");

            migrationBuilder.RenameTable(
                name: "Membros",
                newName: "Membro");

            migrationBuilder.RenameTable(
                name: "MembroReunioes",
                newName: "MembroReuniao");

            migrationBuilder.RenameTable(
                name: "Lembretes",
                newName: "Lembrete");

            migrationBuilder.RenameIndex(
                name: "IX_Recompensas_MembroId",
                table: "Recompensa",
                newName: "IX_Recompensa_MembroId");

            migrationBuilder.RenameIndex(
                name: "IX_Pontuacoes_TarefaId",
                table: "Pontuacao",
                newName: "IX_Pontuacao_TarefaId");

            migrationBuilder.RenameIndex(
                name: "IX_Pontuacoes_MembroId",
                table: "Pontuacao",
                newName: "IX_Pontuacao_MembroId");

            migrationBuilder.RenameIndex(
                name: "IX_MembroTarefas_TarefaId",
                table: "MembroTarefa",
                newName: "IX_MembroTarefa_TarefaId");

            migrationBuilder.RenameIndex(
                name: "IX_MembroTarefas_MembroId",
                table: "MembroTarefa",
                newName: "IX_MembroTarefa_MembroId");

            migrationBuilder.RenameIndex(
                name: "IX_MembroReunioes_ReuniaoId",
                table: "MembroReuniao",
                newName: "IX_MembroReuniao_ReuniaoId");

            migrationBuilder.RenameIndex(
                name: "IX_MembroReunioes_MembroId",
                table: "MembroReuniao",
                newName: "IX_MembroReuniao_MembroId");

            migrationBuilder.RenameIndex(
                name: "IX_Lembretes_MembroId",
                table: "Lembrete",
                newName: "IX_Lembrete_MembroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tarefa",
                table: "Tarefa",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reuniao",
                table: "Reuniao",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recompensa",
                table: "Recompensa",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pontuacao",
                table: "Pontuacao",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MembroTarefa",
                table: "MembroTarefa",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Membro",
                table: "Membro",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MembroReuniao",
                table: "MembroReuniao",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lembrete",
                table: "Lembrete",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lembrete_Membro_MembroId",
                table: "Lembrete",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_MembroTarefa_Membro_MembroId",
                table: "MembroTarefa",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MembroTarefa_Tarefa_TarefaId",
                table: "MembroTarefa",
                column: "TarefaId",
                principalTable: "Tarefa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pontuacao_Membro_MembroId",
                table: "Pontuacao",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pontuacao_Tarefa_TarefaId",
                table: "Pontuacao",
                column: "TarefaId",
                principalTable: "Tarefa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recompensa_Membro_MembroId",
                table: "Recompensa",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lembrete_Membro_MembroId",
                table: "Lembrete");

            migrationBuilder.DropForeignKey(
                name: "FK_MembroReuniao_Membro_MembroId",
                table: "MembroReuniao");

            migrationBuilder.DropForeignKey(
                name: "FK_MembroReuniao_Reuniao_ReuniaoId",
                table: "MembroReuniao");

            migrationBuilder.DropForeignKey(
                name: "FK_MembroTarefa_Membro_MembroId",
                table: "MembroTarefa");

            migrationBuilder.DropForeignKey(
                name: "FK_MembroTarefa_Tarefa_TarefaId",
                table: "MembroTarefa");

            migrationBuilder.DropForeignKey(
                name: "FK_Pontuacao_Membro_MembroId",
                table: "Pontuacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Pontuacao_Tarefa_TarefaId",
                table: "Pontuacao");

            migrationBuilder.DropForeignKey(
                name: "FK_Recompensa_Membro_MembroId",
                table: "Recompensa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tarefa",
                table: "Tarefa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reuniao",
                table: "Reuniao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Recompensa",
                table: "Recompensa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pontuacao",
                table: "Pontuacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MembroTarefa",
                table: "MembroTarefa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MembroReuniao",
                table: "MembroReuniao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Membro",
                table: "Membro");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lembrete",
                table: "Lembrete");

            migrationBuilder.RenameTable(
                name: "Tarefa",
                newName: "Tarefas");

            migrationBuilder.RenameTable(
                name: "Reuniao",
                newName: "Reunioes");

            migrationBuilder.RenameTable(
                name: "Recompensa",
                newName: "Recompensas");

            migrationBuilder.RenameTable(
                name: "Pontuacao",
                newName: "Pontuacoes");

            migrationBuilder.RenameTable(
                name: "MembroTarefa",
                newName: "MembroTarefas");

            migrationBuilder.RenameTable(
                name: "MembroReuniao",
                newName: "MembroReunioes");

            migrationBuilder.RenameTable(
                name: "Membro",
                newName: "Membros");

            migrationBuilder.RenameTable(
                name: "Lembrete",
                newName: "Lembretes");

            migrationBuilder.RenameIndex(
                name: "IX_Recompensa_MembroId",
                table: "Recompensas",
                newName: "IX_Recompensas_MembroId");

            migrationBuilder.RenameIndex(
                name: "IX_Pontuacao_TarefaId",
                table: "Pontuacoes",
                newName: "IX_Pontuacoes_TarefaId");

            migrationBuilder.RenameIndex(
                name: "IX_Pontuacao_MembroId",
                table: "Pontuacoes",
                newName: "IX_Pontuacoes_MembroId");

            migrationBuilder.RenameIndex(
                name: "IX_MembroTarefa_TarefaId",
                table: "MembroTarefas",
                newName: "IX_MembroTarefas_TarefaId");

            migrationBuilder.RenameIndex(
                name: "IX_MembroTarefa_MembroId",
                table: "MembroTarefas",
                newName: "IX_MembroTarefas_MembroId");

            migrationBuilder.RenameIndex(
                name: "IX_MembroReuniao_ReuniaoId",
                table: "MembroReunioes",
                newName: "IX_MembroReunioes_ReuniaoId");

            migrationBuilder.RenameIndex(
                name: "IX_MembroReuniao_MembroId",
                table: "MembroReunioes",
                newName: "IX_MembroReunioes_MembroId");

            migrationBuilder.RenameIndex(
                name: "IX_Lembrete_MembroId",
                table: "Lembretes",
                newName: "IX_Lembretes_MembroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tarefas",
                table: "Tarefas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reunioes",
                table: "Reunioes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Recompensas",
                table: "Recompensas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pontuacoes",
                table: "Pontuacoes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MembroTarefas",
                table: "MembroTarefas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MembroReunioes",
                table: "MembroReunioes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Membros",
                table: "Membros",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lembretes",
                table: "Lembretes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Lembretes_Membros_MembroId",
                table: "Lembretes",
                column: "MembroId",
                principalTable: "Membros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MembroReunioes_Membros_MembroId",
                table: "MembroReunioes",
                column: "MembroId",
                principalTable: "Membros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MembroReunioes_Reunioes_ReuniaoId",
                table: "MembroReunioes",
                column: "ReuniaoId",
                principalTable: "Reunioes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MembroTarefas_Membros_MembroId",
                table: "MembroTarefas",
                column: "MembroId",
                principalTable: "Membros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MembroTarefas_Tarefas_TarefaId",
                table: "MembroTarefas",
                column: "TarefaId",
                principalTable: "Tarefas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pontuacoes_Membros_MembroId",
                table: "Pontuacoes",
                column: "MembroId",
                principalTable: "Membros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pontuacoes_Tarefas_TarefaId",
                table: "Pontuacoes",
                column: "TarefaId",
                principalTable: "Tarefas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Recompensas_Membros_MembroId",
                table: "Recompensas",
                column: "MembroId",
                principalTable: "Membros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
