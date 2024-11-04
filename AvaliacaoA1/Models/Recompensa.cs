using System.ComponentModel.DataAnnotations;

namespace AvaliacaoA1.Models
{
    public class Recompensa
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(500)]
        public string Descricao { get; set; }

        [Required]
        public int CustoEmPontos { get; set; }
    }
}
