using System.ComponentModel.DataAnnotations;

namespace AvaliacaoA1.Models
{
    public class Tarefa
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(500)]
        public string Descricao { get; set; }

        [Required]
        public DateTime DataCriacao { get; set; }

        public DateTime? DataConclusao { get; set; }

        [Required]
        public bool Concluida { get; set; }

        // Relação muitos para muitos com Membros
        public ICollection<MembroTarefa>? MembroTarefas { get; set; }

        // Relação 1 para n com Pontuação
        public ICollection<Pontuacao>? Pontuacoes { get; set; }
    }
}
