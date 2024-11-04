using System.ComponentModel.DataAnnotations;

namespace AvaliacaoA1.Models
{
    public class Lembrete
    {
        public int Id { get; set; }

        [Required]
        public DateTime DataHora { get; set; }

        [Required]
        [StringLength(200)]
        public string Mensagem { get; set; }

        // Relação 1 para n com Membro
        public int MembroId { get; set; }
        public Membro? Membro { get; set; }
    }
}
