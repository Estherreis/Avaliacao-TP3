using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AvaliacaoA1.Data;
using AvaliacaoA1.Models;

namespace AvaliacaoA1.Pages.Lembrete
{
    public class DeleteModel : PageModel
    {
        private readonly AvaliacaoA1.Data.AvaliacaoA1Context _context;

        public DeleteModel(AvaliacaoA1.Data.AvaliacaoA1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Lembrete Lembrete { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lembrete = await _context.Lembrete.FindAsync(id);
            if (lembrete != null)
            {
                Lembrete = lembrete;
                _context.Lembrete.Remove(Lembrete);
                await _context.SaveChangesAsync();
            }

            return new JsonResult(true);
        }
    }
}
