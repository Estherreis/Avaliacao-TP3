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
    public class DeleteModel : PageModel
    {
        private readonly AvaliacaoA1.Data.AvaliacaoA1Context _context;

        public DeleteModel(AvaliacaoA1.Data.AvaliacaoA1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Pontuacao Pontuacao { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pontuacao = await _context.Pontuacao.FindAsync(id);
            if (pontuacao != null)
            {
                Pontuacao = pontuacao;
                _context.Pontuacao.Remove(Pontuacao);
                await _context.SaveChangesAsync();
            }

            return new JsonResult(true);
        }
    }
}
