using System.ComponentModel.DataAnnotations;

namespace AvaliacaoA1.Models
{
    public class Membro
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        // Relação muitos para muitos com Tarefas
        public ICollection<MembroTarefa>? MembroTarefas { get; set; }

        // Relação muitos para muitos com Reunioes
        public ICollection<MembroReuniao>? MembroReunioes { get; set; }

        // Relação 1 para n com Pontuação
        public ICollection<Pontuacao>? Pontuacoes { get; set; }

        // Relação 1 para n com Lembrete
        public ICollection<Lembrete>? Lembretes { get; set; }
    }
}
