﻿using System;
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
    public class DetailsModel : PageModel
    {
        private readonly AvaliacaoA1Context _context;

        public DetailsModel(AvaliacaoA1Context context)
        {
            _context = context;
        }

        public Models.Lembrete Lembrete { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            // Inclui a entidade Membro ao buscar o lembrete
            Lembrete = await _context.Lembrete
                .Include(l => l.Membro)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Lembrete == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
