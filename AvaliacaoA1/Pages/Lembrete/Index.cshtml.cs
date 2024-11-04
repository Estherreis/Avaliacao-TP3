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
    public class IndexModel : PageModel
    {
        private readonly AvaliacaoA1.Data.AvaliacaoA1Context _context;

        public IndexModel(AvaliacaoA1.Data.AvaliacaoA1Context context)
        {
            _context = context;
        }

        public IList<Models.Lembrete> Lembrete { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Lembrete = await _context.Lembrete
                .Include(l => l.Membro).ToListAsync();
        }
    }
}
