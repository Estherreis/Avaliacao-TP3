using System.ComponentModel.DataAnnotations;

namespace AvaliacaoA1.Models
{
    public class Reuniao
    {
        public int Id { get; set; }

        [Required]
        public DateTime DataHora { get; set; }

        [StringLength(200)]
        public string Titulo { get; set; }

        [StringLength(1000)]
        public string Notas { get; set; }

        // Relação muitos para muitos com Membros
        public ICollection<MembroReuniao>? MembroReunioes { get; set; }

    }
}
