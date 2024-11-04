using System.ComponentModel.DataAnnotations;

namespace AvaliacaoA1.Models
{
    public class Pontuacao
    {
        public int Id { get; set; }

        [Required]
        public int Pontos { get; set; }

        [StringLength(200)]
        public string Descricao { get; set; }

        // Relação 1 para n com Tarefa
        public int TarefaId { get; set; }
        public Tarefa? Tarefa { get; set; }
    }
}
