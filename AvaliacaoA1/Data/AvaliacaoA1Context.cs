using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AvaliacaoA1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace AvaliacaoA1.Data
{
    public class AvaliacaoA1Context : IdentityDbContext
    {
        public AvaliacaoA1Context (DbContextOptions<AvaliacaoA1Context> options)
            : base(options)
        {
        }

        public DbSet<AvaliacaoA1.Models.Lembrete> Lembrete { get; set; } = default!;
        public DbSet<AvaliacaoA1.Models.Membro> Membro { get; set; } = default!;
        public DbSet<AvaliacaoA1.Models.Tarefa> Tarefa { get; set; } = default!;
        public DbSet<AvaliacaoA1.Models.Pontuacao> Pontuacao { get; set; } = default!;
        public DbSet<AvaliacaoA1.Models.Recompensa> Recompensa { get; set; } = default!;
        public DbSet<AvaliacaoA1.Models.Reuniao> Reuniao { get; set; } = default!;
        public DbSet<AvaliacaoA1.Models.MembroReuniao> MembroReunioes { get; set; } = default!;
    }
}
