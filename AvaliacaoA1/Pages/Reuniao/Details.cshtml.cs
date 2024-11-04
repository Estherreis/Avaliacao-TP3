using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AvaliacaoA1.Data;
using AvaliacaoA1.Models;

namespace AvaliacaoA1.Pages.Reuniao
{
    public class DetailsModel : PageModel
    {
        private readonly AvaliacaoA1Context _context;

        public DetailsModel(AvaliacaoA1Context context)
        {
            _context = context;
        }

        public Models.Reuniao Reuniao { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Reuniao = await _context.Reuniao
                .Include(r => r.MembroReunioes)
                .ThenInclude(mr => mr.Membro)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Reuniao == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
