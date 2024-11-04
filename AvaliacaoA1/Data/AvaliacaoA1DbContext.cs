using AvaliacaoA1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AvaliacaoA1.Data
{
    public class AvaliacaoA1DbContext : IdentityDbContext
    {
        public AvaliacaoA1DbContext(DbContextOptions<AvaliacaoA1DbContext> options)
            : base(options)
        {
        }

        public DbSet<Membro> Membros { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Lembrete> Lembretes { get; set; }
        public DbSet<Pontuacao> Pontuacoes { get; set; }
        public DbSet<Recompensa> Recompensas { get; set; }
        public DbSet<Reuniao> Reunioes { get; set; }
        public DbSet<MembroTarefa> MembroTarefas { get; set; }
        public DbSet<MembroReuniao> MembroReunioes { get; set; }
    }
}
