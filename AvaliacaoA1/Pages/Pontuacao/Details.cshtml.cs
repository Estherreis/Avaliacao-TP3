using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AvaliacaoA1.Data;
using AvaliacaoA1.Models;

namespace AvaliacaoA1.Pages.Pontuacao
{
    public class DetailsModel : PageModel
    {
        private readonly AvaliacaoA1.Data.AvaliacaoA1Context _context;

        public DetailsModel(AvaliacaoA1.Data.AvaliacaoA1Context context)
        {
            _context = context;
        }

        public Models.Pontuacao Pontuacao { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pontuacao = await _context.Pontuacao.Include(x => x.Tarefa).FirstOrDefaultAsync(m => m.Id == id);
            if (pontuacao == null)
            {
                return NotFound();
            }
            else
            {
                Pontuacao = pontuacao;
            }
            return Page();
        }
    }
}
